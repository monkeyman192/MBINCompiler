# Extract all the class definitions from the NMS.exe

from abc import ABC
import argparse
import os
import os.path as op
import pathlib
import re
import struct
import subprocess
import time

# import jinja2
import pymem


EXTRA_CLASSES = ['cAxisSpecification', 'cCgExpeditionCategoryStrength']
# Classes that don't look like globals but actually are.
ACTUALLY_GLOBALS = ['GcSceneOptions', 'GcSmokeTestOptions', 'GcDebugOptions']
NAME_MAPPING = {
    'GcDefaulMissionProduct': 'GcDefaultMissionProduct',
    'GcDefaulMissionSubstance': 'GcDefaultMissionSubstance',
}

SUMMARY_FILE = op.join(op.dirname(__file__), 'summary.txt')

STATIC_BASE = 0x140000000
TYPE_MAPPING = {
    0x00: 'undefined',
    0x01: 'bool',
    0x02: 'byte',
    0x03: 'CUSTOM',
    0x04: 'NMSTemplate',
    0x05: 'Colour',
    0x06: 'LIST',
    0x07: 'VariableSizeString',
    0x09: 'ENUM',
    0x0A: 'NMSString0x80',  # Technically a "filename" -> GcFilename (?)
    0x0B: 'FLAGENUM',  # Looks like this isn't in the data completely... :/
    0x0C: 'float',
    0x0D: 'NMSString0x10',
    0x0E: 'NMSString0x20A',  # There seems to be no difference in use between this
    0x0F: 'NMSString0x20A',  # and this...
    0x11: 'short',
    0x12: 'int',
    0x13: 'long',
    0x14: 'GcNodeID',
    0x15: 'GcResource',
    0x16: 'GcSeed',
    0x17: 'ARRAY',
    0x18: 'NMSString0x20',
    0x19: 'NMSString0x40',
    0x1A: 'NMSString0x80',
    0x1B: 'NMSString0x100',
    0x1C: 'NMSString0x200',
    0x1D: 'NMSString0x400',
    0x1E: 'NMSString0x800',
    0x20: 'ushort',
    0x21: 'uint',
    0x22: 'ulong',
    0x24: 'Vector2f',
    0x25: 'Vector3f',
    0x26: 'Vector4f',
}
PREFIX_MAPPING = {
    'ccg': 'GameComponents',
    'cgc': 'GameComponents',
    'ctk': 'Toolkit'
}
USING_MAPPING = {
    'gc': 'libMBIN.NMS.GameComponents',
    'cg': 'libMBIN.NMS.GameComponents',
    'tk': 'libMBIN.NMS.Toolkit'
}

FIELD_TEMPLATE = "        /* {0} */ public {1} {2};"
ENUM_TEMPLATE = """        // size: {3}
        public enum {1}Enum{4} {{
{2}
        }}
        /* {0} */ public {1}Enum {1};"""
ARRAY_TEMPLATE = """        [NMS(Size = {3})]
        /* {0} */ public {1} {2};"""

# 0: usings: NB: End with two \n's
# 1: namespace
# 2: size
# 3: GUID
# 4: namehash
# 5: Extra attributes (optional, normally '')  # TODO: Remove?
# 6: class name
# 7: fields

CLASS_TEMPLATE = """{0}namespace {1}
{{
    [NMS(Size = {2}, GUID = {3}, NameHash = {4}{5})]
    public class {6} : NMSTemplate
    {{
{7}
    }}
}}
"""


"""
Details on the format of the 0x60 bytes for each field:

0x00: (uint64*) pointer to the name of the field. This is null-terminated.
0x08: ???
0x10: (uint64*) pointer to the string 'Base'
0x18: ???
0x1C: (uint32) Type of field (see conversion table)
0x20: (if 0x1C == 0x6 || 0x17): List/Array type (see conversion table)
0x24: (uint32) Size of field in bytes.
0x28: (uint32) Array Size. 1 if not an array.
0x2C: (uint32) Relative offset within the class.
0x30: (if 0x1C == 0x03 || 0x20 == 0x03) (uint64* -> uint64*) pointer to pointer
        to type name
0x38: (if 0x1C == 0x09): (uint64*) pointer to a table with the enum values and
        pointers to the values:
    table of:
        (uint64): enum index
        (uint64*): pointer to name of enum value.
0x40: (if 0x1C == 0x09): enum count.
0x44: (float) 1.0 (always?)
0x48: ??? (seems to always be (uint32) 3 or 4) Can't see why it's which or what
        it even means...
0x50: ???
"""


def fmt_hex(x: int) -> str:
    """ Return the integer input formatted as a upper-case hexadecimal value """
    return '0x' + hex(x).upper()[2:]


class Field(ABC):
    # Field ABC which will be inherited by the other Field concrete sub-classes.
    # This gives some basic functionality and does some common processing.
    def __init__(self, data: bytes, nms_mem):
        self.data = data
        self.raw_field_type = 0x00
        self.field_size = 0x0
        self.is_array = False
        self.is_list = False
        self.is_enum = False

        # Get the name of the field.
        self.field_name = nms_mem.read_string(
            struct.unpack_from('<Q', data, offset=0x0)[0]
        )
        self.field_size = struct.unpack_from('<I', data, offset=0x24)[0]
        self._array_size = struct.unpack_from('<I', data, offset=0x28)[0]
        self._field_offset = struct.unpack_from('<I', data, offset=0x2C)[0]

        # Sort out the requirements for this field.
        self.required_using: set = set()

        # The number of hexadecimal digits the maximum offset has.
        self.max_offset_width = 1

    @property
    def field_type(self):
        return TYPE_MAPPING.get(
            self.raw_field_type,
            f'unknown ({self.raw_field_type:X})'
        )

    @property
    def field_offset(self):
        return '0x{0:>0{width}}'.format(
            fmt_hex(self._field_offset)[2:], width=self.max_offset_width
        )

    @property
    def array_size(self):
        return fmt_hex(self._array_size)

    def __str__(self):
        return FIELD_TEMPLATE.format(
            self.field_offset, self.field_type, self.field_name
        )

    @classmethod
    def instantiate(cls, data: bytes, nms_mem: pymem.Pymem):
        """ Return an instance of a subclass which is of the appropriate type
        based on the raw type specified in the data.
        This allows us to simplify the logic regarding deserialising the field
        by deferring it to the individual classes.
        """
        raw_type = struct.unpack_from('<I', data, offset=0x1C)[0]
        if raw_type == 0x09 or raw_type == 0x0B:
            return EnumField(data, nms_mem)
        elif raw_type == 0x06:
            return ListField(data, nms_mem)
        elif raw_type == 0x17:
            return ArrayField(data, nms_mem)
        elif raw_type == 0x03:
            return CustomField(data, nms_mem)
        else:
            return NormalField(data, nms_mem, raw_type)


class NormalField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem, raw_field_type):
        super().__init__(data, nms_mem)
        self.raw_field_type = raw_field_type


class CustomField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x03

        # Get the pointer to the custom type name.
        ptr_custom_type = nms_mem.read_ulonglong(
            struct.unpack_from('<Q', data, offset=0x30)[0]
        )
        # Now get the actual name.
        self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]

        if self.field_type[:2].lower() in ('cg', 'gc', 'tk'):
            self.required_using = {
                USING_MAPPING.get(self.field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents'),
            }
        elif self.field_type == 'AxisSpecification':
            self.required_using = {'libMBIN.NMS.GameComponents', }

    @property
    def field_type(self):
        return NAME_MAPPING.get(self._field_type, self._field_type)


class ArrayField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.is_array = True
        self.raw_field_type = 0x17
        # Multiply the field size by the array size to get the correct size
        self.field_size *= self._array_size

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        # A custom array subtype.
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using = {
                USING_MAPPING.get(self._field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents'),
            }
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f'unknown {array_type_raw:X}'
            )

    @property
    def field_type(self):
        return f'{NAME_MAPPING.get(self._field_type, self._field_type)}[]'


    def __str__(self):
        return ARRAY_TEMPLATE.format(
            self.field_offset, self.field_type, self.field_name, self.array_size
        )



class ListField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.is_list = True
        self.raw_field_type = 0x06
        self.field_size = 0x10
        self.required_using = {'System.Collections.Generic', }

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using.add(
                USING_MAPPING.get(self._field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents')
            )
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f"unknown {array_type_raw:X}"
            )

    @property
    def field_type(self):
        return f'List<{NAME_MAPPING.get(self._field_type, self._field_type)}>'


class EnumField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.is_enum = True
        self.raw_field_type = 0x09
        self.requires_values = False

        enum_count = struct.unpack_from('<I', data, offset=0x40)[0]
        ptr_enum_data = struct.unpack_from('<Q', data, offset=0x38)[0]
        self.enum_data = []
        for i in range(enum_count):
            idx = nms_mem.read_uint(ptr_enum_data + i * 0x10)
            ptr_enum_name = nms_mem.read_ulonglong(ptr_enum_data + i * 0x10 + 0x8)
            enum_name = nms_mem.read_string(ptr_enum_name, byte=128)
            # If the string starts with a number we need to prefix with an
            # underscore so that the name is not illegal.
            if enum_name[0].isdigit():
                enum_name = '_' + enum_name
            self.enum_data.append((idx, enum_name))
        # Most enums have keys which are concurrent. Some however are not, so
        # we detect this by comparing to the expected range.
        if [x[0] for x in self.enum_data] != list(range(enum_count)):
            self.requires_values = True

    def __str__(self):
        if self.requires_values:
            enum_vals = [
                f'            {x[1]} = {fmt_hex(x[0])}' for x in self.enum_data
            ]
            enum_vals = ',\n'.join(enum_vals)
        else:
            enum_vals = ',\n'.join([' ' * 12 + x[1] for x in self.enum_data])
        enum_type = ''
        if self.requires_values:
            enum_type = ' : uint'
        return ENUM_TEMPLATE.format(
            self.field_offset,
            self.field_name,
            enum_vals,
            fmt_hex(len(self.enum_data)),
            enum_type,
        )


class NMSClass():
    def __init__(self, name: str, name_hash: int, guid: int):
        self.fields = []
        self.name = name
        self.name_hash = fmt_hex(name_hash)
        self.guid = fmt_hex(guid)
        self.required_usings = set()
        if self.name not in ACTUALLY_GLOBALS and not self.name.endswith('Globals'):
            self.namespace = USING_MAPPING.get(
                self.name[:2].lower(), 'libMBIN.NMS.GameComponents'
            )
        else:
            self.namespace = 'libMBIN.NMS.Globals'
        self.size = 1

    def add_fields(self, fields: list[Field]):
        # Add a list of field objects.
        # This is a little hacky and could be done a bit better but this does
        # work...
        self.fields = fields
        max_offset_width = 1
        # For each field find if it requires something and add it to the
        # required usings.
        for field in fields:
            if field.required_using:
                self.required_usings.update(field.required_using)
        # If there are some fields, calculate the maximum offset so that we can
        # nicely format the offset comments.
        if self.fields:
            max_offset_width = len(self.fields[-1].field_offset) - 2
            self.size = self.fields[-1]._field_offset + self.fields[-1].field_size
        # Finally, for each field, give it this found max_offset_width
        for field in self.fields:
            field.max_offset_width = max_offset_width

    def __str__(self):
        # String representation. This will be the contents of the .cs file.
        if self.required_usings:
            ru = [f'using {x};' for x in self.required_usings]
            ru.sort(reverse=True)
            usings = '\n'.join(ru) + '\n\n'
        else:
            usings = ''
        return CLASS_TEMPLATE.format(
            usings,
            self.namespace,
            fmt_hex(self.size),
            self.guid,
            self.name_hash,
            '',  # TODO: add this if needed?
            self.name,
            '\n'.join([str(x) for x in self.fields]),
        )


def read_class(nms_mem: pymem.Pymem, address: int):
    """
    Take an array of 24 bytes and extract some information:
    0x00: (uint64*): Class name
    0x08: (uint64): Name Hash
    0x10: (uint64): GUID
    0x18: (uint64*): Data
    0x20: (uint32): Number of fields.
    """
    data = nms_mem.read_bytes(address, 0x24)
    ptr_name, name_hash, guid, ptr_data, field_num = struct.unpack(
        '<QQQQI', data)
    name = nms_mem.read_string(ptr_name, byte=128)
    if (name.startswith('cGc') and name.endswith('Globals')) or name[1:] in ACTUALLY_GLOBALS:
        dir_ = 'Globals'
    else:
        dir_ = PREFIX_MAPPING.get(name[:3].lower(), "GameComponents")
    out_dir = f'./output/{dir_}'
    if not op.exists(out_dir):
        os.makedirs(out_dir, exist_ok=True)
    fields = extract(nms_mem, ptr_data, field_num)
    # If the name needs to be fix do so here.
    name = NAME_MAPPING.get(name[1:], name[1:])
    cls = NMSClass(name, name_hash, guid)
    cls.add_fields(fields)
    with open(op.join(out_dir, name + '.cs'), 'w') as f:
        f.write(str(cls))


def extract(nms_mem: pymem.Pymem, address: int, field_count: int) -> list[Field]:
    # Take the 0x60 bytes and process them.
    fields = []
    for i in range(field_count):
        data = nms_mem.read_bytes(address + i * 0x60, 0x60)
        field = Field.instantiate(data, nms_mem)
        fields.append(field)

    return fields


def find_classes(nms_path: pathlib.Path):
    with open(nms_path, 'rb') as f:
        data = f.read()
        # First, find the start and ends of the .rdata section.
        rdata_hdr = data.find(b'.rdata')
        rdata_size, rdata_offset, _, ptr_address = struct.unpack_from(
            '<IIII',
            data,
            offset=rdata_hdr + 8
        )

        # The pointer will different from the actual offset by some amount we
        # need to take into account.
        virtual_offset = rdata_offset - ptr_address

        subdata = data[rdata_offset: rdata_offset + rdata_size]
        # Find all the classes which match the regex.
        for m in re.finditer(b'(c((?:Gc)|(?:Tk))\w+)\x00', data, flags=re.IGNORECASE):
            # For each one, extract the name, and also record the location the
            # name occurs at.
            name = m[0].strip(b'\x00').decode()
            if not name.startswith('c'):
                continue
            addr = m.span()[0] + virtual_offset + STATIC_BASE
            # Now search the exe for this address.
            found_addr = subdata.find(struct.pack('<Q', addr))
            # If we find it, then at this location we will have all the data we
            # need.
            if found_addr != -1:
                found_addr += rdata_offset
                yield name, found_addr + virtual_offset
        for name in EXTRA_CLASSES:
            # For the extra classes we'll be lazy and find them slightly
            # differently...
            addr = data.find(name.encode())
            addr = addr + virtual_offset + STATIC_BASE
            # Now search the exe for this address.
            found_addr = subdata.find(struct.pack('<Q', addr))
            # If we find it, then at this location we will have all the data we
            # need.
            if found_addr != -1:
                found_addr += rdata_offset
                yield name, found_addr + virtual_offset


if __name__ == '__main__':
    parser = argparse.ArgumentParser(
        description='Run NMS.exe and extract all the class definitions'
    )
    parser.add_argument(
        '--nms_path',
        type=pathlib.Path,
        default='C://GOG Games//No Man\'s Sky//Binaries//NMS.exe'
    )

    args = parser.parse_args()

    nms_proc = subprocess.Popen(args.nms_path)
    try:
        # Wait some time for the data to be written to memory.
        time.sleep(2)
        # Now find the process with pymem.
        # If there is for some reason multiple instances of NMS running this
        # will probably have issues...
        nms = pymem.Pymem('NMS.exe')
        nms_base = nms.base_address
        t1 = time.time()
        names = []
        for name, offset in find_classes(args.nms_path):
            read_class(nms, nms_base + offset)
            if name[1:] in NAME_MAPPING:
                name = 'c' + NAME_MAPPING[name[1:]]
            names.append(name)
        names.sort()
        with open(SUMMARY_FILE, 'w') as f:
            f.write('\n'.join(names))
        print(f'Took {time.time() - t1}s')
        # Kill the NMS process.
    except Exception as exc:
        raise exc
    finally:
        nms_proc.terminate()

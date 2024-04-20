# Extract all the class definitions from the NMS.exe

from abc import ABC
import configparser
import importlib
import json
import os
import os.path as op
import pathlib
import re
from signal import SIGTERM
import struct
import subprocess
import time
from typing import Optional

from jinja2 import Template
import pymem


GUID_REGEX = re.compile(r'GUID = (0x[a-fA-F0-9]+)')


if __name__ == "__main__":
    # Handle the loading of the config first before declaring any constants, as
    # we will want to also import the constants file. This will need to be done
    # based on the folder which we are reading from.
    config = configparser.ConfigParser()
    config_path = op.join(op.dirname(__file__), 'extract.cfg')
    if not op.exists(config_path):
        raise FileNotFoundError('extract.cfg not found in same directory as '
                                'this script. Please copy the '
                                'extract.cfg.sample file, rename it '
                                'extract.cfg, and modify any values as needed.')
    config.read(config_path)
    TEMPLATE_DIR = config['general'].get(
        'template_dir',
        fallback='templates/default/'
    )
    _constants = op.join(TEMPLATE_DIR, 'constants')
    _constants = re.sub(r'([\\/])', '.', _constants)
    # TODO: This won't work unless the script is run from the same directory it
    # is in. Fix this.
    constants = importlib.import_module(_constants)
    static_templates_dir = op.join(TEMPLATE_DIR, 'static_templates')
    static_templates = {}
    if op.exists(static_templates_dir):
        for fname in os.listdir(static_templates_dir):
            fullpath = op.join(static_templates_dir, fname)
            with open(fullpath, 'r') as f:
                if guid := re.search(GUID_REGEX, f.read()):
                    guid = guid.group(1)
                    static_templates[op.splitext(fname)[0]] = (fullpath, guid)


ENUM_OVERRIDES = {
    'GcCreatureGlobals': {
        'Temperments': 'GcCreatureRoles.CreatureRoleEnum',
        'TempermentDescriptions': 'GcCreatureRoles.CreatureRoleEnum',
        'Diets': 'GcCreatureDiet.DietEnum',
        'WaterDiets': 'GcCreatureDiet.DietEnum',
        'DietMeat': 'GcBiomeType.BiomeEnum',
        'DietVeg': 'GcBiomeType.BiomeEnum',
        'DietDescriptions': 'GcCreatureDiet.DietEnum',
        'WaterDietDescriptions': 'GcCreatureDiet.DietEnum',
        'BiomeDescriptions': 'GcBiomeType.BiomeEnum',
        'BiomeWaterDescriptions': 'GcBiomeType.BiomeEnum',
        'BiomeAirDescriptions': 'GcBiomeType.BiomeEnum',
        'WeirdBiomeDescriptions': 'GcBiomeSubType.BiomeSubTypeEnum',
        'PetBiomeClimates': 'GcBiomeType.BiomeEnum',
    },
    'GcEnvironmentProperties': {'SkyHeight': 'GcPlanetSize.PlanetSizeEnum'},
    'GcGalaxyGenerationSetupData': {
        'StarSize': 'GcGalaxyStarTypes.GalaxyStarTypeEnum',
    },
    'GcGalaxyGlobals': {
        'RaceFilterDefaultColours': 'GcAlienRace.AlienRaceEnum',
        'RaceFilterProtanopiaColours': 'GcAlienRace.AlienRaceEnum',
        'RaceFilterDeuteranopiaColours': 'GcAlienRace.AlienRaceEnum',
        'RaceFilterTritanopiaColours': 'GcAlienRace.AlienRaceEnum',
        'EconomyFilterDefaultColours': 'GcTradingClass.TradingClassEnum',
        'EconomyFilterProtanopiaColours': 'GcTradingClass.TradingClassEnum',
        'EconomyFilterDeuteranopiaColours': 'GcTradingClass.TradingClassEnum',
        'EconomyFilterTritanopiaColours': 'GcTradingClass.TradingClassEnum',
        'ConflictFilterDefaultColours': 'GcPlayerConflictData.ConflictLevelEnum',
        'ConflictFilterProtanopiaColours': 'GcPlayerConflictData.ConflictLevelEnum',
        'ConflictFilterDeuteranopiaColours': 'GcPlayerConflictData.ConflictLevelEnum',
        'ConflictFilterTritanopiaColours': 'GcPlayerConflictData.ConflictLevelEnum',
        'MarkerSettings': 'GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum',
    },
    'GcGameplayGlobals': {
        'SalvageRewardsShuttle': 'GcInventoryClass.InventoryClassEnum',
        'SalvageRewardsDropship': 'GcInventoryClass.InventoryClassEnum',
        'SalvageRewardsFighter': 'GcInventoryClass.InventoryClassEnum',
        'SalvageRewardsScience': 'GcInventoryClass.InventoryClassEnum',
        'FreighterTechQualityWeightings': 'GcProceduralTechnologyData.QualityEnum',
    },
    'GcSolarGenerationGlobals': {
        'ExtremePlanetChance': 'GcGalaxyStarTypes.GalaxyStarTypeEnum',
        'AbandonedSystemProbability': 'GcGalaxyStarTypes.GalaxyStarTypeEnum',
        'EmptySystemProbability': 'GcGalaxyStarTypes.GalaxyStarTypeEnum',
        'PirateSystemProbability': 'GcGalaxyStarTypes.GalaxyStarTypeEnum',
    },
    'GcTerrainGlobals': {'MiningSubstanceBiome': 'GcBiomeType.BiomeEnum'},
    'GcPlayerSquadronConfig': {
        'PilotRankTraitRanges': 'GcInventoryClass.InventoryClassEnum',
        'PilotRankAttackDefinitions': 'GcInventoryClass.InventoryClassEnum',
    },
    'GcUIGlobals': {
        'CrosshairTargetLockSizeSpecific': 'GcPlayerWeapons.WeaponModeEnum',
    },
}

EXTRA_CLASSES = ['cAxisSpecification', 'cCgExpeditionCategoryStrength']
# Classes that don't look like globals but actually are.
ACTUALLY_GLOBALS = ['GcSceneOptions', 'GcSmokeTestOptions', 'GcDebugOptions']
NAME_MAPPING = {
    'GcDefaulMissionProduct': 'GcDefaultMissionProduct',
    'GcDefaulMissionSubstance': 'GcDefaultMissionSubstance',
    'gcwordcategorytableEnum': 'GcWordCategoryTableEnum',
    'GCHUDEffectRewardData': 'GcHUDEffectRewardData',
}
# Flag enums fixes
FLAG_ENUM_FIXES = {
    'false_positives': [],
    'false_negatives': [
        'HotspotType',
        'CollisionGroup',
        'MetadataReadMask',
        'InputActionInfoFlags',
    ],
}
# Lookup for classes with extra attributes.
EXTRA_ATTRIBUTES = {
    'GcPlayerClothComponentData': ', Alignment = 0x10',
    'GcClothComponentData': ', Alignment = 0x10',
}
# List of classes to avoid overwriting as the have custom deserialisation
# methods.
# TODO: If the GUID changes we need to raise an important message so that we may
# fix it manually.
DONT_OVERRIDE = [
    'TkAnimNodeFrameData',
    'TkAnimNodeFrameHalfData',
    'TkGeometryData',
    'TkMeshData',
]

SUMMARY_FILE = op.join(op.dirname(__file__), 'summary.txt')
TEMPLATES_DIR = op.join(op.dirname(__file__), TEMPLATE_DIR)
PROJITEMS_TEMPLATE = op.join(TEMPLATES_DIR, 'libMBIN-Shared.projitems.j2')
# Check to see if the projitems.j2 exists. If not then we don't need to fill it
# in and copy it over.
USE_PROJITEMS = op.exists(PROJITEMS_TEMPLATE)
CLASS_TEMPLATE = op.join(TEMPLATES_DIR, 'class_template.j2')

STATIC_BASE = 0x140000000
# This is cTkMetaDataMember::eType
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
    0x0B: 'FLAGENUM',
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
PRIMITIVES = (0x01, 0x02, 0x09, 0x0B, 0x0C, 0x11, 0x12, 0x13, 0x20, 0x21, 0x22)
PREFIX_MAPPING = {
    'ccg': 'GameComponents',
    'cgc': 'GameComponents',
    'ctk': 'Toolkit'
}


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
      (if 0x1C == 0x17) pointer to a table with the enum values for the array
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

        # properties which are overwritten by subclasses which need to specify
        # them.
        self._is_enum_field = False
        self._is_array_field = False
        self._is_list_field = False

        # Get the name of the field.
        self._field_name = nms_mem.read_string(
            struct.unpack_from('<Q', data, offset=0x0)[0], byte=128
        )
        # Some field names are annoyingly duplicated in the exe. c# doesn't
        # allow this, so we need to add something to the name to make it unique.
        self._field_name_is_duplicate = False
        self.field_size = struct.unpack_from('<I', data, offset=0x24)[0]
        self._array_size = struct.unpack_from('<I', data, offset=0x28)[0]
        self._field_offset = int(struct.unpack_from('<I', data, offset=0x2C)[0])

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
    def field_name(self):
        if self._field_name[0].isdigit():
            return '_' + self._field_name
        if self._field_name_is_duplicate:
            return self._field_name + '_' + self.field_type
        if self._field_name[:2].lower() in {'gc', 'tk'}:
            return self._field_name[2:]
        return self._field_name

    @property
    def field_offset(self):
        return '0x{0:>0{width}}'.format(
            fmt_hex(self._field_offset)[2:], width=self.max_offset_width
        )

    @property
    def array_size(self):
        return fmt_hex(self._array_size)

    @classmethod
    def instantiate(cls, data: bytes, nms_mem: pymem.Pymem):
        """ Return an instance of a subclass which is of the appropriate type
        based on the raw type specified in the data.
        This allows us to simplify the logic regarding deserialising the field
        by deferring it to the individual classes.
        """
        raw_type = struct.unpack_from('<I', data, offset=0x1C)[0]
        if raw_type == 0x09 or raw_type == 0x0B:
            ef = EnumField(data, nms_mem)
            if raw_type == 0x0B:
                ef.is_flag = True
            ef.check_flag_overwrites()
            return ef
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
            self.required_using.add(
                constants.USING_MAPPING.get(self.field_type[:2].lower(),
                                            constants.USING_MAPPING['gc'])
            )
        elif self.field_type == 'AxisSpecification':
            self.required_using.add(constants.USING_MAPPING['gc'])

    @property
    def field_type(self):
        return NAME_MAPPING.get(self._field_type, self._field_type)


class ArrayField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x17
        # Multiply the field size by the array size to get the correct size
        self.field_size *= self._array_size
        self.array_enum = None
        self.ptr_enum: int = 0
        self.array_enum_type: Optional[str] = None
        self._is_array_field = True
        self.local_enum = False

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        # A custom array subtype.
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using.add(
                constants.USING_MAPPING.get(self._field_type[:2].lower(),
                                            constants.USING_MAPPING['gc'])
            )
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f'unknown {array_type_raw:X}'
            )
        # Determine the associated EnumType
        self.ptr_enum = struct.unpack_from('<Q', data, offset=0x38)[0]
        # This may be a nullptr, in which case we end as we have no enum to get.
        if self.ptr_enum == 0:
            return
        # If the pointer is non-zero, then it will be a pointer to the enums
        # either associated with some other class, or an inline one.
        # We need to keep track of the pointer do we can determine what class
        # it was later.
        # Get all the values of the enum:
        self.array_enum = []
        for i in range(self._array_size):
            ptr_enum_name = nms_mem.read_ulonglong(self.ptr_enum + i * 0x10 + 0x8)
            name = nms_mem.read_string(ptr_enum_name, byte=128)
            # 'default' (all lowercase) is a resticted word in c#.
            # Replace the leading 'd' with 'D'.
            if name == 'default':
                name = 'Default'
            self.array_enum.append(name)

    @property
    def field_type(self):
        return f'{NAME_MAPPING.get(self._field_type, self._field_type)}'


class ListField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x06
        self.field_size = 0x10
        self.required_using.add('System.Collections.Generic')
        self._is_list_field = True

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using.add(
                constants.USING_MAPPING.get(self._field_type[:2].lower(),
                                  constants.USING_MAPPING['gc'])
            )
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f"unknown {array_type_raw:X}"
            )

    @property
    def field_type(self):
        return NAME_MAPPING.get(self._field_type, self._field_type)


class EnumField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self._is_flag: bool = False
        self.raw_field_type = 0x09
        self.requires_values = False
        self._is_enum_field = True

        enum_count = struct.unpack_from('<I', data, offset=0x40)[0]
        self.ptr_enum = struct.unpack_from('<Q', data, offset=0x38)[0]
        self.enum_data = []
        # For each enum value, read the index, and a pointer to the name.
        for i in range(enum_count):
            idx = nms_mem.read_uint(self.ptr_enum + i * 0x10)
            ptr_enum_name = nms_mem.read_ulonglong(self.ptr_enum + i * 0x10 + 0x8)
            enum_name = nms_mem.read_string(ptr_enum_name, byte=128)
            # If the string starts with a number we need to prefix with an
            # underscore so that the name is not illegal.
            if enum_name:
                if enum_name[0].isdigit():
                    enum_name = '_' + enum_name
                # 'default' (all lowercase) is a resticted word in c#.
                # Replace the leading 'd' with 'D'.
                if enum_name == 'default':
                    enum_name = 'Default'
            else:
                enum_name = 'None'
            self.enum_data.append((idx, enum_name))
        # Most enums have keys which are concurrent. Some however are not, so
        # we detect this by comparing to the expected range.
        if [x[0] for x in self.enum_data] != list(range(enum_count)):
            self.requires_values = True
        if self.requires_values:
            # Reformat the values so that they appear in hex in the output.
            for i, data in enumerate(self.enum_data):
                self.enum_data[i] = (fmt_hex(data[0]), data[1])

    def check_flag_overwrites(self):
        # Check our overwrites and modify the `is_flag` property appropriately.
        if self.field_name in FLAG_ENUM_FIXES['false_negatives']:
            self.is_flag = True
        elif self.field_name in FLAG_ENUM_FIXES['false_positives']:
            self.is_flag = False

    @property
    def enum_dtype(self) -> str:
        if self.field_size == 0x4:
            return 'uint'
        elif self.field_size == 0x2:
            return 'ushort'
        elif self.field_size == 0x1:
            return 'byte'
        else:
            raise ValueError(f'The field {self.field_name} has an unexpected '
                             f'size: {self.field_size}')

    @property
    def is_flag(self) -> bool:
        return self._is_flag

    @property
    def enum_count(self) -> str:
        return fmt_hex(len(self.enum_data))

    @is_flag.setter
    def is_flag(self, value: bool):
        self._is_flag = value
        if value is True:
            self.required_using.add('System')
        elif value is False:
            # Remove the System using requirement.
            self.required_using -= {'System', }


class NMSClass():
    enum_reference_data: dict = {}

    def __init__(self, name: str, name_hash: int, guid: int):
        self.fields = []
        self._field_names = set()
        self.name = name
        self.name_hash = fmt_hex(name_hash)
        self._guid = guid
        self.guid = fmt_hex(guid)
        self.required_usings = set()
        if self.name not in ACTUALLY_GLOBALS and not self.name.endswith('Globals'):
            self.namespace = constants.USING_MAPPING.get(
                self.name[:2].lower(), constants.USING_MAPPING['gc']
            )
        elif self.name.endswith("TkGlobals"):
            self.namespace = constants.USING_MAPPING['tk']
        else:
            self.namespace = constants.USING_MAPPING['globals']
        self.is_enum_class = False
        self.ptr_enum = None
        self.output_fname = None
        self.has_enum_arrays = False
        self.usings = []
        self.extra_attributes = ''

    def add_fields(self, fields: list[Field]):
        # Add a list of field objects.
        # This is a little hacky and could be done a bit better but this does
        # work...
        self.fields = fields
        self.fields.sort(key=lambda x: x._field_offset)
        max_offset_width = 1
        # For each field find if it requires something and add it to the
        # required usings.
        for field in fields:
            if field.required_using:
                self.required_usings.update(field.required_using)
            if field.field_name not in self._field_names:
                self._field_names.add(field.field_name)
            else:
                field._field_name_is_duplicate = True
        # If there are some fields, calculate the maximum offset so that we can
        # nicely format the offset comments.
        if self.fields:
            max_offset_width = len(self.fields[-1].field_offset) - 2
        # Finally, for each field, give it this found max_offset_width
        for field in self.fields:
            field.max_offset_width = max_offset_width

        # Determine if the class is an enum class
        if len(fields) == 1 and isinstance(fields[0], EnumField):
            self.is_enum_class = True
            self.ptr_enum = fields[0].ptr_enum
            NMSClass.enum_reference_data[fields[0].ptr_enum] = f'{self.name}.{fields[0].field_name}Enum'

    def update_array_enum_refs(self):
        # Update the enum array references for the required fields.
        # To make it faster, only do this for classes which need it.
        if self.has_enum_arrays or self.name in ENUM_OVERRIDES:
            for field in self.fields:
                if isinstance(field, ArrayField):
                    field.array_enum_type = NMSClass.enum_reference_data.get(
                        field.ptr_enum
                    )
                    if field.array_enum_type is not None:
                        self.required_usings.add(
                            constants.USING_MAPPING.get(
                                field.array_enum_type[:2].lower(),
                                constants.USING_MAPPING['gc']
                            )
                        )
                    elif field.field_name in ENUM_OVERRIDES.get(self.name, {}):
                        # Check to see if the field name is in the override
                        # mapping.
                        # If it is add the type and also the required usings
                        # mapping.
                        field.array_enum_type = ENUM_OVERRIDES[self.name].get(
                            field.field_name
                        )
                        if field.array_enum_type is not None:
                            self.required_usings.add(
                                constants.USING_MAPPING.get(
                                    field.array_enum_type[:2].lower(),
                                    constants.USING_MAPPING['gc']
                                )
                            )
                            # Set the array_enum property to be an empty list so
                            # that the actual enum type is written.
                            field.array_enum = []
                    elif field.array_enum is not None:
                        field.local_enum = True
                        field.array_enum_type = f'{field.field_name}Enum'

    def finalise(self):
        if self.required_usings:
            self.usings = [x for x in self.required_usings]
            self.usings.sort(reverse=True)
        self.extra_attributes = EXTRA_ATTRIBUTES.get(self.name, '')


    def write(self, template):
        self.finalise()
        with open(self.output_fname, 'w') as f:
            f.write(template.render(cls=self))


def read_class(
    nms_mem: pymem.Pymem,
    address: int,
    filepaths: list[str],
    config: configparser.ConfigParser
) -> NMSClass:
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
    if (config['general'].getboolean('replace_existing_files', fallback=False)
        and name[1:] not in DONT_OVERRIDE
    ):
        out_dir = config['general'].get('output_dir', fallback='./output')
    else:
        out_dir = './output'
    if out_dir != './output':
        out_dir = op.join(out_dir, 'Source', 'NMS')
    # Add the folder to the output path directory
    out_dir = op.join(op.dirname(__file__), out_dir, dir_)
    if not op.exists(out_dir):
        os.makedirs(out_dir, exist_ok=True)
    fields, has_enum_arrays = extract(nms_mem, ptr_data, field_num)
    # If the name needs to be fix do so here.
    name = NAME_MAPPING.get(name[1:], name[1:])
    cls = NMSClass(name, name_hash, guid)
    cls.add_fields(fields)
    cls.output_fname = op.join(out_dir, name + '.cs')
    cls.has_enum_arrays = has_enum_arrays
    filepaths.append(f'{dir_}\\{name}')
    return cls


def extract(nms_mem: pymem.Pymem, address: int, field_count: int) -> tuple[list[Field], bool]:
    # Take the 0x60 bytes and process them.
    fields = []
    has_enum_arrays = False
    for i in range(field_count):
        data = nms_mem.read_bytes(address + i * 0x60, 0x60)
        field = Field.instantiate(data, nms_mem)
        # As we add fields, determine if the field is an array with an
        # associated enum. If it is then set a flag.
        if (not has_enum_arrays
            and isinstance(field, ArrayField)
            and field.array_enum is not None
        ):
            has_enum_arrays = True
        fields.append(field)

    return fields, has_enum_arrays


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
            # else:
            #     print(name)
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
    # First, handle the configuration loading.
    binary_path = config['NMS']['binary_path']

    nms_proc = subprocess.Popen(binary_path)
    print(f'Opened NMS with PID: {nms_proc.pid}')
    filepaths = []
    if USE_PROJITEMS:
        with open(PROJITEMS_TEMPLATE, 'r') as f:
            template = Template(f.read())

    # Load the class template.
    with open(CLASS_TEMPLATE, 'r') as f:
        class_template = Template(f.read())

    try:
        # Wait some time for the data to be written to memory.
        time.sleep(config['general'].getint('wait_time', fallback=10))
        # Now find the process with pymem.
        # If there is for some reason multiple instances of NMS running this
        # will probably have issues...
        nms = pymem.Pymem('NMS.exe')
        nms_base = nms.base_address
        t1 = time.time()
        names: list[str] = []
        classes: list[NMSClass] = []
        class_guid_mapping: dict[str, str] = {}
        guids: list[int] = []
        for name, offset in find_classes(binary_path):
            cls_ = read_class(nms, nms_base + offset, filepaths, config)
            if name[1:] in NAME_MAPPING:
                name = 'c' + NAME_MAPPING[name[1:]]
            names.append(f'{name}, {nms_base + offset:X}')
            classes.append(cls_)
            class_guid_mapping[cls_.guid] = cls_.name
            guids.append(cls_._guid)
        names.sort()
        with open(SUMMARY_FILE, 'w') as f:
            f.write('\n'.join(names))
        if config['general'].getboolean('write_guid_json', fallback=False):
            # Experimental code to generate a mapping of GUID's to names.
            _guid_hash = 0
            for guid in guids:
                _guid_hash = (_guid_hash ^ guid) & 0xFFFFFFFFFFFFFFFF
            with open(f'guids_{fmt_hex(_guid_hash)}.json', 'w') as f:
                f.write(json.dumps(class_guid_mapping))
        for cls_ in classes:
            # Before writing out, loop over the fields of the class also to
            # determine if any of the array fields need to have updated enum
            # references.
            cls_.update_array_enum_refs()
            cls_.write(class_template)
        if USE_PROJITEMS:
            filepaths.sort()
            if config['general'].getboolean(
                'replace_existing_files',
                fallback=False
            ):
                projitems_path = config['general'].get('output_dir', '.')
            else:
                projitems_path = '.'
            projitems_path = op.join(projitems_path, 'libMBIN-Shared.projitems')
            with open(projitems_path, 'w') as f:
                f.write(template.render(filepaths=filepaths))
        print(f'Took {time.time() - t1}s')
    except Exception as exc:
        raise exc
    finally:
        # Kill the NMS process.
        if config['general'].getboolean('close_NMS_process', fallback=True):
            nms_proc.terminate()
            nms_pid = nms.process_id
            if nms_pid != nms_proc.pid:
                os.kill(nms_pid, SIGTERM)

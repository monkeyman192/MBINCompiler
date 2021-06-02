using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9371B32161E1830C, Size = 0xE0, NameHash = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Name;
        /* 0x80 */ public ulong NameHash;
        /* 0x88 */ public NMSString0x10 Type;
        /* 0x98 */ public TkTransformData Transform;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBC */ public byte[] PaddingBC;
        /* 0xC0 */ public List<TkSceneNodeAttributeData> Attributes;
        /* 0xD0 */ public List<TkSceneNodeData> Children;

        public override object CustomDeserialize( BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo ) {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(NameHash):
                    ulong NEXT_GUID = 0xD5756F96B501B8A2;
                    long returnPos = reader.BaseStream.Position;

                    // Check to see if we are loading a pre-Beyond version:
                    reader.BaseStream.Position = 0x10;
                    ulong GUID = reader.ReadUInt64();
                    var byteName = Encoding.UTF8.GetBytes(this.Name.ToString());
                    var crc32 = new Crc32();
                    // Make sure we return the read position
                    reader.BaseStream.Position = returnPos;
                    if (GUID == NEXT_GUID) {
                         return (UInt64)crc32.Get(byteName);
                    }
                    else {
                        // just deserialize as normal...
                        return null;
                    }
            }
            return null;
        }
    }
}

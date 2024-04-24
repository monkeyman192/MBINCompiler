using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x201D028F2C6CBDB7, NameHash = 0x6E19250A34E2CE86)]
    public class TkAnimNodeData : NMSTemplate
    {
        /* 0x00 */ public int RotIndex;
        /* 0x04 */ public int ScaleIndex;
        /* 0x08 */ public int TransIndex;
        /* 0x0C */ public NMSString0x40 Node;
        /* 0x4C */ public bool CanCompress;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object, ushort>> additionalData, ref int addtDataIndex)
            {
            string fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                // This seems to always be 0xFEFEFEFE...
                // This values doesn't seem to be used in the exe from what I can tell so I think
                // it's safe to always set it as this value.
                case nameof(CanCompress):
                    writer.Write((UInt32) 0xFEFEFEFE);
                    return true;
            }
            return false;
        }
    }
}

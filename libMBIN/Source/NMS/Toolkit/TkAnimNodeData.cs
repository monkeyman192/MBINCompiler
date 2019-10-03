using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x50, GUID = 0x14C032849E45EE8D, NameHash = 0x6E19250A34E2CE86)]
    public class TkAnimNodeData : NMSTemplate
    {
        [NMS(Size = 0x40, Padding = 0xFE)]
        /* 0x00 */ public string Node;
        // AS WEIRD AS THIS LOOKS DO NOT REMOVE THE 1 BYTE OF PADDING!!
        // We need it because I can't be bothered to fix the padding attribute
        // TODO: Fix the padding attribute??
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x3F */ public byte Padding3F;

        /* 0x40 */ public bool CanCompress; // set to 0xFE, with following 3 padding bytes also set to 0xFE, might be padding indicating that this is 0? currently treated as 1...
        /* 0x44 */ public int RotIndex;
        /* 0x48 */ public int TransIndex;
        /* 0x4C */ public int ScaleIndex;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            if (field == null || fieldInfo == null)
                return false;

            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(CanCompress):
                    //writer.Align(4, 0);
                    writer.Write(0xFEFEFEFE);
                    return true;

            }

            return false;
        }
    }
}

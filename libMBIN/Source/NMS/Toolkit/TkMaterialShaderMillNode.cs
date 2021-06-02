using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x80, GUID = 0x4441620CF8379C34, NameHash = 0x465D81033D79E7BB)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        /* 0x00 */ public int Id;
        /* 0x04 */ public NMSString0x20 Type;
        /* 0x24 */ public NMSString0x20 Value;
        /* 0x44 */ public int IValue;
        /* 0x48 */ public int IValue2;
        /* 0x4C */ public float FValue;
        /* 0x50 */ public float FValue2;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x54 */ public byte[] Padding54;
        /* 0x58 */ public List<TkMaterialShaderMillConnect> Inputs;
        /* 0x68 */ public List<TkMaterialShaderMillConnect> Outputs;
        /* 0x78 */ public int WindowX;
        /* 0x7C */ public int WindowY;
    }
}

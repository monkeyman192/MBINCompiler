using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x817C66DB7D882C65, NameHash = 0x465D81033D79E7BB)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        /* 0x00 */ public List<TkMaterialShaderMillConnect> Inputs;
        /* 0x10 */ public List<TkMaterialShaderMillConnect> Outputs;
        /* 0x20 */ public float FValue;
        /* 0x24 */ public float FValue2;
        /* 0x28 */ public int Id;
        /* 0x2C */ public int IValue;
        /* 0x30 */ public int IValue2;
        /* 0x34 */ public int WindowX;
        /* 0x38 */ public int WindowY;
        /* 0x3C */ public NMSString0x80 Value;
        /* 0xBC */ public NMSString0x20 Type;
    }
}

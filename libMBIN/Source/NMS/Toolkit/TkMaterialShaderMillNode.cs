using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF49A5C90A79C71C3, NameHash = 0xDBD75F4C)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<TkMaterialShaderMillConnect> Inputs;
        [NMS(Index = 8)]
        /* 0x10 */ public List<TkMaterialShaderMillConnect> Outputs;
        [NMS(Index = 5)]
        /* 0x20 */ public float FValue;
        [NMS(Index = 6)]
        /* 0x24 */ public float FValue2;
        [NMS(Index = 0)]
        /* 0x28 */ public int Id;
        [NMS(Index = 3)]
        /* 0x2C */ public int IValue;
        [NMS(Index = 4)]
        /* 0x30 */ public int IValue2;
        [NMS(Index = 9)]
        /* 0x34 */ public int WindowX;
        [NMS(Index = 10)]
        /* 0x38 */ public int WindowY;
        [NMS(Index = 2)]
        /* 0x3C */ public NMSString0x80 Value;
        [NMS(Index = 1)]
        /* 0xBC */ public NMSString0x20 Type;
    }
}

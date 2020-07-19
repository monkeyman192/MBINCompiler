using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x80, GUID = 0xB5719C924E6DC6FC, NameHash = 0x8A6FCDF95D18002E)]
    public class TkMaterialSketchNode : NMSTemplate
    {
        /* 0x00 */ public int Id;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string Type;
        [NMS(Size = 0x20)]
        /* 0x24 */ public string Value;
        /* 0x44 */ public int IValue;
        /* 0x48 */ public int IValue2;
        /* 0x4C */ public float FValue;
        /* 0x50 */ public float FValue2;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x54 */ public byte[] Padding54;
        /* 0x58 */ public List<TkMaterialSketchConnect> Inputs;
        /* 0x68 */ public List<TkMaterialSketchConnect> Outputs;
        /* 0x78 */ public int WindowX;
        /* 0x7C */ public int WindowY;
    }
}
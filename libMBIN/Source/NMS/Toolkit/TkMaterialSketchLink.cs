using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x78, GUID = 0xED96E8137A0A3606, NameHash = 0x6AA5956429CD2D5D)]
    public class TkMaterialSketchLink : NMSTemplate
    {
        /* 0x00 */ public int InputNode;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string InputConnect;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] Padding24;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string InputShuffle;
        /* 0x38 */ public int OutputNode;
        [NMS(Size = 0x20)]
        /* 0x3C */ public string OutputConnect;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x5C */ public byte[] Padding5C;
        [NMS(Size = 0x10)]
        /* 0x60 */ public string OutputShuffle;
        /* 0x70 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
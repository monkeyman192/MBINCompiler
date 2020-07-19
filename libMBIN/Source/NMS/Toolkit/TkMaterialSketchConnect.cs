using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0x9761F1A258006A2C, NameHash = 0x3C0B60A90EFF93A9)]
    public class TkMaterialSketchConnect : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Name;
        /* 0x20 */ public int Count;
        /* 0x24 */ public bool Expanded;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] EndPadding;
    }
}
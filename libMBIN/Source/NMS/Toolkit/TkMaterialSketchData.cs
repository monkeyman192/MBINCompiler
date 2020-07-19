using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x48, GUID = 0xFE35421F581B3154, NameHash = 0x6BD985F678734B62)]
    public class TkMaterialSketchData : NMSTemplate
    {
        /* 0x00 */ public List<TkMaterialSketchNode> SketchNodes;
        /* 0x10 */ public List<TkMaterialSketchLink> SketchLinks;
        /* 0x20 */ public List<NMSString0x20> SketchFlags;
        /* 0x30 */ public float ScrollX;
        /* 0x34 */ public float ScrollY;
        /* 0x38 */ public float Zoom;
        /* 0x3C */ public int OutputX;
        /* 0x40 */ public int OutputY;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;
    }
}
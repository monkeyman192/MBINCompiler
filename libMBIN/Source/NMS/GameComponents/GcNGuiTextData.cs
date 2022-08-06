using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD899A6BB402A43D9, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x080 */ public TkNGuiTextStyle Style;
        /* 0x1A0 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3C0 */ public NMSString0x80 Image;
        /* 0x440 */ public NMSString0x200 Text;
        /* 0x640 */ public bool Special;
        /* 0x644 */ public float ForcedOffset;
        /* 0x648 */ public bool ForcedAllowScroll;
        /* 0x650 */ public List<GcVROverride_Text> VROverrides;
        /* 0x660 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
    }
}

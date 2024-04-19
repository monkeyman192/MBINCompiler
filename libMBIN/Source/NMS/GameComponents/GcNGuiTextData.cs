using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x399A33599C8EC1D3, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x1E0 */ public TkNGuiTextStyle Style;
        /* 0x300 */ public GcNGuiElementData ElementData;
        /* 0x370 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        /* 0x380 */ public List<GcVROverride_Text> VROverrides;
        /* 0x390 */ public float ForcedOffset;
        /* 0x394 */ public NMSString0x200 Text;
        /* 0x594 */ public NMSString0x80 Image;
        /* 0x614 */ public bool ForcedAllowScroll;
        /* 0x615 */ public bool Special;
    }
}

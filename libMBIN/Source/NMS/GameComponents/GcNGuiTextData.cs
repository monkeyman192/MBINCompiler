using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x399A33599C8EC1D3, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 1)]
        /* 0x1E0 */ public TkNGuiTextStyle Style;
        [NMS(Index = 0)]
        /* 0x300 */ public GcNGuiElementData ElementData;
        [NMS(Index = 7)]
        /* 0x370 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        [NMS(Index = 6)]
        /* 0x380 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Index = 5)]
        /* 0x390 */ public float ForcedOffset;
        [NMS(Index = 3)]
        /* 0x394 */ public NMSString0x200 Text;
        [NMS(Index = 4)]
        /* 0x594 */ public NMSString0x80 Image;
        [NMS(Index = 9)]
        /* 0x614 */ public bool ForcedAllowScroll;
        [NMS(Index = 8)]
        /* 0x615 */ public bool Special;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5558F8445466BC5E, NameHash = 0xD5C1D227)]
    public class GcNGuiTextData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 1)]
        /* 0x210 */ public TkNGuiTextStyle Style;
        [NMS(Index = 0)]
        /* 0x330 */ public GcNGuiElementData ElementData;
        [NMS(Index = 7)]
        /* 0x398 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        [NMS(Index = 4)]
        /* 0x3A8 */ public VariableSizeString Image;
        [NMS(Index = 6)]
        /* 0x3B8 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Index = 5)]
        /* 0x3C8 */ public float ForcedOffset;
        [NMS(Index = 3)]
        /* 0x3CC */ public NMSString0x200 Text;
        [NMS(Index = 10)]
        /* 0x5CC */ public bool BlockSpecialStyles;
        [NMS(Index = 9)]
        /* 0x5CD */ public bool ForcedAllowScroll;
        [NMS(Index = 8)]
        /* 0x5CE */ public bool Special;
    }
}

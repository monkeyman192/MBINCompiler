using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62EBEC53DF4EFB1B, NameHash = 0xD5C1D227)]
    public class GcNGuiTextData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Index = 7)]
        /* 0x068 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        [NMS(Index = 4)]
        /* 0x078 */ public GcFilename Image;
        [NMS(Index = 3)]
        /* 0x088 */ public VariableSizeString Text;
        [NMS(Index = 6)]
        /* 0x098 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Index = 2, MxmlName = "Graphic Style")]
        /* 0x0A8 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 1)]
        /* 0x228 */ public TkNGuiTextStyle Style;
        [NMS(Index = 5)]
        /* 0x2DC */ public float ForcedOffset;
        [NMS(Index = 10)]
        /* 0x2E0 */ public bool BlockSpecialStyles;
        [NMS(Index = 9)]
        /* 0x2E1 */ public bool ForcedAllowScroll;
        [NMS(Index = 8)]
        /* 0x2E2 */ public bool Special;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x47354CBE1C9299D3, NameHash = 0x903BF7DD)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 2)]
        /* 0x10 */ public Colour OutlineColour;
        [NMS(Index = 1)]
        /* 0x20 */ public Colour ShadowColour;
        [NMS(Index = 5)]
        /* 0x30 */ public float DropShadowAngle;
        [NMS(Index = 6)]
        /* 0x34 */ public float DropShadowOffset;
        [NMS(Index = 3)]
        /* 0x38 */ public float FontHeight;
        [NMS(Index = 8)]
        /* 0x3C */ public int FontIndex;
        [NMS(Index = 4)]
        /* 0x40 */ public float FontSpacing;
        [NMS(Index = 7)]
        /* 0x44 */ public float OutlineSize;
        [NMS(Index = 9)]
        /* 0x48 */ public TkNGuiAlignment Align;
        [NMS(Index = 14)]
        /* 0x4A */ public bool AllowScroll;
        [NMS(Index = 17)]
        /* 0x4B */ public bool AutoAdjustFontHeight;
        [NMS(Index = 16)]
        /* 0x4C */ public bool AutoAdjustHeight;
        [NMS(Index = 18)]
        /* 0x4D */ public bool BlockAudio;
        [NMS(Index = 15)]
        /* 0x4E */ public bool ForceUpperCase;
        [NMS(Index = 11)]
        /* 0x4F */ public bool HasDropShadow;
        [NMS(Index = 12)]
        /* 0x50 */ public bool HasOutline;
        [NMS(Index = 10)]
        /* 0x51 */ public bool IsIndented;
        [NMS(Index = 13)]
        /* 0x52 */ public bool IsParagraph;
    }
}

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float FontHeight;
        /* 0x14 */ public float FontSpacing;
        /* 0x18 */ public bool IsIndented;
        /* 0x19 */ public bool HasDropShadow;
        /* 0x20 */ public Colour DropShadowColour;
        /* 0x30 */ public float DropShadowAngle;
        /* 0x34 */ public float DropShadowOffset;
        /* 0x38 */ public bool HasOutline;

        /* 0x3C */ public float OutlineSize;
        /* 0x40 */ public bool IsParagraph;
        /* 0x41 */ public bool AllowScroll;
        /* 0x42 */ public bool ForceUpperCase;
        /* 0x43 */ public bool AutoAdjustHeight;
        /* 0x44 */ public int FontIndex;
        /* 0x48 */ public TkNGuiAlignment Align;
    }
}

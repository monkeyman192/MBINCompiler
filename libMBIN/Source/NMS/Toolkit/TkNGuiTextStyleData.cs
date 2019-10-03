using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x60, GUID = 0x8B2E43B87941769B, NameHash = 0x91FBF976CBE15B5F)]
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
        /* 0x40 */ public Colour OutlineColour;
        /* 0x50 */ public bool IsParagraph;
        /* 0x51 */ public bool AllowScroll;
        /* 0x52 */ public bool ForceUpperCase;
        /* 0x53 */ public bool AutoAdjustHeight;
        /* 0x54 */ public int FontIndex;
        /* 0x58 */ public TkNGuiAlignment Align;
    }
}

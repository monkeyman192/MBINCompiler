using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x120)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        /* 0x000 */ public List<float> Sizes;

        [NMS(Size = 5)]
        /* 0x010 */ public Colour[] SkinColours;

        /* 0x060 */ public float SkinFontHeight;

        [NMS(Size = 0x80)]
        /* 0x064 */ public string Font;

        /* 0x0E8 */ public List<TkNGuiGraphicStyle> GraphicStyles;
        /* 0x0F8 */ public List<TkNGuiTextStyle> TextStyles;
        /* 0x108 */ public List<float> SnapSettings;

        [NMS(Size = 8, Ignore = true)]
        public byte[] EndPadding;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        public List<float> Sizes;

        [NMS(Size = 5)]
        public Colour[] SkinColours;

        public float SkinFontHeight;

        public NMSString0x80 Font;

        public List<TkNGuiGraphicStyle> GraphicStyles;
        public List<TkNGuiTextStyle> TextStyles;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding108;
    }
}

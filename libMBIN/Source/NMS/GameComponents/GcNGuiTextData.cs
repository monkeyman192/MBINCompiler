using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiTextData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;

        public NMSString0x80 Image;

        public NMSString0x200 Text;

        public bool Special;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;
    }
}

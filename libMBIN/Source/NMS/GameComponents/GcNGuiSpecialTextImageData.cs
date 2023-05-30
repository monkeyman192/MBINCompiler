using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiSpecialTextImageData : NMSTemplate
    {
        public NMSString0x10 Name;
        public bool ScaleToFitFont;
        public Vector2f Size;

        public NMSString0x80 Path;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding9C;
    }
}

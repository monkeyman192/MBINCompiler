using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC0, Alignment = 0x10, GUID = 0x820765B29553ADDD, NameHash = 0xD08C5A93AECF92B1)]
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        public NMSString0x80 Image;

        public Colour Colour;
    }
}
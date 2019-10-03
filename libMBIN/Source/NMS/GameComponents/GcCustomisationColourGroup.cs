using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xAF69A920435DE7D, NameHash = 0x7E7DCFD2B65C6AD6)]
    public class GcCustomisationColourGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupID;
        [NMS(Size = 0x20)]
        public string Title;
        public TkPaletteTexture Palette;
    }
}

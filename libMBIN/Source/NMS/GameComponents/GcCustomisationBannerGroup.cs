using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x830, GUID = 0x777852BAA3CC8EEA, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        public List<TkTextureResource> BannerImages;
        public GcPaletteData MainColours;
        public GcPaletteData BackgroundColours;
    }
}

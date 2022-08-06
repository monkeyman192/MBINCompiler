using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x91F4D6E2D2815BD5, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        /* 0x000 */ public List<GcCustomisationBannerImageData> BannerImages;
        /* 0x010 */ public GcPaletteData MainColours;
        /* 0x420 */ public GcCustomisationColourPaletteExtraData MainColoursExtraData;
        /* 0x440 */ public GcPaletteData BackgroundColours;
        /* 0x850 */ public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData;
    }
}

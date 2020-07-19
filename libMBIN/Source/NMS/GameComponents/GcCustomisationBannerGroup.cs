using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x870, GUID = 0x7B60249ABC6D9D24, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        /* 0x000 */ public List<GcCustomisationBannerImageData> BannerImages;
        /* 0x010 */ public GcPaletteData MainColours;
        /* 0x420 */ public GcCustomisationColourPaletteExtraData MainColoursExtraData;
        /* 0x440 */ public GcPaletteData BackgroundColours;
        /* 0x850 */ public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData;
    }
}

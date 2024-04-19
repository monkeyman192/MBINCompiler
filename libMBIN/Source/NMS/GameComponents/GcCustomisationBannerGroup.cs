using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9D290FD12C9A030, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        /* 0x000 */ public GcPaletteData BackgroundColours;
        /* 0x410 */ public GcPaletteData MainColours;
        /* 0x820 */ public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData;
        /* 0x840 */ public GcCustomisationColourPaletteExtraData MainColoursExtraData;
        /* 0x860 */ public List<GcCustomisationBannerImageData> BannerImages;
    }
}

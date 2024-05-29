using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF23667357309DB8, NameHash = 0x6464F543A870D3F3)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCustomisationMultiTextureOption> MultiTextureOptions;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCustomisationTextureOption> TextureOptions;
    }
}

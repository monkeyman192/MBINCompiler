using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51B9C544EB2862FB, NameHash = 0x577A3609)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCustomisationMultiTextureOption> MultiTextureOptions;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCustomisationTextureOption> TextureOptions;
    }
}

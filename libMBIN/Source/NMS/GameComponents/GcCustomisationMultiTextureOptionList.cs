using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB61AE2C55A6171E7, NameHash = 0x222D3803)]
    public class GcCustomisationMultiTextureOptionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A TextureOptionsID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcCustomisationMultiTextureSubOption> SubOptions;
    }
}

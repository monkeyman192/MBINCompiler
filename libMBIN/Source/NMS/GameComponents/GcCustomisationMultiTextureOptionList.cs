using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42FD8F66562F697C, NameHash = 0xE81D8DEF168B8300)]
    public class GcCustomisationMultiTextureOptionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A TextureOptionsID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcCustomisationMultiTextureSubOption> SubOptions;
    }
}

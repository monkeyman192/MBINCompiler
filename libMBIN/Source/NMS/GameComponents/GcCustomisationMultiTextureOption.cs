using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x458EC31AB7337499, NameHash = 0xBAABFB80446BE596)]
    public class GcCustomisationMultiTextureOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MultiTextureOptionsID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCustomisationMultiTextureOptionList> Options;
        [NMS(Index = 3)]
        /* 0x20 */ public List<NMSString0x10> ProductsToUnlock;
        [NMS(Index = 2)]
        /* 0x30 */ public List<NMSString0x20A> Tips;
    }
}

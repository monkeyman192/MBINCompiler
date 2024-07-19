using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF73F44779523EB18, NameHash = 0x65E1A8EC)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Layer;
        [NMS(Index = 3)]
        /* 0x20 */ public List<NMSString0x20A> Options;
        [NMS(Index = 5)]
        /* 0x30 */ public List<NMSString0x10> ProductsToUnlock;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 TextureOptionsID;
        [NMS(Index = 4)]
        /* 0x50 */ public List<NMSString0x20A> Tips;
    }
}

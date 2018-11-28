using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0x953D6F5550ED77E2)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Secondary;

        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        /* 0x20 */ public NMSString0x10[] BiomeSpecific;
    }
}

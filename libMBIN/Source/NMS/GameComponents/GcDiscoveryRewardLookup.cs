using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A2BF99C187D3979, NameHash = 0xA2280C1D273E7644)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public NMSString0x10[] BiomeSpecific;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x10 Secondary;
    }
}

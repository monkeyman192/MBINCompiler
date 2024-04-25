using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C57930CC9E6FEFB, NameHash = 0x74723646531009E2)]
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A TextureDescriptorHint;
        [NMS(Index = 4)]
        /* 0x20 */ public GcSeed Seed;
        [NMS(Index = 0)]
        /* 0x30 */ public GcRealityCommonFactions Faction;
        [NMS(Index = 3)]
        /* 0x34 */ public GcFrigateClass FrigateClass;
        [NMS(Index = 2)]
        /* 0x38 */ public GcSpaceshipClasses ShipClass;
        [NMS(Index = 1)]
        /* 0x3C */ public GcAISpaceshipRoles ShipRole;
    }
}

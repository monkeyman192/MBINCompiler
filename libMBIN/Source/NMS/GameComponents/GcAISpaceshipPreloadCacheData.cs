using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D48E0DEFC397DAA, NameHash = 0xFAC9753A)]
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

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C57930CC9E6FEFB, NameHash = 0x74723646531009E2)]
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A TextureDescriptorHint;
        /* 0x20 */ public GcSeed Seed;
        /* 0x30 */ public GcRealityCommonFactions Faction;
        /* 0x34 */ public GcFrigateClass FrigateClass;
        /* 0x38 */ public GcSpaceshipClasses ShipClass;
        /* 0x3C */ public GcAISpaceshipRoles ShipRole;
    }
}

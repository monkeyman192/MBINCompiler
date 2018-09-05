namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        /* 0x00 */ public GcRealityCommonFactions Faction;
        /* 0x04 */ public GcAISpaceshipRoles ShipRole;
        /* 0x08 */ public GcSpaceshipClasses ShipClass;
        /* 0x0C */ public GcFrigateClass FrigateClass;
        /* 0x10 */ public GcSeed Seed;
    }
}

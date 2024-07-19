namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE241DE420039D26, NameHash = 0x52BE77F8)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 NeedsMissionActive;
        [NMS(Index = 1)]
        /* 0x10 */ public bool NeedsAbandonedSystem;
        [NMS(Index = 3)]
        /* 0x11 */ public bool NeedsAsteroidField;
        [NMS(Index = 0)]
        /* 0x12 */ public bool NeedsEmptySystem;
        [NMS(Index = 4)]
        /* 0x13 */ public bool NeedsNearbyCorruptWorld;
        [NMS(Index = 2)]
        /* 0x14 */ public bool NeedsPirateSystem;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x755095622B67798F, NameHash = 0xD0217E81661C9C1D)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NeedsMissionActive;
        /* 0x10 */ public bool NeedsAbandonedSystem;
        /* 0x11 */ public bool NeedsAsteroidField;
        /* 0x12 */ public bool NeedsEmptySystem;
        /* 0x13 */ public bool NeedsNearbyCorruptWorld;
        /* 0x14 */ public bool NeedsPirateSystem;
    }
}

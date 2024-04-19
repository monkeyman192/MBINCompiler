namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x974E19FFD599F187, NameHash = 0x662E605B574D59AB)]
    public class GcPulseEncounterSpawnConditions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RequiresMissionActive;
        /* 0x10 */ public NMSString0x10 RequiresMissionComplete;
        /* 0x20 */ public NMSString0x10 RequiresMissionNotActive;
        /* 0x30 */ public NMSString0x10 RequiresMissionNotComplete;
        /* 0x40 */ public NMSString0x10 RequiresProduct;
        /* 0x50 */ public bool AllowedBeyondPortals;
        /* 0x51 */ public bool AllowedDuringTutorial;
        /* 0x52 */ public bool AllowedInCreative;
        /* 0x53 */ public bool AllowedInEmptySystem;
        /* 0x54 */ public bool AllowedWhileOnMPMission;
        /* 0x55 */ public bool MissionEncounter;
        /* 0x56 */ public bool RequiresAlienShip;
        /* 0x57 */ public bool RequiresNearbyCorruptWorld;
        /* 0x58 */ public bool StandardEncounter;
    }
}

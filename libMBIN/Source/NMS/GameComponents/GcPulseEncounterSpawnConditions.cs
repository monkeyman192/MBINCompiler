namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x974E19FFD599F187, NameHash = 0x662E605B574D59AB)]
    public class GcPulseEncounterSpawnConditions : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x10 RequiresMissionActive;
        [NMS(Index = 6)]
        /* 0x10 */ public NMSString0x10 RequiresMissionComplete;
        [NMS(Index = 9)]
        /* 0x20 */ public NMSString0x10 RequiresMissionNotActive;
        [NMS(Index = 8)]
        /* 0x30 */ public NMSString0x10 RequiresMissionNotComplete;
        [NMS(Index = 5)]
        /* 0x40 */ public NMSString0x10 RequiresProduct;
        [NMS(Index = 3)]
        /* 0x50 */ public bool AllowedBeyondPortals;
        [NMS(Index = 2)]
        /* 0x51 */ public bool AllowedDuringTutorial;
        [NMS(Index = 0)]
        /* 0x52 */ public bool AllowedInCreative;
        [NMS(Index = 1)]
        /* 0x53 */ public bool AllowedInEmptySystem;
        [NMS(Index = 4)]
        /* 0x54 */ public bool AllowedWhileOnMPMission;
        [NMS(Index = 13)]
        /* 0x55 */ public bool MissionEncounter;
        [NMS(Index = 10)]
        /* 0x56 */ public bool RequiresAlienShip;
        [NMS(Index = 11)]
        /* 0x57 */ public bool RequiresNearbyCorruptWorld;
        [NMS(Index = 12)]
        /* 0x58 */ public bool StandardEncounter;
    }
}

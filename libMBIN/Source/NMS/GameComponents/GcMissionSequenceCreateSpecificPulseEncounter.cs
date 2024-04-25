namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CE72BD65D6ADF5E, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x10 PulseEncounterID;
        [NMS(Index = 4)]
        /* 0x010 */ public float MinTimeInPulse;
        [NMS(Index = 10)]
        /* 0x014 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x114 */ public NMSString0x80 MessageNoShip;
        [NMS(Index = 2)]
        /* 0x194 */ public NMSString0x80 MessageNotPulsing;
        [NMS(Index = 3)]
        /* 0x214 */ public NMSString0x80 MessageSignalBlocked;
        [NMS(Index = 7)]
        /* 0x294 */ public bool AllowAnyEncounter;
        [NMS(Index = 9)]
        /* 0x295 */ public bool AllowOutsideShip;
        [NMS(Index = 8)]
        /* 0x296 */ public bool Silent;
        [NMS(Index = 6)]
        /* 0x297 */ public bool TakeEncounterIDFromSeasonData;
    }
}

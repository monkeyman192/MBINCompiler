namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CE72BD65D6ADF5E, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PulseEncounterID;
        /* 0x010 */ public float MinTimeInPulse;
        /* 0x014 */ public NMSString0x80 DebugText;
        /* 0x094 */ public NMSString0x80 Message;
        /* 0x114 */ public NMSString0x80 MessageNoShip;
        /* 0x194 */ public NMSString0x80 MessageNotPulsing;
        /* 0x214 */ public NMSString0x80 MessageSignalBlocked;
        /* 0x294 */ public bool AllowAnyEncounter;
        /* 0x295 */ public bool AllowOutsideShip;
        /* 0x296 */ public bool Silent;
        /* 0x297 */ public bool TakeEncounterIDFromSeasonData;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21A9CB3F76C57BA4, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x20A ShipHUDOverrideWhenReady;
        [NMS(Index = 7)]
        /* 0x020 */ public NMSString0x10 PulseEncounterID;
        [NMS(Index = 6)]
        /* 0x030 */ public float MinTimeInPulse;
        [NMS(Index = 12)]
        /* 0x034 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0B4 */ public NMSString0x80 Message;
        [NMS(Index = 4)]
        /* 0x134 */ public NMSString0x80 MessageEncounterReady;
        [NMS(Index = 1)]
        /* 0x1B4 */ public NMSString0x80 MessageNoShip;
        [NMS(Index = 2)]
        /* 0x234 */ public NMSString0x80 MessageNotPulsing;
        [NMS(Index = 3)]
        /* 0x2B4 */ public NMSString0x80 MessageSignalBlocked;
        [NMS(Index = 9)]
        /* 0x334 */ public bool AllowAnyEncounter;
        [NMS(Index = 11)]
        /* 0x335 */ public bool AllowOutsideShip;
        [NMS(Index = 10)]
        /* 0x336 */ public bool Silent;
        [NMS(Index = 8)]
        /* 0x337 */ public bool TakeEncounterIDFromSeasonData;
    }
}

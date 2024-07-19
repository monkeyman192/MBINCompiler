namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED9FE360DD361862, NameHash = 0xA2483F68)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A ShipHUDOverrideWhenReady;
        [NMS(Index = 12)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x40 */ public VariableSizeString MessageEncounterReady;
        [NMS(Index = 1)]
        /* 0x50 */ public VariableSizeString MessageNoShip;
        [NMS(Index = 2)]
        /* 0x60 */ public VariableSizeString MessageNotPulsing;
        [NMS(Index = 3)]
        /* 0x70 */ public VariableSizeString MessageSignalBlocked;
        [NMS(Index = 7)]
        /* 0x80 */ public NMSString0x10 PulseEncounterID;
        [NMS(Index = 6)]
        /* 0x90 */ public float MinTimeInPulse;
        [NMS(Index = 9)]
        /* 0x94 */ public bool AllowAnyEncounter;
        [NMS(Index = 11)]
        /* 0x95 */ public bool AllowOutsideShip;
        [NMS(Index = 10)]
        /* 0x96 */ public bool Silent;
        [NMS(Index = 8)]
        /* 0x97 */ public bool TakeEncounterIDFromSeasonData;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC928B2C44A22F306, NameHash = 0x2853A26D)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A EncounterComponentScanEvent;
        [NMS(Index = 3)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x40 */ public bool AllowedToEscape;
    }
}

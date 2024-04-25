namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFFCBF31D181A7F9, NameHash = 0x7E1936B219E215F)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x20A EncounterComponentScanEvent;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A0 */ public NMSString0x80 Message;
        [NMS(Index = 2)]
        /* 0x120 */ public bool AllowedToEscape;
    }
}

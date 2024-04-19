namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFFCBF31D181A7F9, NameHash = 0x7E1936B219E215F)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A EncounterComponentScanEvent;
        /* 0x020 */ public NMSString0x80 DebugText;
        /* 0x0A0 */ public NMSString0x80 Message;
        /* 0x120 */ public bool AllowedToEscape;
    }
}

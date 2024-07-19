namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48959E8D8B7150F7, NameHash = 0x4494847D)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MissionID;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong RecurrenceDeadline;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x307EBB867BCAD652, NameHash = 0xE91A0D6A)]
    public class GcMissionSequenceWaitForFriendlyDroneScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 5)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString MessageCantSummon;
        [NMS(Index = 3)]
        /* 0x40 */ public VariableSizeString MessageNotAvailable;
        [NMS(Index = 0)]
        /* 0x50 */ public VariableSizeString MessageSummoned;
        [NMS(Index = 1)]
        /* 0x60 */ public VariableSizeString MessageUnsummoned;
    }
}

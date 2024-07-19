namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51C7FD890FFA7E9A, NameHash = 0x32BF48D3)]
    public class GcMissionSequenceWaitForStat : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 StatGroup;
        [NMS(Index = 3)]
        /* 0x40 */ public int Amount;
    }
}

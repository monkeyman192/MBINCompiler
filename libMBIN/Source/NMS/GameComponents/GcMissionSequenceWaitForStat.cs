namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0C3876D5B99F9AB, NameHash = 0x197E91849165F7F4)]
    public class GcMissionSequenceWaitForStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 StatGroup;
        [NMS(Index = 3)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x24 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0xA4 */ public NMSString0x80 Message;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C71CA38B1066F1B, NameHash = 0xCDB2E795)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 DisplayStat;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString MessageCombat;
        [NMS(Index = 2)]
        /* 0x40 */ public ulong Time;
        [NMS(Index = 3)]
        /* 0x48 */ public float Randomness;
        [NMS(Index = 5)]
        /* 0x4C */ public bool StatFromNow;
    }
}

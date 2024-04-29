namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A25B3515DFC74A, NameHash = 0xB497A82E7D25F7C4)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x10 DisplayStat;
        [NMS(Index = 2)]
        /* 0x010 */ public ulong Time;
        [NMS(Index = 3)]
        /* 0x018 */ public float Randomness;
        [NMS(Index = 6)]
        /* 0x01C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x09C */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x11C */ public NMSString0x80 MessageCombat;
        [NMS(Index = 5)]
        /* 0x19C */ public bool StatFromNow;
    }
}

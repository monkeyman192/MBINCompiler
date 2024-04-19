namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x295C0C71FB3CCFD1, NameHash = 0xB497A82E7D25F7C4)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DisplayStat;
        /* 0x010 */ public ulong Time;
        /* 0x018 */ public float Randomness;
        /* 0x01C */ public NMSString0x80 DebugText;
        /* 0x09C */ public NMSString0x80 Message;
        /* 0x11C */ public NMSString0x80 MessageCombat;
        /* 0x19C */ public bool StatFromNow;
    }
}

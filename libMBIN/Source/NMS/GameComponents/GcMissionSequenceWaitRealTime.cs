namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF72C2E794801BBF0, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DisplayStat;
        /* 0x010 */ public ulong Time;
        /* 0x018 */ public float Randomness;
        /* 0x01C */ public NMSString0x80 DebugText;
        /* 0x09C */ public NMSString0x80 Message;
        /* 0x11C */ public bool StatFromNow;
    }
}

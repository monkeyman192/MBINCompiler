namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF72C2E794801BBF0, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x10 DisplayStat;
        [NMS(Index = 1)]
        /* 0x010 */ public ulong Time;
        [NMS(Index = 2)]
        /* 0x018 */ public float Randomness;
        [NMS(Index = 5)]
        /* 0x01C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x09C */ public NMSString0x80 Message;
        [NMS(Index = 4)]
        /* 0x11C */ public bool StatFromNow;
    }
}

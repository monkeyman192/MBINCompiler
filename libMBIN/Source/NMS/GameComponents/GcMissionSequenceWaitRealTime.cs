using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x79130D4322C4512F, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public ulong Time;
        /* 0x088 */ public float Randomness;
        /* 0x090 */ public NMSString0x10 DisplayStat;
        /* 0x0A0 */ public bool StatFromNow;
        /* 0x0A1 */ public NMSString0x80 DebugText;
    }
}

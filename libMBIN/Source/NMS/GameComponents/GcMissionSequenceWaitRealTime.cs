using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x128, GUID = 0x79130D4322C4512F, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public ulong Time;
        /* 0x088 */ public float Randomness;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        /* 0x090 */ public NMSString0x10 DisplayStat;
        /* 0x0A0 */ public bool StatFromNow;
        /* 0x0A1 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x121 */ public byte[] EndPadding;
    }
}

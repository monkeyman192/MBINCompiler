using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x370, GUID = 0xD2740B9C47F05A27, NameHash = 0x1611798444BC0C13)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int Progress;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public ulong Seed;
        /* 0x20 */ public ulong Data;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x28 */ public byte[] Padding28;
        [NMS(Size = 0xD)]
        /* 0x30 */ public GcPlayerMissionParticipant[] Participants;

    }
}

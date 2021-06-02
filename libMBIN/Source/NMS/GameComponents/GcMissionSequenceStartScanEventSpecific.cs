using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x100, Alignment = 0x10, GUID = 0xCDB543AB27830175, NameHash = 0x83CCE421927A9559)]
    public class GcMissionSequenceStartScanEventSpecific : NMSTemplate
    {
        /* 0x00 */ public bool IMeantThisAndKnowWhatItDoes;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        /* 0x10 */ public GcPlayerMissionParticipant Participant;
        /* 0x50 */ public NMSString0x20 Event;
        /* 0x70 */ public float Time;
        /* 0x74 */ public bool AllowOtherPlayersBase;
        /* 0x75 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x9, Ignore = true)]
        /* 0xF6 */ public byte[] EndPadding;
    }
}

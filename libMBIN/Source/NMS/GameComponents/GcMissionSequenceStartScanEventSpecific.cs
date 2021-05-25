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
        [NMS(Size = 0x20)]
        /* 0x50 */ public string Event;
        /* 0x70 */ public float Time;
        /* 0x74 */ public bool AllowOtherPlayersBase;
        [NMS(Size = 0x80)]
        /* 0x75 */ public string DebugText;
        [NMS(Size = 0x9, Ignore = true)]
        /* 0xF6 */ public byte[] EndPadding;
    }
}

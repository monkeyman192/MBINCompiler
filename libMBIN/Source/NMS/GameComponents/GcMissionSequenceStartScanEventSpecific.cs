using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC243D869B4748920, NameHash = 0x83CCE421927A9559)]
    public class GcMissionSequenceStartScanEventSpecific : NMSTemplate
    {
        /* 0x00 */ public GcPlayerMissionParticipant Participant;
        /* 0x30 */ public NMSString0x20A Event;
        /* 0x50 */ public float Time;
        /* 0x54 */ public NMSString0x80 DebugText;
        /* 0xD4 */ public bool AllowOtherPlayersBase;
        /* 0xD5 */ public bool IMeantThisAndKnowWhatItDoes;
    }
}

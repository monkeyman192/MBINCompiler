using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28355F2A25ECF8FC, NameHash = 0x83CCE421927A9559)]
    public class GcMissionSequenceStartScanEventSpecific : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerMissionParticipant Participant;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x50 */ public float Time;
        [NMS(Index = 5)]
        /* 0x54 */ public NMSString0x80 DebugText;
        [NMS(Index = 4)]
        /* 0xD4 */ public bool AllowOtherPlayersBase;
        [NMS(Index = 0)]
        /* 0xD5 */ public bool IMeantThisAndKnowWhatItDoes;
    }
}

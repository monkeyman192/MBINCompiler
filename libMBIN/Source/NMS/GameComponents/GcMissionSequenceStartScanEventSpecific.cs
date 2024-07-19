using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BE6D3FB228BA447, NameHash = 0x30E9CAE2)]
    public class GcMissionSequenceStartScanEventSpecific : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerMissionParticipant Participant;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x20A Event;
        [NMS(Index = 5)]
        /* 0x50 */ public VariableSizeString DebugText;
        [NMS(Index = 3)]
        /* 0x60 */ public float Time;
        [NMS(Index = 4)]
        /* 0x64 */ public bool AllowOtherPlayersBase;
        [NMS(Index = 0)]
        /* 0x65 */ public bool IMeantThisAndKnowWhatItDoes;
    }
}

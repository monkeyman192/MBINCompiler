using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE06E2A5360635DDC, NameHash = 0xDD01DB4B)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x14 */ public bool UseFrontendAudioObject;
    }
}

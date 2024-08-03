using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B3974B603A73D67, NameHash = 0xDD01DB4B)]
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

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A25792F1553DFDF, NameHash = 0xC261496D)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}

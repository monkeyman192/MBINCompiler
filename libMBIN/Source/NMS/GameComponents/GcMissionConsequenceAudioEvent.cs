using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6C27546989AF0E2, NameHash = 0xC261496D)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x263C920CBA6EAA2A, NameHash = 0xDFAC7EA3D5A0F64C)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33E15FCB78EB2C6D, NameHash = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x84 */ public bool UseFrontendAudioObject;
    }
}

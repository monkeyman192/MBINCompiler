using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33E15FCB78EB2C6D, NameHash = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        /* 0x00 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x04 */ public NMSString0x80 DebugText;
        /* 0x84 */ public bool UseFrontendAudioObject;
    }
}

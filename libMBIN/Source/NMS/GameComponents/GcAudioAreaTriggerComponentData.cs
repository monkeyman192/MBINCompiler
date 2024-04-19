using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA9317C35082588, NameHash = 0xD1618D63DA15668C)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        /* 0x0 */ public float EnterDistance;
        /* 0x4 */ public GcAudioWwiseEvents EventEnter;
        /* 0x8 */ public GcAudioWwiseEvents EventExit;
        /* 0xC */ public float ExitDistance;
    }
}

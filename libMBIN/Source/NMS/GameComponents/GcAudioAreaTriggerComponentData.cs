using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3F75D888100CF9A, NameHash = 0xC0413ECB)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Enter Distance")]
        /* 0x0 */ public float EnterDistance;
        [NMS(Index = 0, MxmlName = "Event Enter")]
        /* 0x4 */ public GcAudioWwiseEvents EventEnter;
        [NMS(Index = 1, MxmlName = "Event Exit")]
        /* 0x8 */ public GcAudioWwiseEvents EventExit;
        [NMS(Index = 3, MxmlName = "Exit Distance")]
        /* 0xC */ public float ExitDistance;
    }
}

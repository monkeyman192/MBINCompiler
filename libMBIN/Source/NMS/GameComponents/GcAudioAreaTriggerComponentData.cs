using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41B5FDD3F9EDD88C, NameHash = 0xD1618D63DA15668C)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float EnterDistance;
        [NMS(Index = 0)]
        /* 0x4 */ public GcAudioWwiseEvents EventEnter;
        [NMS(Index = 1)]
        /* 0x8 */ public GcAudioWwiseEvents EventExit;
        [NMS(Index = 3)]
        /* 0xC */ public float ExitDistance;
    }
}

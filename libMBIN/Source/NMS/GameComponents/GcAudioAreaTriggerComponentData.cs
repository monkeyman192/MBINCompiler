using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x4499A2584EA12EF0, NameHash = 0xD1618D63DA15668C)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        public GcAudioWwiseEvents EventEnter;
        public GcAudioWwiseEvents EventExit;
        public float EnterDistance;
        public float ExitDistance;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        public GcAudioWwiseEvents AkEvent1; // EnterAreaEvent perhaps?
        public GcAudioWwiseEvents AkEvent2; // ExitAreaEvent ?
        public float EnterDistance;
        public float ExitDistance;
    }
}

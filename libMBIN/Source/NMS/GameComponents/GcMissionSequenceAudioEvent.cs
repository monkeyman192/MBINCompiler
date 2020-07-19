using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xCEA41722476BC8D1, NameHash = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

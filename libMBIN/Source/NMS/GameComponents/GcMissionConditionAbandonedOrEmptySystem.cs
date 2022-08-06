using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x34E46A2140A63B57, NameHash = 0x651218B208D538A0)]
    public class GcMissionConditionAbandonedOrEmptySystem : NMSTemplate
    {
		public enum MissionSystemTypeEnum { Either, Empty, Abandoned }
		public MissionSystemTypeEnum MissionSystemType;
    }
}
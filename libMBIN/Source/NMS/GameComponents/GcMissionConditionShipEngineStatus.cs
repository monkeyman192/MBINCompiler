using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x347120D2E460CD9D, NameHash = 0x9A43A9B870251F8C)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        public enum EngineStatusEnum { Thrusting, Braking, Landing, Landed, Boosted, Pulsing, LowFlight, Inverted }
        public EngineStatusEnum EngineStatus;
    }
}
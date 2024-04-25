namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x874558482EBF8780, NameHash = 0x9A43A9B870251F8C)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        // size: 0xA
        public enum EngineStatusEnum : uint {
            Thrusting,
            Braking,
            Landing,
            Landed,
            Boosting,
            Pulsing,
            LowFlight,
            Inverted,
            EnginesRepaired,
            PulsingToPlanet,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EngineStatusEnum EngineStatus;
    }
}

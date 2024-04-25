namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x694723CFD80EC95E, NameHash = 0x5D8EF27FCF8A3E08)]
    public class GcMissionConditionNearPole : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Distance;
        // size: 0x2
        public enum PoleConditionEnum : uint {
            North,
            South,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public PoleConditionEnum PoleCondition;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF2E5EED60859D71, NameHash = 0x5D8EF27FCF8A3E08)]
    public class GcMissionConditionNearPole : NMSTemplate
    {
        public enum PoleConditionEnum { North, South }
        /* 0x0 */ public PoleConditionEnum PoleCondition;
        /* 0x4 */ public float Distance;
    }
}

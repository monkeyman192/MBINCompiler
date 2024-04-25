using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77E2096FF7044EE6, NameHash = 0xE9A41D09A14F59E1)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcMissionConditionIsScanEventLocal Local;
        [NMS(Index = 1)]
        /* 0x28 */ public float MaxDistance;
    }
}

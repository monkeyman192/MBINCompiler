using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8544E9094821E70, NameHash = 0xC99016EC)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcMissionConditionIsScanEventLocal Local;
        [NMS(Index = 1)]
        /* 0x28 */ public float MaxDistance;
    }
}

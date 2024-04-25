using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2303CC6A441EFB94, NameHash = 0xBEE9A9FF61C9FEFB)]
    public class GcMissionConditionHazard : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerHazardType Hazard;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AAD9588558B5CA5, NameHash = 0xA2A54269)]
    public class GcMissionConditionHazard : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerHazardType Hazard;
    }
}

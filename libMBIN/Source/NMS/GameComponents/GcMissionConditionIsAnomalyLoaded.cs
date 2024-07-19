using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4EFC4DF9538C922, NameHash = 0xD6FAC380)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
    }
}

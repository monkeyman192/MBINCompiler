using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA801677D0C40D227, NameHash = 0x80CC00D593175919)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
    }
}

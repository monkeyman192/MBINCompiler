using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB2A31FF3FD2A18F8, NameHash = 0x80CC00D593175919)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        public GcGalaxyStarAnomaly Anomaly;
    }
}
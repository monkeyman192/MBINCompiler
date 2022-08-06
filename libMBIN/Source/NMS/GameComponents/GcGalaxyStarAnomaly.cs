using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD930090CE3C00E66, NameHash = 0x6488969F6CD933A4)]
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
		public enum GalaxyStarAnomalyEnum { None, AtlasStation, AtlasStationFinal, BlackHole, MiniStation }
		public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
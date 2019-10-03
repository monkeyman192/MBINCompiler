using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x281D38B223BF41D8, NameHash = 0x43EB5D40DE6AD28E)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        public enum BuildingDensityEnum { Dead, Low, Mid, Full, Weird }
        public BuildingDensityEnum BuildingDensity;
    }
}

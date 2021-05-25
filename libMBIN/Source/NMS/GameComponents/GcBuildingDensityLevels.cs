using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1E1ED3DE8C32D74B, NameHash = 0x43EB5D40DE6AD28E)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        // size: 0x6
        public enum BuildingDensityEnum { Dead, Low, Mid, Full, Weird, HalfWeird }
        public BuildingDensityEnum BuildingDensity;
    }
}
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        public int ScanBuildingIconTypes
        public string[] ScanBuildingIconTypesValues()
        {
            return new[] { "None", "Generic", "Shelter", "Relic", "Factory", "Unknown", "Distress", "Beacon", "Waypoint", "SpaceStation", "TechResource", "FuelResource", "MineralResource", "SpaceAnomaly", "SapceAtlas" };
        }
    }
}

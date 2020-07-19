using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x8B4973CDD2A76BAD, NameHash = 0x894C8A7A0498F6C5)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        // 0x13 entries
		public enum ScanBuildingIconTypesEnum {
            None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation,
            TechResource, FuelResource, MineralResource, SpaceAnomaly, SpaceAtlas, ExternalBase, PlanetBaseTerminal, Nexus, AbandonedFreighter
        }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}
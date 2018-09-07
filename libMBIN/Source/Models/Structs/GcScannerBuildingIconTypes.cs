namespace libMBIN.Models.Structs
{
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
		public enum ScanBuildingIconTypesEnum { None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation, TechResource, FuelResource, MineralResource, SpaceAnomaly, SapceAtlas }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}

namespace libMBIN.Models.Structs
{
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
		public enum GalaxyMarkerTypeEnum { StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase, Visited, ScanEvent }
		public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

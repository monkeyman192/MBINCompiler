using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCA32B5B116BAFDB8, NameHash = 0x29324EF951272232)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // 0xE entries
		public enum GalaxyMarkerTypeEnum { StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase, Visited, ScanEvent, Expedition, NetworkPlayer, Freighter, PathIcon }
		public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

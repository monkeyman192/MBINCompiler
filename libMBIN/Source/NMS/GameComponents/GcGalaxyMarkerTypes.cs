using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F750C63D43A9193, NameHash = 0x29324EF951272232)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // size: 0x10
        public enum GalaxyMarkerTypeEnum {
            StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase, Visited, ScanEvent,
            Expedition, NetworkPlayer, Freighter, PathIcon, SeasonParty, Settlement
        }
        public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x0, NameHash = 0x29324EF951272232)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // 0xF entries
        public enum GalaxyMarkerTypeEnum { StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase,
            Visited, ScanEvent, Expedition, NetworkPlayer, Freighter, PathIcon , SeasonParty
        }
        public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

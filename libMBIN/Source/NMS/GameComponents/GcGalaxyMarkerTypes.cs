namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7728CCC1B0DDA869, NameHash = 0x2AFFF85F)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // size: 0x11
        public enum GalaxyMarkerTypeEnum : uint {
            StartingLocation,
            Home,
            Waypoint,
            Contact,
            Blackhole,
            AtlasStation,
            Selection,
            PlanetBase,
            Visited,
            ScanEvent,
            Expedition,
            NetworkPlayer,
            Freighter,
            PathIcon,
            SeasonParty,
            Settlement,
            AllianceHome,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

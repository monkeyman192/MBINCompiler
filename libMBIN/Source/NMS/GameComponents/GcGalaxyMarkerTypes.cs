namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B7270127FD40BB2, NameHash = 0x29324EF951272232)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // size: 0x10
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}

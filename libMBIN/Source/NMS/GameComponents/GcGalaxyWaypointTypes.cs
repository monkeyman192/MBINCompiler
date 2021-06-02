using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x895A0820CE617DE4, NameHash = 0xF808614547AF2B25)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        // size: 0x6
        public enum GalaxyWaypointTypeEnum { User, Gameplay_AtlasStation, Gameplay_DistressBeacon, Gameplay_BlackHole, Gameplay_Mission, Gameplay_SeasonParty }
        public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
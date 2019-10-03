using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2C8AEA1CC63421F2, NameHash = 0xF808614547AF2B25)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
		public enum GalaxyWaypointTypeEnum { User, Gameplay_AtlasStation, Gameplay_DistressBeacon, Gameplay_BlackHole, Gameplay_Mission }
		public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}

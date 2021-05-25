using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x2C8AEA1CC63421F2, NameHash = 0xF808614547AF2B25)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        // size: 0x5
		public enum GalaxyWaypointTypeEnum { User, Gameplay_AtlasStation, Gameplay_DistressBeacon, Gameplay_BlackHole, Gameplay_Mission }
		public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x715E0A4778ED054B, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
		public enum MissionObjectEnum { PlayerShip, PlayerVehicle }
		public MissionObjectEnum MissionObject;
        public float Distance;
    }
}

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
		public enum MissionObjectEnum { PlayerShip, PlayerVehicle }
		public MissionObjectEnum MissionObject;
        public float Distance;
    }
}

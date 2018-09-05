namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        public int MissionObject;
        public string[] MissionObjectValues()
        {
            return new[] { "PlayerShip", "PlayerVehicle"};
        }
        public float Distance;
    }
}

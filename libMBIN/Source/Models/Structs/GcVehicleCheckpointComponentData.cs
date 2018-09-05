namespace libMBIN.Models.Structs
{
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        public int CheckpointType;
        public string[] CheckpointTypeValues()
        {
            return new[] { "Checkpoint", "Start", "Finish"};
        }
        public int RaceType;
        public string[] RaceTypeValues()
        {
            return new[] { "Vehicle", "Spaceship" };
        }
        public float Radius;
    }
}

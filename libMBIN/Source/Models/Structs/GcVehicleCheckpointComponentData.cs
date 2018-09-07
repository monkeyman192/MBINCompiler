namespace libMBIN.Models.Structs
{
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
		public enum CheckpointTypeEnum { Checkpoint, Start, Finish }
		public CheckpointTypeEnum CheckpointType;
		public enum RaceTypeEnum { Vehicle, Spaceship }
		public RaceTypeEnum RaceType;
        public float Radius;
    }
}

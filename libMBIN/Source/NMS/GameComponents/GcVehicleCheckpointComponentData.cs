using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x28BD4D157D6849F4, NameHash = 0xF8F75E88F695BE94)]
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
		public enum CheckpointTypeEnum { Checkpoint, Start, Finish }
		public CheckpointTypeEnum CheckpointType;
		public enum RaceTypeEnum { Vehicle, Spaceship }
		public RaceTypeEnum RaceType;
        public float Radius;
    }
}
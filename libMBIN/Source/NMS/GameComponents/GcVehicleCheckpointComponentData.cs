namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x998ECAC2D8278FE3, NameHash = 0xC1275665)]
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        // size: 0x2
        public enum CheckpointTypeEnum : uint {
            Checkpoint,
            Start,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CheckpointTypeEnum CheckpointType;
        // size: 0x2
        public enum RaceTypeEnum : uint {
            Vehicle,
            Spaceship,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public RaceTypeEnum RaceType;
        [NMS(Index = 2)]
        /* 0x8 */ public float Radius;
    }
}

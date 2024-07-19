namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x23F660CE1EB9E712, NameHash = 0xA9144FC5)]
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
        // size: 0xA
        public enum NoiseVoxelTypeEnum : uint {
            Base,
            Rock,
            Mountain,
            Sand,
            Cave,
            Substance_1,
            Substance_2,
            Substance_3,
            RandomRock,
            RandomRockOrSubstance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}

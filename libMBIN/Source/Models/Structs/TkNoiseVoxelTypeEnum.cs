namespace libMBIN.Models.Structs
{
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
		public enum NoiseVoxelTypeEnum { Base, Rock, Mountain, Sand, Cave, Substance_1, Substance_2, Substance_3, RandomRock, RandomRockOrSubstance }
		public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}

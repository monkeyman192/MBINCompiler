using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x68CC5C66BE9C1E10, NameHash = 0xA54BFECBD79D65EE)]
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
		public enum NoiseVoxelTypeEnum { Base, Rock, Mountain, Sand, Cave, Substance_1, Substance_2, Substance_3, RandomRock, RandomRockOrSubstance }
		public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}
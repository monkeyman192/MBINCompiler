using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x44, GUID = 0x306044BC2B6D1590, NameHash = 0xBC975A8E0D580FFA)]
    public class TkNoiseFeatureData : NMSTemplate
    {
        public bool Active;
        public int MaximumLOD;
        public bool Subtract;
        public bool Trench;
        public TkNoiseVoxelTypeEnum NoiseVoxelType;
		public enum FeatureTypeEnum { Tube, Blob }
		public FeatureTypeEnum FeatureType;
        public float Width;
        public float Height;
        public int Octaves;
        public float RegionSize;
        public float Ratio;
        public float HeightVarianceAmplitude;
        public float HeightVarianceFrequency;
        public float HeightOffset;
        public TkNoiseOffsetEnum OffsetType;
        public float SmoothRadius;
        public int SeedOffset;
        public float TileBlendMeters;
    }
}

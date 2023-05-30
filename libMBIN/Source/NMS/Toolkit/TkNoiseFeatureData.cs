using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseFeatureData : NMSTemplate // Size: 0x38
    {
        /* 0x00 */ public bool Active;
        /* 0x01 */ public bool Subtract;
        /* 0x02 */ public bool Trench;
        /* 0x04 */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x08 */ public int FeatureType;
        public string[] FeatureTypeValues()
        {
            return new[] { "Tube", "Blob" };
        }
        /* 0x0C */ public float Width;
        /* 0x10 */ public float Height;
        /* 0x14 */ public int Octaves;
        /* 0x18 */ public float RegionSize;
        /* 0x1C */ public float Ratio;
        /* 0x20 */ public float HeightVarianceAmplitude;
        /* 0x24 */ public float HeightVarianceFrequency;
        /* 0x28 */ public float HeightOffset;
        /* 0x2C */ public TkNoiseOffsetEnum OffsetType;
        /* 0x30 */ public float SmoothRadius;
        /* 0x34 */ public int SeedOffset;
    }
}

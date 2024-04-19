using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x11FD8C247496B7E8, NameHash = 0xBC975A8E0D580FFA)]
    public class TkNoiseFeatureData : NMSTemplate
    {
        // size: 0x2
        public enum FeatureTypeEnum : uint {
            Tube,
            Blob,
        }
        /* 0x00 */ public FeatureTypeEnum FeatureType;
        /* 0x04 */ public float Height;
        /* 0x08 */ public float HeightOffset;
        /* 0x0C */ public float HeightVarianceAmplitude;
        /* 0x10 */ public float HeightVarianceFrequency;
        /* 0x14 */ public int MaximumLOD;
        /* 0x18 */ public int Octaves;
        /* 0x1C */ public TkNoiseOffsetEnum Offset;
        /* 0x20 */ public float Ratio;
        /* 0x24 */ public float RegionSize;
        /* 0x28 */ public int SeedOffset;
        /* 0x2C */ public float SmoothRadius;
        /* 0x30 */ public float TileBlendMeters;
        /* 0x34 */ public TkNoiseVoxelTypeEnum VoxelType;
        /* 0x38 */ public float Width;
        /* 0x3C */ public bool Active;
        /* 0x3D */ public bool Subtract;
        /* 0x3E */ public bool Trench;
    }
}

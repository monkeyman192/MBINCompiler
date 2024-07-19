using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3A7DD6911C6F4F01, NameHash = 0x7FB7545E)]
    public class TkNoiseFeatureData : NMSTemplate
    {
        // size: 0x2
        public enum FeatureTypeEnum : uint {
            Tube,
            Blob,
        }
        [NMS(Index = 5)]
        /* 0x00 */ public FeatureTypeEnum FeatureType;
        [NMS(Index = 7)]
        /* 0x04 */ public float Height;
        [NMS(Index = 13)]
        /* 0x08 */ public float HeightOffset;
        [NMS(Index = 11)]
        /* 0x0C */ public float HeightVarianceAmplitude;
        [NMS(Index = 12)]
        /* 0x10 */ public float HeightVarianceFrequency;
        [NMS(Index = 1)]
        /* 0x14 */ public int MaximumLOD;
        [NMS(Index = 8)]
        /* 0x18 */ public int Octaves;
        [NMS(Index = 14)]
        /* 0x1C */ public TkNoiseOffsetEnum Offset;
        [NMS(Index = 10)]
        /* 0x20 */ public float Ratio;
        [NMS(Index = 9)]
        /* 0x24 */ public float RegionSize;
        [NMS(Index = 16)]
        /* 0x28 */ public int SeedOffset;
        [NMS(Index = 15)]
        /* 0x2C */ public float SmoothRadius;
        [NMS(Index = 17)]
        /* 0x30 */ public float TileBlendMeters;
        [NMS(Index = 4)]
        /* 0x34 */ public TkNoiseVoxelTypeEnum VoxelType;
        [NMS(Index = 6)]
        /* 0x38 */ public float Width;
        [NMS(Index = 0)]
        /* 0x3C */ public bool Active;
        [NMS(Index = 2)]
        /* 0x3D */ public bool Subtract;
        [NMS(Index = 3)]
        /* 0x3E */ public bool Trench;
    }
}

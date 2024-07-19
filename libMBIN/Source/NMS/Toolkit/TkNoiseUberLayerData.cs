using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAEA5883235759F8A, NameHash = 0xF21E151C)]
    public class TkNoiseUberLayerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkNoiseUberData NoiseData;
        [NMS(Index = 5)]
        /* 0x40 */ public float Height;
        [NMS(Index = 11)]
        /* 0x44 */ public float HeightOffset;
        [NMS(Index = 2)]
        /* 0x48 */ public int MaximumLOD;
        [NMS(Index = 12)]
        /* 0x4C */ public TkNoiseOffsetEnum Offset;
        [NMS(Index = 16)]
        /* 0x50 */ public float PlateauRegionSize;
        [NMS(Index = 15)]
        /* 0x54 */ public int PlateauSharpness;
        [NMS(Index = 14)]
        /* 0x58 */ public float PlateauStratas;
        [NMS(Index = 9)]
        /* 0x5C */ public float RegionGain;
        [NMS(Index = 7)]
        /* 0x60 */ public float RegionRatio;
        [NMS(Index = 8)]
        /* 0x64 */ public float RegionScale;
        [NMS(Index = 17)]
        /* 0x68 */ public int SeedOffset;
        [NMS(Index = 10)]
        /* 0x6C */ public float SmoothRadius;
        [NMS(Index = 18)]
        /* 0x70 */ public float TileBlendMeters;
        [NMS(Index = 4)]
        /* 0x74 */ public TkNoiseVoxelTypeEnum VoxelType;
        // size: 0x3
        public enum WaterFadeEnum : uint {
            None,
            Above,
            Below,
        }
        [NMS(Index = 13)]
        /* 0x78 */ public WaterFadeEnum WaterFade;
        [NMS(Index = 6)]
        /* 0x7C */ public float Width;
        [NMS(Index = 1)]
        /* 0x80 */ public bool Active;
        [NMS(Index = 3)]
        /* 0x81 */ public bool Subtract;
    }
}

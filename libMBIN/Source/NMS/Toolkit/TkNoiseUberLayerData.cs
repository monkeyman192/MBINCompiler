using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3F104057D08F304F, NameHash = 0x174C8C3DB33CE268)]
    public class TkNoiseUberLayerData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseUberData NoiseData;
        /* 0x40 */ public float Height;
        /* 0x44 */ public float HeightOffset;
        /* 0x48 */ public int MaximumLOD;
        /* 0x4C */ public TkNoiseOffsetEnum Offset;
        /* 0x50 */ public float PlateauRegionSize;
        /* 0x54 */ public int PlateauSharpness;
        /* 0x58 */ public float PlateauStratas;
        /* 0x5C */ public float RegionGain;
        /* 0x60 */ public float RegionRatio;
        /* 0x64 */ public float RegionScale;
        /* 0x68 */ public int SeedOffset;
        /* 0x6C */ public float SmoothRadius;
        /* 0x70 */ public float TileBlendMeters;
        /* 0x74 */ public TkNoiseVoxelTypeEnum VoxelType;
        // size: 0x3
        public enum WaterFadeEnum : uint {
            None,
            Above,
            Below,
        }
        /* 0x78 */ public WaterFadeEnum WaterFade;
        /* 0x7C */ public float Width;
        /* 0x80 */ public bool Active;
        /* 0x81 */ public bool Subtract;
    }
}

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x88)]
    public class TkNoiseUberLayerData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseUberData NoiseData;
        /* 0x40 */ public bool Active;
        /* 0x44 */ public int MaximumLOD;
        /* 0x48 */ public bool Subtract;
        /* 0x4C */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x50 */ public float Height;
        /* 0x54 */ public float Width;
        /* 0x58 */ public float RegionRatio;
        /* 0x5C */ public float RegionScale;
        /* 0x60 */ public float RegionGain;
        /* 0x64 */ public float SmoothRadius;
        /* 0x68 */ public float HeightOffset;
        /* 0x6C */ public TkNoiseOffsetEnum OffsetType;
        /* 0x70 */ public int WaterFade;
        public string[] WaterFadeValues()
        {
            return new[] { "None", "Above", "Below" };
        }
        /* 0x74 */ public float PlateauStratas;
        /* 0x78 */ public int PlateauSharpness;
        /* 0x7C */ public float PlateauRegionSize;
        /* 0x80 */ public int SeedOffset;
        /* 0x84 */ public float TileBlendMeters;
    }
}

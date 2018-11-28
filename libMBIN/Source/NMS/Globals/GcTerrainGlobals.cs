using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD5017D9BF917053E)]
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0x0000 */ public float RegisterTerrainMinDistance;
        /* 0x0004 */ public float TerrainBeamUndoRangeFromLastAdd;
        /* 0x0008 */ public float TerrainBeamHologramTimeout;
        /* 0x000C */ public float MouseWheelRotatePlaneSensitivity;
        /* 0x0010 */ public float SubtractEditOffset;
        /* 0x0014 */ public float SubtractEditLength;
        /* 0x0018 */ public float SubtractEditFrequency;
        /* 0x001C */ public float TerrainBeamDefaultRadius;
        /* 0x0020 */ public float TerrainBeamLightIntensity;
        [NMS(Size = 0x0C, Ignore = true)]
        /* 0x0024 */ public byte[] Padding24;
        /* 0x0030 */ public Colour TerrainBeamLightColour;
        /* 0x0040 */ public float UseMax;
        /* 0x0044 */ public float TextureFadeDistance;
        /* 0x0048 */ public float TextureFadePower;
        /* 0x004C */ public float TextureScaleMultiplier;
        /* 0x0050 */ public float TextureScalePower;
        [NMS(Size = 0x08)]
        /* 0x0054 */ public float[] TextureScales;
        [NMS(Size = 0x08)]
        /* 0x0074 */ public float[] TextureDistances;
        /* 0x0094 */ public float HeightBlend;
        /* 0x0098 */ public float SmoothStepBelow;
        /* 0x009C */ public float SmoothStepAbove;
        /* 0x00A0 */ public float SmoothStepStrength;
        /* 0x00A4 */ public float TileBlendMultiplier;
        /* 0x00A8 */ public bool DebugFlattenAllTerrain;
        /* 0x00A9 */ public bool DebugNoFlattenForBuildings;
        /* 0x00AA */ public bool DebugLockTerrainSettingsIndex;
        [NMS(Size = 0x01, Ignore = true)]
        /* 0x00AB */ public byte[] PaddingAB;
        /* 0x00AC */ public int NumGeneratorCalls;
        /* 0x00B0 */ public int NumPolygoniseCalls;
        /* 0x00B4 */ public int NumPostPolygoniseCalls;
        /* 0x00B8 */ public float MinHighWaterLevel;
        /* 0x00BC */ public float MaxHighWaterLevel;
        /* 0x00C0 */ public float MinHighWaterRegionRatio;
        /* 0x00C4 */ public float MinHighWaterRatio;
        /* 0x00C8 */ public float MaxHighWaterRatio;
        /* 0x00CC */ public float MinWaterRatio;
        /* 0x00D0 */ public float MaxWaterRatio;

        [NMS(Size = 0x04, Ignore = true)]
        /* 0x00D4 */ public byte[] PaddingD4;

        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        /* 0x00D8 */ public NMSString0x10[] MiningSubstanceBiome;

        [NMS( EnumType = typeof( GcGalaxyStarTypes.GalaxyStarTypeEnum ) )]
        /* 0x01A8 */ public NMSString0x10[] MiningSubstanceStar;

        [NMS( EnumType = typeof( GcGalaxyStarTypes.GalaxyStarTypeEnum ) )]
        /* 0x01E8 */ public NMSString0x10[] MiningSubstanceStarExtreme;

        [NMS(Size = 0x05)]
        /* 0x0228 */ public NMSString0x10[] MiningSubstanceRare;
        /* 0x0278 */ public float TextureBlendScale0;
        /* 0x027C */ public float TextureBlendScale1;
        /* 0x0280 */ public float TextureBlendScale2;
        /* 0x0284 */ public float TextureBlendOffset;
        /* 0x0288 */ public float BaseSlopePower;
        /* 0x028C */ public float MountainSlopePower;
        /* 0x0290 */ public GcTerrainOverlayColours HueOverlay;
        /* 0x02A8 */ public GcTerrainOverlayColours SaturationOverlay;
        /* 0x02C0 */ public GcTerrainOverlayColours ValueOverlay;
        /* 0x02D8 */ public GcTerrainEditing TerrainEditing;
        /* 0x036C */ public float TerrainUndoCubesRange;
        /* 0x0370 */ public float TerrainUndoCubesAlpha;
        /* 0x0374 */ public float TerrainUndoCubesNoiseThreshold;
        /* 0x0378 */ public float TerrainUndoCubesNoiseFactor;
        /* 0x037C */ public float TerrainUndoFadeDepthConstant;
        /* 0x0380 */ public float TerrainUndoFadeDepthScalar;
        /* 0x0384 */ public bool TerrainEditUndosEnabled;
        [NMS(Size = 0x0B, Ignore = true)]
        /* 0x0385 */ public byte[] Padding385;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x257B332912F75CE4, NameHash = 0xFB4BF08D)]
    public class GcTerrainGlobals : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Colour TerrainBeamLightColour;
        [NMS(Index = 35, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x010 */ public NMSString0x10[] MiningSubstanceBiome;
        [NMS(Index = 38)]
        /* 0x110 */ public List<NMSString0x10> MiningSubstanceRare;
        [NMS(Index = 36)]
        /* 0x120 */ public List<NMSString0x10> MiningSubstanceStar;
        [NMS(Index = 37)]
        /* 0x130 */ public List<NMSString0x10> MiningSubstanceStarExtreme;
        [NMS(Index = 54)]
        /* 0x140 */ public VariableSizeString RegionHotspotsTable;
        [NMS(Index = 46)]
        /* 0x150 */ public GcTerrainEditing TerrainEditing;
        [NMS(Index = 43)]
        /* 0x1E8 */ public GcTerrainOverlayColours HueOverlay;
        [NMS(Index = 44)]
        /* 0x200 */ public GcTerrainOverlayColours SaturationOverlay;
        [NMS(Index = 45)]
        /* 0x218 */ public GcTerrainOverlayColours ValueOverlay;
        [NMS(Index = 23)]
        /* 0x230 */ public float DebugPrimeWaterLevel;
        [NMS(Index = 15)]
        /* 0x234 */ public float HeightBlend;
        [NMS(Index = 29)]
        /* 0x238 */ public float MaxHighWaterLevel;
        [NMS(Index = 32)]
        /* 0x23C */ public float MaxHighWaterRatio;
        [NMS(Index = 34)]
        /* 0x240 */ public float MaxWaterRatio;
        [NMS(Index = 28)]
        /* 0x244 */ public float MinHighWaterLevel;
        [NMS(Index = 31)]
        /* 0x248 */ public float MinHighWaterRatio;
        [NMS(Index = 30)]
        /* 0x24C */ public float MinHighWaterRegionRatio;
        [NMS(Index = 33)]
        /* 0x250 */ public float MinWaterRatio;
        [NMS(Index = 3)]
        /* 0x254 */ public float MouseWheelRotatePlaneSensitivity;
        [NMS(Index = 25)]
        /* 0x258 */ public int NumGeneratorCalls;
        [NMS(Index = 26)]
        /* 0x25C */ public int NumPolygoniseCalls;
        [NMS(Index = 27)]
        /* 0x260 */ public int NumPostPolygoniseCalls;
        [NMS(Index = 0)]
        /* 0x264 */ public float RegisterTerrainMinDistance;
        [NMS(Index = 17)]
        /* 0x268 */ public float SmoothStepAbove;
        [NMS(Index = 16)]
        /* 0x26C */ public float SmoothStepBelow;
        [NMS(Index = 18)]
        /* 0x270 */ public float SmoothStepStrength;
        [NMS(Index = 6)]
        /* 0x274 */ public float SubtractEditFrequency;
        [NMS(Index = 5)]
        /* 0x278 */ public float SubtractEditLength;
        [NMS(Index = 4)]
        /* 0x27C */ public float SubtractEditOffset;
        [NMS(Index = 7)]
        /* 0x280 */ public float TerrainBeamDefaultRadius;
        [NMS(Index = 2)]
        /* 0x284 */ public float TerrainBeamHologramTimeout;
        [NMS(Index = 8)]
        /* 0x288 */ public float TerrainBeamLightIntensity;
        [NMS(Index = 1)]
        /* 0x28C */ public float TerrainBeamUndoRangeFromLastAdd;
        [NMS(Index = 55)]
        /* 0x290 */ public int TerrainPrimeIndexStart;
        [NMS(Index = 48)]
        /* 0x294 */ public float TerrainUndoCubesAlpha;
        [NMS(Index = 50)]
        /* 0x298 */ public float TerrainUndoCubesNoiseFactor;
        [NMS(Index = 49)]
        /* 0x29C */ public float TerrainUndoCubesNoiseThreshold;
        [NMS(Index = 47)]
        /* 0x2A0 */ public float TerrainUndoCubesRange;
        [NMS(Index = 51)]
        /* 0x2A4 */ public float TerrainUndoFadeDepthConstant;
        [NMS(Index = 52)]
        /* 0x2A8 */ public float TerrainUndoFadeDepthScalar;
        [NMS(Index = 42)]
        /* 0x2AC */ public float TextureBlendOffset;
        [NMS(Index = 39)]
        /* 0x2B0 */ public float TextureBlendScale0;
        [NMS(Index = 40)]
        /* 0x2B4 */ public float TextureBlendScale1;
        [NMS(Index = 41)]
        /* 0x2B8 */ public float TextureBlendScale2;
        [NMS(Index = 11)]
        /* 0x2BC */ public float TextureFadeDistance;
        [NMS(Index = 12)]
        /* 0x2C0 */ public float TextureFadePower;
        [NMS(Index = 13)]
        /* 0x2C4 */ public float TextureScaleMultiplier;
        [NMS(Index = 14)]
        /* 0x2C8 */ public float TextureScalePower;
        [NMS(Index = 19)]
        /* 0x2CC */ public float TileBlendMultiplier;
        [NMS(Index = 10)]
        /* 0x2D0 */ public float UseMax;
        [NMS(Index = 20)]
        /* 0x2D4 */ public bool DebugFlattenAllTerrain;
        [NMS(Index = 24)]
        /* 0x2D5 */ public bool DebugLockTerrainSettingsIndex;
        [NMS(Index = 21)]
        /* 0x2D6 */ public bool DebugNoFlattenForBuildings;
        [NMS(Index = 53)]
        /* 0x2D7 */ public bool DebugRegionHotspots;
        [NMS(Index = 22)]
        /* 0x2D8 */ public bool DebugUltraDeepPrimeWater;
    }
}

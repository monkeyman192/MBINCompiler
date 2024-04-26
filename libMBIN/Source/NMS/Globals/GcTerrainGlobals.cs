using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9ABC6B6AFE809E46, NameHash = 0x6577C3680F2E5DB6)]
    public class GcTerrainGlobals : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Colour TerrainBeamLightColour;
        [NMS(Index = 33, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x010 */ public NMSString0x10[] MiningSubstanceBiome;
        [NMS(Index = 36)]
        /* 0x110 */ public List<NMSString0x10> MiningSubstanceRare;
        [NMS(Index = 34)]
        /* 0x120 */ public List<NMSString0x10> MiningSubstanceStar;
        [NMS(Index = 35)]
        /* 0x130 */ public List<NMSString0x10> MiningSubstanceStarExtreme;
        [NMS(Index = 44)]
        /* 0x140 */ public GcTerrainEditing TerrainEditing;
        [NMS(Index = 41)]
        /* 0x1D8 */ public GcTerrainOverlayColours HueOverlay;
        [NMS(Index = 42)]
        /* 0x1F0 */ public GcTerrainOverlayColours SaturationOverlay;
        [NMS(Index = 43)]
        /* 0x208 */ public GcTerrainOverlayColours ValueOverlay;
        [NMS(Index = 15)]
        /* 0x220 */ public float HeightBlend;
        [NMS(Index = 27)]
        /* 0x224 */ public float MaxHighWaterLevel;
        [NMS(Index = 30)]
        /* 0x228 */ public float MaxHighWaterRatio;
        [NMS(Index = 32)]
        /* 0x22C */ public float MaxWaterRatio;
        [NMS(Index = 26)]
        /* 0x230 */ public float MinHighWaterLevel;
        [NMS(Index = 29)]
        /* 0x234 */ public float MinHighWaterRatio;
        [NMS(Index = 28)]
        /* 0x238 */ public float MinHighWaterRegionRatio;
        [NMS(Index = 31)]
        /* 0x23C */ public float MinWaterRatio;
        [NMS(Index = 3)]
        /* 0x240 */ public float MouseWheelRotatePlaneSensitivity;
        [NMS(Index = 23)]
        /* 0x244 */ public int NumGeneratorCalls;
        [NMS(Index = 24)]
        /* 0x248 */ public int NumPolygoniseCalls;
        [NMS(Index = 25)]
        /* 0x24C */ public int NumPostPolygoniseCalls;
        [NMS(Index = 0)]
        /* 0x250 */ public float RegisterTerrainMinDistance;
        [NMS(Index = 17)]
        /* 0x254 */ public float SmoothStepAbove;
        [NMS(Index = 16)]
        /* 0x258 */ public float SmoothStepBelow;
        [NMS(Index = 18)]
        /* 0x25C */ public float SmoothStepStrength;
        [NMS(Index = 6)]
        /* 0x260 */ public float SubtractEditFrequency;
        [NMS(Index = 5)]
        /* 0x264 */ public float SubtractEditLength;
        [NMS(Index = 4)]
        /* 0x268 */ public float SubtractEditOffset;
        [NMS(Index = 7)]
        /* 0x26C */ public float TerrainBeamDefaultRadius;
        [NMS(Index = 2)]
        /* 0x270 */ public float TerrainBeamHologramTimeout;
        [NMS(Index = 8)]
        /* 0x274 */ public float TerrainBeamLightIntensity;
        [NMS(Index = 1)]
        /* 0x278 */ public float TerrainBeamUndoRangeFromLastAdd;
        [NMS(Index = 53)]
        /* 0x27C */ public int TerrainPrimeIndexStart;
        [NMS(Index = 46)]
        /* 0x280 */ public float TerrainUndoCubesAlpha;
        [NMS(Index = 48)]
        /* 0x284 */ public float TerrainUndoCubesNoiseFactor;
        [NMS(Index = 47)]
        /* 0x288 */ public float TerrainUndoCubesNoiseThreshold;
        [NMS(Index = 45)]
        /* 0x28C */ public float TerrainUndoCubesRange;
        [NMS(Index = 49)]
        /* 0x290 */ public float TerrainUndoFadeDepthConstant;
        [NMS(Index = 50)]
        /* 0x294 */ public float TerrainUndoFadeDepthScalar;
        [NMS(Index = 40)]
        /* 0x298 */ public float TextureBlendOffset;
        [NMS(Index = 37)]
        /* 0x29C */ public float TextureBlendScale0;
        [NMS(Index = 38)]
        /* 0x2A0 */ public float TextureBlendScale1;
        [NMS(Index = 39)]
        /* 0x2A4 */ public float TextureBlendScale2;
        [NMS(Index = 11)]
        /* 0x2A8 */ public float TextureFadeDistance;
        [NMS(Index = 12)]
        /* 0x2AC */ public float TextureFadePower;
        [NMS(Index = 13)]
        /* 0x2B0 */ public float TextureScaleMultiplier;
        [NMS(Index = 14)]
        /* 0x2B4 */ public float TextureScalePower;
        [NMS(Index = 19)]
        /* 0x2B8 */ public float TileBlendMultiplier;
        [NMS(Index = 10)]
        /* 0x2BC */ public float UseMax;
        [NMS(Index = 52)]
        /* 0x2C0 */ public NMSString0x80 RegionHotspotsTable;
        [NMS(Index = 20)]
        /* 0x340 */ public bool DebugFlattenAllTerrain;
        [NMS(Index = 22)]
        /* 0x341 */ public bool DebugLockTerrainSettingsIndex;
        [NMS(Index = 21)]
        /* 0x342 */ public bool DebugNoFlattenForBuildings;
        [NMS(Index = 51)]
        /* 0x343 */ public bool DebugRegionHotspots;
    }
}

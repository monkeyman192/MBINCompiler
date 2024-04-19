using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9ABC6B6AFE809E46, NameHash = 0x6577C3680F2E5DB6)]
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0x000 */ public Colour TerrainBeamLightColour;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x010 */ public NMSString0x10[] MiningSubstanceBiome;
        /* 0x110 */ public List<NMSString0x10> MiningSubstanceRare;
        /* 0x120 */ public List<NMSString0x10> MiningSubstanceStar;
        /* 0x130 */ public List<NMSString0x10> MiningSubstanceStarExtreme;
        /* 0x140 */ public GcTerrainEditing TerrainEditing;
        /* 0x1D8 */ public GcTerrainOverlayColours HueOverlay;
        /* 0x1F0 */ public GcTerrainOverlayColours SaturationOverlay;
        /* 0x208 */ public GcTerrainOverlayColours ValueOverlay;
        /* 0x220 */ public float HeightBlend;
        /* 0x224 */ public float MaxHighWaterLevel;
        /* 0x228 */ public float MaxHighWaterRatio;
        /* 0x22C */ public float MaxWaterRatio;
        /* 0x230 */ public float MinHighWaterLevel;
        /* 0x234 */ public float MinHighWaterRatio;
        /* 0x238 */ public float MinHighWaterRegionRatio;
        /* 0x23C */ public float MinWaterRatio;
        /* 0x240 */ public float MouseWheelRotatePlaneSensitivity;
        /* 0x244 */ public int NumGeneratorCalls;
        /* 0x248 */ public int NumPolygoniseCalls;
        /* 0x24C */ public int NumPostPolygoniseCalls;
        /* 0x250 */ public float RegisterTerrainMinDistance;
        /* 0x254 */ public float SmoothStepAbove;
        /* 0x258 */ public float SmoothStepBelow;
        /* 0x25C */ public float SmoothStepStrength;
        /* 0x260 */ public float SubtractEditFrequency;
        /* 0x264 */ public float SubtractEditLength;
        /* 0x268 */ public float SubtractEditOffset;
        /* 0x26C */ public float TerrainBeamDefaultRadius;
        /* 0x270 */ public float TerrainBeamHologramTimeout;
        /* 0x274 */ public float TerrainBeamLightIntensity;
        /* 0x278 */ public float TerrainBeamUndoRangeFromLastAdd;
        /* 0x27C */ public int TerrainPrimeIndexStart;
        /* 0x280 */ public float TerrainUndoCubesAlpha;
        /* 0x284 */ public float TerrainUndoCubesNoiseFactor;
        /* 0x288 */ public float TerrainUndoCubesNoiseThreshold;
        /* 0x28C */ public float TerrainUndoCubesRange;
        /* 0x290 */ public float TerrainUndoFadeDepthConstant;
        /* 0x294 */ public float TerrainUndoFadeDepthScalar;
        /* 0x298 */ public float TextureBlendOffset;
        /* 0x29C */ public float TextureBlendScale0;
        /* 0x2A0 */ public float TextureBlendScale1;
        /* 0x2A4 */ public float TextureBlendScale2;
        /* 0x2A8 */ public float TextureFadeDistance;
        /* 0x2AC */ public float TextureFadePower;
        /* 0x2B0 */ public float TextureScaleMultiplier;
        /* 0x2B4 */ public float TextureScalePower;
        /* 0x2B8 */ public float TileBlendMultiplier;
        /* 0x2BC */ public float UseMax;
        /* 0x2C0 */ public NMSString0x80 RegionHotspotsTable;
        /* 0x340 */ public bool DebugFlattenAllTerrain;
        /* 0x341 */ public bool DebugLockTerrainSettingsIndex;
        /* 0x342 */ public bool DebugNoFlattenForBuildings;
        /* 0x343 */ public bool DebugRegionHotspots;
    }
}

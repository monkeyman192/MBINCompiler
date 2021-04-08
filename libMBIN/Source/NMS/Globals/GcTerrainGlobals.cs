﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x360, GUID = 0x9D5FB82FF4D44F8E)]
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0x000 */ public float RegisterTerrainMinDistance;
        /* 0x004 */ public float TerrainBeamUndoRangeFromLastAdd;
        /* 0x008 */ public float TerrainBeamHologramTimeout;
        /* 0x00C */ public float MouseWheelRotatePlaneSensitivity;
        /* 0x010 */ public float SubtractEditOffset;
        /* 0x014 */ public float SubtractEditLength;
        /* 0x018 */ public float SubtractEditFrequency;
        /* 0x01C */ public float TerrainBeamDefaultRadius;
        /* 0x020 */ public float TerrainBeamLightIntensity;
        /* 0x030 */ public Colour TerrainBeamLightColour;
        /* 0x040 */ public float UseMax;
        /* 0x044 */ public float TextureFadeDistance;
        /* 0x048 */ public float TextureFadePower;
        /* 0x04C */ public float TextureScaleMultiplier;
        /* 0x050 */ public float TextureScalePower;
        /* 0x054 */ public float HeightBlend;
        /* 0x058 */ public float SmoothStepBelow;
        /* 0x05C */ public float SmoothStepAbove;
        /* 0x060 */ public float SmoothStepStrength;
        /* 0x064 */ public float TileBlendMultiplier;
        /* 0x068 */ public bool DebugFlattenAllTerrain;
        /* 0x069 */ public bool DebugNoFlattenForBuildings;
        /* 0x06A */ public bool DebugLockTerrainSettingsIndex;
        /* 0x06C */ public int NumGeneratorCalls;
        /* 0x070 */ public int NumPolygoniseCalls;
        /* 0x074 */ public int NumPostPolygoniseCalls;
        /* 0x078 */ public float MinHighWaterLevel;
        /* 0x07C */ public float MaxHighWaterLevel;
        /* 0x080 */ public float MinHighWaterRegionRatio;
        /* 0x084 */ public float MinHighWaterRatio;
        /* 0x088 */ public float MaxHighWaterRatio;
        /* 0x08C */ public float MinWaterRatio;
        /* 0x090 */ public float MaxWaterRatio;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x094 */ public byte[] Padding94;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x098 */ public NMSString0x10[] MiningSubstanceBiome;
        /* 0x198 */ public List<NMSString0x10> MiningSubstanceStar;
        /* 0x1A8 */ public List<NMSString0x10> MiningSubstanceStarExtreme;
        /* 0x1B8 */ public List<NMSString0x10> MiningSubstanceRare;
        /* 0x1C8 */ public float TextureBlendScale0;
        /* 0x1CC */ public float TextureBlendScale1;
        /* 0x1D0 */ public float TextureBlendScale2;
        /* 0x1D4 */ public float TextureBlendOffset;
        /* 0x1D8 */ public GcTerrainOverlayColours HueOverlay;
        /* 0x1F0 */ public GcTerrainOverlayColours SaturationOverlay;
        /* 0x208 */ public GcTerrainOverlayColours ValueOverlay;
        /* 0x220 */ public GcTerrainEditing TerrainEditing;
        /* 0x2B8 */ public float TerrainUndoCubesRange;
        /* 0x2BC */ public float TerrainUndoCubesAlpha;
        /* 0x2C0 */ public float TerrainUndoCubesNoiseThreshold;
        /* 0x2C4 */ public float TerrainUndoCubesNoiseFactor;
        /* 0x2C8 */ public float TerrainUndoFadeDepthConstant;
        /* 0x2CC */ public float TerrainUndoFadeDepthScalar;
        /* 0x2D0 */ public bool DebugRegionHotspots;
        [NMS(Size = 0x80)]
        /* 0x2D1 */ public string RegionHotspotsTable;
        /* 0x354 */ public int TerrainPrimeIndexStart;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x358 */ public byte[] EndPadding;
    }
}
//using libMBIN.NMS.Toolkit;
//using libMBIN.NMS.GameComponents;

//namespace libMBIN.NMS.Globals
//{
//    [NMS(Size = 0x400, GUID = 0xB6A014424B0C7035)]
//    public class GcTerrainGlobals : NMSTemplate
//    {
//        /* 0x000 */ public float RegisterTerrainMinDistance;
//        /* 0x004 */ public float TerrainBeamUndoRangeFromLastAdd;
//        /* 0x008 */ public float TerrainBeamHologramTimeout;
//        /* 0x00C */ public float MouseWheelRotatePlaneSensitivity;
//        /* 0x010 */ public float SubtractEditOffset;
//        /* 0x014 */ public float SubtractEditLength;
//        /* 0x018 */ public float SubtractEditFrequency;
//        /* 0x01C */ public float TerrainBeamDefaultRadius;
//        /* 0x020 */ public float TerrainBeamLightIntensity;
//        [NMS(Size = 0xC, Ignore = true)]
//        /* 0x024 */ public byte[] Padding24;
//        /* 0x030 */ public Colour TerrainBeamLightColour;
//        /* 0x040 */ public float UseMax;
//        /* 0x044 */ public float TextureFadeDistance;
//        /* 0x048 */ public float TextureFadePower;
//        /* 0x04C */ public float TextureScaleMultiplier;
//        /* 0x050 */ public float TextureScalePower;
//        /* 0x054 */ public float HeightBlend;
//        /* 0x058 */ public float SmoothStepBelow;
//        /* 0x05C */ public float SmoothStepAbove;
//        /* 0x060 */ public float SmoothStepStrength;
//        /* 0x064 */ public float TileBlendMultiplier;
//        /* 0x068 */ public bool DebugFlattenAllTerrain;
//        /* 0x069 */ public bool DebugNoFlattenForBuildings;
//        /* 0x06A */ public bool DebugLockTerrainSettingsIndex;
//        [NMS(Size = 0x1, Ignore = true)]
//        /* 0x06B */ public byte[] Padding6B;
//        /* 0x06C */ public int NumGeneratorCalls;
//        /* 0x070 */ public int NumPolygoniseCalls;
//        /* 0x074 */ public int NumPostPolygoniseCalls;
//        /* 0x078 */ public float MinHighWaterLevel;
//        /* 0x07C */ public float MaxHighWaterLevel;
//        /* 0x080 */ public float MinHighWaterRegionRatio;
//        /* 0x084 */ public float MinHighWaterRatio;
//        /* 0x088 */ public float MaxHighWaterRatio;
//        /* 0x08C */ public float MinWaterRatio;
//        /* 0x090 */ public float MaxWaterRatio;
//        [NMS(Size = 0x4, Ignore = true)]
//        /* 0x094 */ public byte[] Padding94;
//        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
//        /* 0x098 */ public NMSString0x10[] MiningSubstanceBiome;
//        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
//        /* 0x198 */ public NMSString0x10[] MiningSubstanceStar;
//        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
//        /* 0x1D8 */ public NMSString0x10[] MiningSubstanceStarExtreme;
//        [NMS(Size = 0x5)]
//        /* 0x218 */ public NMSString0x10[] MiningSubstanceRare;
//        /* 0x268 */ public float TextureBlendScale0;
//        /* 0x26C */ public float TextureBlendScale1;
//        /* 0x270 */ public float TextureBlendScale2;
//        /* 0x274 */ public float TextureBlendOffset;
//        /* 0x278 */ public GcTerrainOverlayColours HueOverlay;
//        /* 0x290 */ public GcTerrainOverlayColours SaturationOverlay;
//        /* 0x2A8 */ public GcTerrainOverlayColours ValueOverlay;
//        /* 0x2C0 */ public GcTerrainEditing TerrainEditing;
//        /* 0x358 */ public float TerrainUndoCubesRange;
//        /* 0x35C */ public float TerrainUndoCubesAlpha;
//        /* 0x360 */ public float TerrainUndoCubesNoiseThreshold;
//        /* 0x364 */ public float TerrainUndoCubesNoiseFactor;
//        /* 0x368 */ public float TerrainUndoFadeDepthConstant;
//        /* 0x36C */ public float TerrainUndoFadeDepthScalar;
//        /* 0x370 */ public bool DebugRegionHotspots;
//        [NMS(Size = 0x80)]
//        /* 0x371 */ public string RegionHotspotsTable;
//        [NMS(Size = 0x3, Ignore = true)]
//        /* 0x3F1 */ public byte[] Padding3F1;
//        /* 0x3F4 */ public int TerrainPrimeIndexStart;
//        [NMS(Size = 0x8, Ignore = true)]
//        /* 0x3F8 */ public byte[] EndPadding;
//    }
//}

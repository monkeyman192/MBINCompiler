namespace libMBIN.Models.Structs
{
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0x0 */ public float RegisterTerrainMinDistance;
        /* 0x4 */ public float TerrainBeamUndoRangeFromLastAdd;
        /* 0x8 */ public float TerrainBeamHologramTimeout;
        /* 0xC */ public float MouseWheelRotatePlaneSensitivity;
        /* 0x10 */ public float SubtractEditOffset;
        /* 0x14 */ public float SubtractEditLength;
        /* 0x18 */ public float SubtractEditFrequency;
        /* 0x1C */ public float TerrainBeamDefaultRadius;
        /* 0x20 */ public float TerrainBeamLightIntensity;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x24 */ public byte[] Padding24;
        /* 0x30 */ public Colour TerrainBeamLightColour;
        /* 0x40 */ public float UseMax;
        /* 0x44 */ public float TextureFadeDistance;
        /* 0x48 */ public float TextureFadePower;
        /* 0x4C */ public float TextureScaleMultiplier;
        /* 0x50 */ public float TextureScalePower;
        [NMS(Size = 0x8)]
        /* 0x54 */ public float[] TextureScales;
        [NMS(Size = 0x8)]
        /* 0x74 */ public float[] TextureDistances;
        /* 0x94 */ public float HeightBlend;
        /* 0x98 */ public float SmoothStepBelow;
        /* 0x9C */ public float SmoothStepAbove;
        /* 0xA0 */ public float SmoothStepStrength;
        /* 0xA4 */ public float TileBlendMultiplier;
        /* 0xA8 */ public bool DebugFlattenAllTerrain;
        /* 0xA9 */ public bool DebugNoFlattenForBuildings;
        /* 0xAA */ public bool DebugLockTerrainSettingsIndex;
        /* 0xAC */ public int NumGeneratorCalls;
        /* 0xB0 */ public int NumPolygoniseCalls;
        /* 0xB4 */ public int NumPostPolygoniseCalls;
        /* 0xB8 */ public float MinHighWaterLevel;
        /* 0xBC */ public float MaxHighWaterLevel;
        /* 0xC0 */ public float MinHighWaterRegionRatio;
        /* 0xC4 */ public float MinHighWaterRatio;
        /* 0xC8 */ public float MaxHighWaterRatio;
        /* 0xCC */ public float MinWaterRatio;
        /* 0xD0 */ public float MaxWaterRatio;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD4 */ public byte[] PaddingD4;
        [NMS(Size = 0xB, EnumValue = new string[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue" })]
        /* 0xD8 */ public NMSString0x10[] MiningSubstanceBiome;
        [NMS(Size = 0x4, EnumValue = new string[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x188 */ public NMSString0x10[] MiningSubstanceStar;
        [NMS(Size = 0x4, EnumValue = new string[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x1C8 */ public NMSString0x10[] MiningSubstanceStarExtreme;
        [NMS(Size = 0x5)]
        /* 0x208 */ public NMSString0x10[] MiningSubstanceRare;
        /* 0x258 */ public float TextureBlendScale0;
        /* 0x25C */ public float TextureBlendScale1;
        /* 0x260 */ public float TextureBlendScale2;
        /* 0x264 */ public float TextureBlendOffset;
        /* 0x268 */ public float BaseSlopePower;
        /* 0x26C */ public float MountainSlopePower;
        /* 0x270 */ public GcTerrainOverlayColours HueOverlay;
        /* 0x288 */ public GcTerrainOverlayColours SaturationOverlay;
        /* 0x2A0 */ public GcTerrainOverlayColours ValueOverlay;
        /* 0x2B8 */ public GcTerrainEditing TerrainEditing;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x338 */ public byte[] EndPadding;
    }
}

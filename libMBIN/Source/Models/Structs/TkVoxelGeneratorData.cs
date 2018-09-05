namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x15D0)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed BaseSeed;
        /* 0x0010 */ public float SeaLevel;
        /* 0x0014 */ public float BeachHeight;
        /* 0x0018 */ public float NoSeaBaseLevel;
        /* 0x001C */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        /* 0x0020 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;

        [NMS(Size = 8, EnumValue = new[] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation", "Continent" })]
        /* 0x0024 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 9, EnumValue = new[] { "Small", "Large", "Resources_Heridium", "Resources_Iridium", "Resources_Copper", "Resources_Nickel", "Resources_Aluminium", "Resources_Gold", "Resources_Emeril" })]
        /* 0x0464 */ public TkNoiseGridData[] GridLayers;
        [NMS(Size = 7, EnumValue = new[] { "River", "Crater", "Arches", "ArchesSmall", "Blobs", "BlobsSmall", "Substance" })]
        /* 0x134C */ public TkNoiseFeatureData[] Features;
        [NMS(Size = 1, EnumValue = new[] { "Underground" })]
        /* 0x1528 */ public TkNoiseCaveData[] CavesUnderground;
        /* 0x15B0 */ public float MinimumCaveDepth;
        /* 0x15B4 */ public float CaveRoofSmoothingDist;
        /* 0x15B8 */ public float MaximumSeaLevelCaveDepth;
        /* 0x15BC */ public float BuildingTextureRadius;
        /* 0x15C0 */ public float BuildingSmoothingRadius;
        /* 0x15C4 */ public float BuildingSmoothingHeight;
        /* 0x15C8 */ public float WaterFadeInDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15CC */ public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkVoxelGeneratorData : NMSTemplate  // Size: 0xBB8
    {
        /* 0x000 */ public GcSeed BaseSeed;
        /* 0x010 */ public float SeaLevel;
        /* 0x014 */ public float SeaRatio;
        /* 0x018 */ public float NoSeaBaseLevel;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding0x1C;

        [NMS(Size = 7, EnumValue = new string[7] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation" })]
        /* 0x020 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 5, EnumValue = new string[5] { "Boulder", "Large", "ResourcesA", "ResourcesB", "ResourcesC" })]
        /* 0x26C */ public TkNoiseGridData[] GridLayers;
        [NMS(Size = 6, EnumValue = new string[6] { "River", "Crater", "Arches", "ArchesSmall", "Blobs", "BlobsSmall" })]
        /* 0x974 */ public TkNoiseFeatureData[] Features;
        /* 0xAC4 */ public TkNoiseCaveData CavesUnderground;
        /* 0xB34 */ public float MinimumCaveDepth;
        /* 0xB38 */ public float CaveRoofSmoothingDist;
        /* 0xB3C */ public float MaximumSeaLevelCaveDepth;
        /* 0xB40 */ public float BuildingSmoothingRadius;
        /* 0xB44 */ public float BuildingSmoothingHeight;
        /* 0xB48 */ public float WaterFadeInDistance;
        /* 0xB4C */ public float HueOverlayCutoff;
        /* 0xB50 */ public float HueOverlayScale;
        /* 0xB54 */ public float HueOverlayStrength;
        /* 0xB58 */ public float ValueOverlayCutoff;
        /* 0xB5C */ public float ValueOverlayScale;
        /* 0xB60 */ public float ValueOverlayStrength;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB64;
        /* 0xB68 */ public TkVoxelGeneratorRegionData Regions;
    }
}

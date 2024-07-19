using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x67C169FE5F0A1325, NameHash = 0x7396A29C)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        [NMS(Index = 7, Size = 0x9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x0000 */ public TkNoiseGridData[] GridLayers;
        [NMS(Index = 0)]
        /* 0x0AB0 */ public GcSeed BaseSeed;
        [NMS(Index = 6, Size = 0x8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x0AC0 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Index = 8, Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x0EE0 */ public TkNoiseFeatureData[] Features;
        [NMS(Index = 9, Size = 0x1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x10A0 */ public TkNoiseCaveData[] Caves;
        [NMS(Index = 2)]
        /* 0x1120 */ public float BeachHeight;
        [NMS(Index = 15)]
        /* 0x1124 */ public float BuildingSmoothingHeight;
        [NMS(Index = 14)]
        /* 0x1128 */ public float BuildingSmoothingRadius;
        [NMS(Index = 13)]
        /* 0x112C */ public float BuildingTextureRadius;
        [NMS(Index = 4)]
        /* 0x1130 */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        [NMS(Index = 11)]
        /* 0x1134 */ public float CaveRoofSmoothingDist;
        [NMS(Index = 12)]
        /* 0x1138 */ public float MaximumSeaLevelCaveDepth;
        [NMS(Index = 10)]
        /* 0x113C */ public float MinimumCaveDepth;
        [NMS(Index = 3)]
        /* 0x1140 */ public float NoSeaBaseLevel;
        [NMS(Index = 5)]
        /* 0x1144 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;
        [NMS(Index = 1)]
        /* 0x1148 */ public float SeaLevel;
        [NMS(Index = 16)]
        /* 0x114C */ public float WaterFadeInDistance;
    }
}

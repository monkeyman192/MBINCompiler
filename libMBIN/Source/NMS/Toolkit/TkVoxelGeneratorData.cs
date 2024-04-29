using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBEC89E111310CBB9, NameHash = 0x7A347325F1154095)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0000 */ public GcSeed BaseSeed;
        [NMS(Index = 7, Size = 0x9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x0010 */ public TkNoiseGridData[] GridLayers;
        [NMS(Index = 6, Size = 0x8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x0EB0 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Index = 8, Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x12D0 */ public TkNoiseFeatureData[] Features;
        [NMS(Index = 9, Size = 0x1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x1490 */ public TkNoiseCaveData[] Caves;
        [NMS(Index = 2)]
        /* 0x1510 */ public float BeachHeight;
        [NMS(Index = 15)]
        /* 0x1514 */ public float BuildingSmoothingHeight;
        [NMS(Index = 14)]
        /* 0x1518 */ public float BuildingSmoothingRadius;
        [NMS(Index = 13)]
        /* 0x151C */ public float BuildingTextureRadius;
        [NMS(Index = 4)]
        /* 0x1520 */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        [NMS(Index = 11)]
        /* 0x1524 */ public float CaveRoofSmoothingDist;
        [NMS(Index = 12)]
        /* 0x1528 */ public float MaximumSeaLevelCaveDepth;
        [NMS(Index = 10)]
        /* 0x152C */ public float MinimumCaveDepth;
        [NMS(Index = 3)]
        /* 0x1530 */ public float NoSeaBaseLevel;
        [NMS(Index = 5)]
        /* 0x1534 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;
        [NMS(Index = 1)]
        /* 0x1538 */ public float SeaLevel;
        [NMS(Index = 16)]
        /* 0x153C */ public float WaterFadeInDistance;
    }
}

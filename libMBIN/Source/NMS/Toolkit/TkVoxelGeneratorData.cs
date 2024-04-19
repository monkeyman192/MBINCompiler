using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3541FEC673F2CB77, NameHash = 0x7A347325F1154095)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed BaseSeed;
        [NMS(Size = 0x9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x0010 */ public TkNoiseGridData[] GridLayers;
        [NMS(Size = 0x8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x0EB0 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x12D0 */ public TkNoiseFeatureData[] Features;
        [NMS(Size = 0x1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x1490 */ public TkNoiseCaveData[] Caves;
        /* 0x1510 */ public float BeachHeight;
        /* 0x1514 */ public float BuildingSmoothingHeight;
        /* 0x1518 */ public float BuildingSmoothingRadius;
        /* 0x151C */ public float BuildingTextureRadius;
        /* 0x1520 */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        /* 0x1524 */ public float CaveRoofSmoothingDist;
        /* 0x1528 */ public float MaximumSeaLevelCaveDepth;
        /* 0x152C */ public float MinimumCaveDepth;
        /* 0x1530 */ public float NoSeaBaseLevel;
        /* 0x1534 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;
        /* 0x1538 */ public float SeaLevel;
        /* 0x153C */ public float WaterFadeInDistance;
    }
}

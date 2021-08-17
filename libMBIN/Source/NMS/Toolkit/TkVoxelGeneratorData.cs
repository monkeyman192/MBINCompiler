using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x15D0, GUID = 0xE434B739E9AA8AEB, NameHash = 0x7A347325F1154095)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed BaseSeed;
        /* 0x0010 */ public float SeaLevel;
        /* 0x0014 */ public float BeachHeight;
        /* 0x0018 */ public float NoSeaBaseLevel;
        /* 0x001C */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        /* 0x0020 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;
        [NMS(Size = 8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x0024 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x0464 */ public TkNoiseGridData[] GridLayers;
        [NMS(Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x134C */ public TkNoiseFeatureData[] Features;
        [NMS(Size = 1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x1528 */ public TkNoiseCaveData[] Caves;
        /* 0x15B0 */ public float MinimumCaveDepth;
        /* 0x15B4 */ public float CaveRoofSmoothingDist;
        /* 0x15B8 */ public float MaximumSeaLevelCaveDepth;
        /* 0x15BC */ public float BuildingTextureRadius;
        /* 0x15C0 */ public float BuildingSmoothingRadius;
        /* 0x15C4 */ public float BuildingSmoothingHeight;
        /* 0x15C8 */ public float WaterFadeInDistance;
    }
}

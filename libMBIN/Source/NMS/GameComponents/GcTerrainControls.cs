using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E82971E628F0C68, NameHash = 0x2AD2911065D6EA2)]
    public class GcTerrainControls : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x00 */ public float[] GridLayers;
        [NMS(Size = 0x8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x24 */ public float[] NoiseLayers;
        [NMS(Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x44 */ public float[] Features;
        [NMS(Size = 0x1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x60 */ public float[] Caves;
        /* 0x64 */ public float HighWaterActiveFrequency;
        /* 0x68 */ public float RockTileFrequency;
        /* 0x6C */ public float SubstanceTileFrequency;
        /* 0x70 */ public float WaterActiveFrequency;
        /* 0x74 */ public bool ForceContinentalNoise;
    }
}

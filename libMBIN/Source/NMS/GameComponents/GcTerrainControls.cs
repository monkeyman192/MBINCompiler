using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB18165FD5FFF1D56, NameHash = 0x2AD2911065D6EA2)]
    public class GcTerrainControls : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(TkGridLayersEnum.GridLayerTypesEnum))]
        /* 0x00 */ public float[] GridLayers;
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(TkNoiseLayersEnum.NoiseLayerTypesEnum))]
        /* 0x24 */ public float[] NoiseLayers;
        [NMS(Index = 2, Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x44 */ public float[] Features;
        [NMS(Index = 3, Size = 0x1, EnumType = typeof(TkCavesEnum.CaveTypesEnum))]
        /* 0x60 */ public float[] Caves;
        [NMS(Index = 5)]
        /* 0x64 */ public float HighWaterActiveFrequency;
        [NMS(Index = 6)]
        /* 0x68 */ public float RockTileFrequency;
        [NMS(Index = 7)]
        /* 0x6C */ public float SubstanceTileFrequency;
        [NMS(Index = 4)]
        /* 0x70 */ public float WaterActiveFrequency;
        [NMS(Index = 8)]
        /* 0x74 */ public bool ForceContinentalNoise;
    }
}

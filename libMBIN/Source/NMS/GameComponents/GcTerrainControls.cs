using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0x1E15DB90CA3FBF5B, NameHash = 0x2AD2911065D6EA2)]
    public class GcTerrainControls : NMSTemplate
    {
        public enum TerrainEnum { Base, Hill, Mountain, Rock, UnderWater, Texture, Elevation, Continent }
        [NMS(Size = 8, EnumType = typeof(TerrainEnum))]
        /* 0x00 */ public float[] NoiseLayers;      // chance of this noise layer being active
        public enum ResourcesEnum { Small, Large, Resources_Heridium, Resources_Iridium, Resources_Copper, Resources_Nickel, Resources_Aluminium, Resources_Gold, Resources_Emeril }
        [NMS(Size = 9, EnumType = typeof(ResourcesEnum))]
        /* 0x20 */ public float[] GridLayers;
        [NMS(Size = 0x7, EnumType = typeof(TkFeaturesEnum.FeatureTypesEnum))]
        /* 0x44 */ public float[] Features;         // chance of this kind of feature being active
        public enum UndergroundEnum { Underground }
        [NMS(Size = 1, EnumType = typeof(UndergroundEnum))]
        /* 0x60 */ public float[] Caves;
        /* 0x64 */ public float WaterActiveFrequency;       // 3F4CCCCDh        
        /* 0x68 */ public float HighWaterActiveFrequency;   // 3E800000h
        /* 0x6C */ public float RockTileFrequency;          // 3E800000h
        /* 0x70 */ public float SubstanceTileFrequency;     // 3E800000h
        /* 0x74 */ public bool ForceContinentalNoise;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x75 */ public byte[] EndPadding;
    }
}

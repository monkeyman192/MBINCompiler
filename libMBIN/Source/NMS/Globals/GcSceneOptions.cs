using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4DDA4C989AD367CC, NameHash = 0x7DECDDEB)]
    public class GcSceneOptions : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public VariableSizeString AtmosphereFile;
        [NMS(Index = 3)]
        /* 0x10 */ public VariableSizeString BiomeFile;
        [NMS(Index = 7)]
        /* 0x20 */ public VariableSizeString CaveBiomeFile;
        [NMS(Index = 12)]
        /* 0x30 */ public List<Vector3f> ForceResource;
        [NMS(Index = 9)]
        /* 0x40 */ public VariableSizeString TerrainFile;
        [NMS(Index = 5)]
        /* 0x50 */ public VariableSizeString WaterBiomeFile;
        [NMS(Index = 13)]
        /* 0x60 */ public float ForceResourceSize;
        [NMS(Index = 0)]
        /* 0x64 */ public int RecentToolboxIndex;
        [NMS(Index = 1)]
        /* 0x68 */ public int SelectedToolboxIndex;
        [NMS(Index = 10)]
        /* 0x6C */ public bool OverrideAtmosphere;
        [NMS(Index = 2)]
        /* 0x6D */ public bool OverrideBiome;
        [NMS(Index = 6)]
        /* 0x6E */ public bool OverrideCaveBiome;
        [NMS(Index = 8)]
        /* 0x6F */ public bool OverrideTerrain;
        [NMS(Index = 4)]
        /* 0x70 */ public bool OverrideWaterBiome;
    }
}

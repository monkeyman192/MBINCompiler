using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x31ECD5378BB33870, NameHash = 0xFF2996557C508B00)]
    public class GcSceneOptions : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x000 */ public List<Vector3f> ForceResource;
        [NMS(Index = 13)]
        /* 0x010 */ public float ForceResourceSize;
        [NMS(Index = 0)]
        /* 0x014 */ public int RecentToolboxIndex;
        [NMS(Index = 1)]
        /* 0x018 */ public int SelectedToolboxIndex;
        [NMS(Index = 11)]
        /* 0x01C */ public NMSString0x80 AtmosphereFile;
        [NMS(Index = 3)]
        /* 0x09C */ public NMSString0x80 BiomeFile;
        [NMS(Index = 7)]
        /* 0x11C */ public NMSString0x80 CaveBiomeFile;
        [NMS(Index = 9)]
        /* 0x19C */ public NMSString0x80 TerrainFile;
        [NMS(Index = 5)]
        /* 0x21C */ public NMSString0x80 WaterBiomeFile;
        [NMS(Index = 10)]
        /* 0x29C */ public bool OverrideAtmosphere;
        [NMS(Index = 2)]
        /* 0x29D */ public bool OverrideBiome;
        [NMS(Index = 6)]
        /* 0x29E */ public bool OverrideCaveBiome;
        [NMS(Index = 8)]
        /* 0x29F */ public bool OverrideTerrain;
        [NMS(Index = 4)]
        /* 0x2A0 */ public bool OverrideWaterBiome;
    }
}

using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x31ECD5378BB33870, NameHash = 0xFF2996557C508B00)]
    public class GcSceneOptions : NMSTemplate
    {
        /* 0x000 */ public List<Vector3f> ForceResource;
        /* 0x010 */ public float ForceResourceSize;
        /* 0x014 */ public int RecentToolboxIndex;
        /* 0x018 */ public int SelectedToolboxIndex;
        /* 0x01C */ public NMSString0x80 AtmosphereFile;
        /* 0x09C */ public NMSString0x80 BiomeFile;
        /* 0x11C */ public NMSString0x80 CaveBiomeFile;
        /* 0x19C */ public NMSString0x80 TerrainFile;
        /* 0x21C */ public NMSString0x80 WaterBiomeFile;
        /* 0x29C */ public bool OverrideAtmosphere;
        /* 0x29D */ public bool OverrideBiome;
        /* 0x29E */ public bool OverrideCaveBiome;
        /* 0x29F */ public bool OverrideTerrain;
        /* 0x2A0 */ public bool OverrideWaterBiome;
    }
}

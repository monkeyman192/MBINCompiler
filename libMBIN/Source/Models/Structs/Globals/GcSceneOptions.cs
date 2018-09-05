namespace libMBIN.Models.Structs.Unfinished
{
    public class GcSceneOptions : NMSTemplate // doesn't seem like any of this is used by the game..
    {
        /* 0x0 */ public int RecentToolboxIndex;
        /* 0x4 */ public int SelectedToolboxIndex;
        /* 0x8 */ public bool OverrideBiome;
        [NMS(Size = 0x80)]
        /* 0x9 */ public string BiomeFile;
        /* 0x89 */ public bool OverrideWaterBiome;
        [NMS(Size = 0x80)]
        /* 0x8A */ public string WaterBiomeFile;
        /* 0x10A */ public bool OverrideCaveBiome;
        [NMS(Size = 0x80)]
        /* 0x10B */ public string CaveBiomeFile;
        /* 0x18B */ public bool OverrideTerrain;
        [NMS(Size = 0x80)]
        /* 0x18C */ public string TerrainFile;
        /* 0x20C */ public bool OverrideAtmosphere;
        [NMS(Size = 0x80)]
        /* 0x20D */ public string AtmosphereFile;
        /* 0x290 */ public Vector4f ForceResource;     // dunno what this is... Dummy for now...
        /* 0x2A0 */ public float ForceResourceSize;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A4 */ public byte[] EndPadding;
    }
}

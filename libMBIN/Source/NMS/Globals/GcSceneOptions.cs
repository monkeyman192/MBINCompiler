using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2A8, GUID = 0xE631F099F9410CAB, NameHash = 0xFF2996557C508B00)]
    public class GcSceneOptions : NMSTemplate // doesn't seem like any of this is used by the game..
    {
        /* 0x000 */ public int RecentToolboxIndex;
        /* 0x004 */ public int SelectedToolboxIndex;
        /* 0x008 */ public bool OverrideBiome;
        /* 0x009 */ public NMSString0x80 BiomeFile;
        /* 0x089 */ public bool OverrideWaterBiome;
        /* 0x08A */ public NMSString0x80 WaterBiomeFile;
        /* 0x10A */ public bool OverrideCaveBiome;
        /* 0x10B */ public NMSString0x80 CaveBiomeFile;
        /* 0x18B */ public bool OverrideTerrain;
        /* 0x18C */ public NMSString0x80 TerrainFile;
        /* 0x20C */ public bool OverrideAtmosphere;
        /* 0x20D */ public NMSString0x80 AtmosphereFile;
        /* 0x290 */ public List<Vector3f> ForceResource;
        /* 0x2A0 */ public float ForceResourceSize;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2A4 */ public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x253126BB3DB6A474, NameHash = 0x2E161A5A69971115)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public GcGalaxyStarTypes Star;
        /* 0x14 */ public GcPlanetClass Class;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string CommonSubstance;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string RareSubstance;
        /* 0x38 */ public GcPlanetSize PlanetSize;
        /* 0x3C */ public GcBiomeType Biome;
        /* 0x40 */ public GcBiomeSubType BiomeSubType;
        /* 0x44 */ public bool HasRings;
        /* 0x45 */ public bool ForceContinents;
        /* 0x46 */ public bool InEmptySystem;
        /* 0x48 */ public int RealityIndex;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x4C */ public byte[] EndPadding;
    }
}

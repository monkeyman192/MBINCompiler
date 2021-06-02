using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xABA9DA38AAAE2258, NameHash = 0x2E161A5A69971115)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public GcGalaxyStarTypes Star;
        /* 0x14 */ public GcPlanetClass Class;
        /* 0x18 */ public NMSString0x10 CommonSubstance;
        /* 0x28 */ public NMSString0x10 RareSubstance;
        /* 0x38 */ public GcPlanetSize PlanetSize;
        /* 0x3C */ public GcBiomeType Biome;
        /* 0x40 */ public GcBiomeSubType BiomeSubType;
        /* 0x44 */ public bool HasRings;
        /* 0x45 */ public bool ForceContinents;
        /* 0x46 */ public bool InEmptySystem;
        /* 0x47 */ public bool InAbandonedSystem;
        /* 0x48 */ public bool Prime;
        /* 0x4C */ public int RealityIndex;
    }
}

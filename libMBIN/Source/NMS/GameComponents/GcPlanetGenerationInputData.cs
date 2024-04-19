using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F95770CDD1342B2, NameHash = 0x2E161A5A69971115)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CommonSubstance;
        /* 0x10 */ public NMSString0x10 RareSubstance;
        /* 0x20 */ public GcSeed Seed;
        /* 0x30 */ public GcBiomeType Biome;
        /* 0x34 */ public GcBiomeSubType BiomeSubType;
        /* 0x38 */ public GcPlanetClass Class;
        /* 0x3C */ public GcPlanetSize PlanetSize;
        /* 0x40 */ public int RealityIndex;
        /* 0x44 */ public GcGalaxyStarTypes Star;
        /* 0x48 */ public bool ForceContinents;
        /* 0x49 */ public bool HasRings;
        /* 0x4A */ public bool InAbandonedSystem;
        /* 0x4B */ public bool InEmptySystem;
        /* 0x4C */ public bool InPirateSystem;
        /* 0x4D */ public bool Prime;
    }
}

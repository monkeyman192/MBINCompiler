using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA04E0AE29AE48208, NameHash = 0x9B74358B)]
    public class GcSeasonPetConstraints : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureId;
        [NMS(Index = 7)]
        /* 0x10 */ public ulong TimeSinceBirth;
        [NMS(Index = 6)]
        /* 0x18 */ public ulong TimeSinceLastEgg;
        [NMS(Index = 4)]
        /* 0x20 */ public GcBiomeType Biome;
        [NMS(Index = 2)]
        /* 0x24 */ public float MaxRelativeScale;
        [NMS(Index = 1)]
        /* 0x28 */ public float MinRelativeScale;
        [NMS(Index = 5)]
        /* 0x2C */ public float StartingTrust;
        [NMS(Index = 3)]
        /* 0x30 */ public bool SpecificBiome;
    }
}

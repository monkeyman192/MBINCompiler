using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDA422DC68B001D0, NameHash = 0x154E67C8939691E0)]
    public class GcSeasonPetConstraints : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureId;
        /* 0x10 */ public ulong TimeSinceBirth;
        /* 0x18 */ public ulong TimeSinceLastEgg;
        /* 0x20 */ public GcBiomeType Biome;
        /* 0x24 */ public float MaxRelativeScale;
        /* 0x28 */ public float MinRelativeScale;
        /* 0x2C */ public float StartingTrust;
        /* 0x30 */ public bool SpecificBiome;
    }
}

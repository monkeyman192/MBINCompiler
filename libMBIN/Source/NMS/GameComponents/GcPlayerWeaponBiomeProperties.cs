using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEC3738C74AEEF4E, NameHash = 0x4F6E3733)]
    public class GcPlayerWeaponBiomeProperties : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public Colour UpgradeColourOverride;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 MuzzleChargedAnimId;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 MuzzleChargedParticlesId;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 MuzzleFireAnimId;
        [NMS(Index = 5)]
        /* 0x40 */ public NMSString0x10 MuzzleFireParticlesId;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x10 MuzzleIdleAnimId;
        [NMS(Index = 4)]
        /* 0x60 */ public NMSString0x10 MuzzleIdleParticlesId;
        [NMS(Index = 11)]
        /* 0x70 */ public NMSString0x10 Projectile;
        [NMS(Index = 13)]
        /* 0x80 */ public List<GcStatsBonus> StatBonusesOverride;
        [NMS(Index = 9)]
        /* 0x90 */ public NMSString0x10 WeaponChargedAnimId;
        [NMS(Index = 8)]
        /* 0xA0 */ public NMSString0x10 WeaponFireAnimId;
        [NMS(Index = 10)]
        /* 0xB0 */ public NMSString0x10 WeaponFireParticlesId;
        [NMS(Index = 7)]
        /* 0xC0 */ public NMSString0x10 WeaponIdleAnimId;
        [NMS(Index = 0)]
        /* 0xD0 */ public GcBiomeType Biome;
    }
}

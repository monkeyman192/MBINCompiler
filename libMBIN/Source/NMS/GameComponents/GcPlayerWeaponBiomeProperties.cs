using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34B4703360762B2E, NameHash = 0x7F61AD955291D8A9)]
    public class GcPlayerWeaponBiomeProperties : NMSTemplate
    {
        /* 0x00 */ public Colour UpgradeColourOverride;
        /* 0x10 */ public NMSString0x10 MuzzleChargedAnimId;
        /* 0x20 */ public NMSString0x10 MuzzleChargedParticlesId;
        /* 0x30 */ public NMSString0x10 MuzzleFireAnimId;
        /* 0x40 */ public NMSString0x10 MuzzleFireParticlesId;
        /* 0x50 */ public NMSString0x10 MuzzleIdleAnimId;
        /* 0x60 */ public NMSString0x10 MuzzleIdleParticlesId;
        /* 0x70 */ public NMSString0x10 Projectile;
        /* 0x80 */ public List<GcStatsBonus> StatBonusesOverride;
        /* 0x90 */ public NMSString0x10 WeaponChargedAnimId;
        /* 0xA0 */ public NMSString0x10 WeaponFireAnimId;
        /* 0xB0 */ public NMSString0x10 WeaponFireParticlesId;
        /* 0xC0 */ public NMSString0x10 WeaponIdleAnimId;
        /* 0xD0 */ public GcBiomeType Biome;
    }
}

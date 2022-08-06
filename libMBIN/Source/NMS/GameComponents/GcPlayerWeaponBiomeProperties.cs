using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB129C1474D31C711, NameHash = 0x7F61AD955291D8A9)]
    public class GcPlayerWeaponBiomeProperties : NMSTemplate
    {
        /* 0x00 */ public GcBiomeType Biome;
        /* 0x08 */ public NMSString0x10 MuzzleIdleAnimId;
        /* 0x18 */ public NMSString0x10 MuzzleFireAnimId;
        /* 0x28 */ public NMSString0x10 MuzzleChargedAnimId;
        /* 0x38 */ public NMSString0x10 MuzzleIdleParticlesId;
        /* 0x48 */ public NMSString0x10 MuzzleFireParticlesId;
        /* 0x58 */ public NMSString0x10 MuzzleChargedParticlesId;
        /* 0x68 */ public NMSString0x10 WeaponIdleAnimId;
        /* 0x78 */ public NMSString0x10 WeaponFireAnimId;
        /* 0x88 */ public NMSString0x10 WeaponChargedAnimId;
        /* 0x98 */ public NMSString0x10 WeaponFireParticlesId;
        /* 0xA8 */ public NMSString0x10 Projectile;
        /* 0xC0 */ public Colour UpgradeColourOverride;
        /* 0xD0 */ public List<GcStatsTypes> StatBonusesOverride;
    }
}

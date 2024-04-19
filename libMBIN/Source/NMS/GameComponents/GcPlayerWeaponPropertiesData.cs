using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2C55398729E2B73, NameHash = 0xD0F82AE353636444)]
    public class GcPlayerWeaponPropertiesData : NMSTemplate
    {
        /* 0x000 */ public Colour DefaultMuzzleLightColour;
        /* 0x010 */ public List<GcPlayerWeaponBiomeProperties> BiomeProperties;
        /* 0x020 */ public NMSString0x10 DefaultMuzzleChargedAnimId;
        /* 0x030 */ public NMSString0x10 DefaultMuzzleChargedParticlesId;
        /* 0x040 */ public NMSString0x10 DefaultMuzzleFireAnimId;
        /* 0x050 */ public NMSString0x10 DefaultMuzzleFireParticlesId;
        /* 0x060 */ public NMSString0x10 DefaultMuzzleIdleAnimId;
        /* 0x070 */ public NMSString0x10 DefaultMuzzleIdleParticlesId;
        /* 0x080 */ public NMSString0x10 DefaultProjectile;
        /* 0x090 */ public NMSString0x10 DefaultWeaponChargedAnimId;
        /* 0x0A0 */ public NMSString0x10 DefaultWeaponFireAnimId;
        /* 0x0B0 */ public NMSString0x10 DefaultWeaponFireParticlesId;
        /* 0x0C0 */ public NMSString0x10 DefaultWeaponIdleAnimId;
        /* 0x0D0 */ public NMSString0x10 ShakeId;
        /* 0x0E0 */ public NMSString0x10 VibartionId;
        /* 0x0F0 */ public float ChargingMuzzleFlashMaxScale;
        /* 0x0F4 */ public float ChargingMuzzleFlashMinScale;
        /* 0x0F8 */ public float MuzzleFlashScale;
        /* 0x0FC */ public float MuzzleLightIntensity;
        /* 0x100 */ public float ParticlesOffsetMultiplier;
        /* 0x104 */ public GcRemoteWeapons RemoteType;
        /* 0x108 */ public float RumbleScale;
        /* 0x10C */ public GcStatsTypes Stat;
        /* 0x110 */ public float VibrationScale;
        /* 0x114 */ public GcPlayerWeaponClass WeaponClass;
        /* 0x118 */ public NMSString0x80 MuzzleGunResource;
        /* 0x198 */ public NMSString0x80 MuzzleLaserResource;
        /* 0x218 */ public bool FlashMuzzleOnProjectileFire;
        /* 0x219 */ public bool MuzzleLightUsesLaserColour;
        /* 0x21A */ public bool MuzzleLightUsesMuzzleColour;
        /* 0x21B */ public bool UseMuzzleLight;
        /* 0x21C */ public bool UsesCustomBiomeAnims;
        /* 0x21D */ public bool UsesCustomBiomeColour;
        /* 0x21E */ public bool UsesCustomBiomeFireAnims;
        /* 0x21F */ public bool UsesCustomBiomeFireParticles;
        /* 0x220 */ public bool UsesCustomBiomeMuzzleParticles;
        /* 0x221 */ public bool UsesCustomBiomeProjectile;
        /* 0x222 */ public bool UsesCustomBiomeStats;
    }
}

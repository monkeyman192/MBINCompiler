using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73608DA2838CD2E7, NameHash = 0xD0F82AE353636444)]
    public class GcPlayerWeaponPropertiesData : NMSTemplate
    {
        // size: 0x9
        public enum WeaponClassEnum { None, Projectile, ChargedProjectile, Laser, Grenade, Utility, TerrainEditor,
            Spawner, SpawnerAlt
        }
        /* 0x000 */ public WeaponClassEnum WeaponClass;
        /* 0x004 */ public GcStatsTypes Stat;
        /* 0x008 */ public GcRemoteWeapons RemoteType;
        /* 0x00C */ public NMSString0x80 MuzzleLaserResource;
        /* 0x08C */ public NMSString0x80 MuzzleGunResource;
        /* 0x110 */ public NMSString0x10 DefaultProjectile;
        /* 0x120 */ public NMSString0x10 DefaultMuzzleIdleAnimId;
        /* 0x130 */ public NMSString0x10 DefaultMuzzleFireAnimId;
        /* 0x140 */ public NMSString0x10 DefaultMuzzleChargedAnimId;
        /* 0x150 */ public NMSString0x10 DefaultMuzzleIdleParticlesId;
        /* 0x160 */ public NMSString0x10 DefaultMuzzleFireParticlesId;
        /* 0x170 */ public NMSString0x10 DefaultMuzzleChargedParticlesId;
        /* 0x180 */ public NMSString0x10 DefaultWeaponIdleAnimId;
        /* 0x190 */ public NMSString0x10 DefaultWeaponFireAnimId;
        /* 0x1A0 */ public NMSString0x10 DefaultWeaponChargedAnimId;
        /* 0x1B0 */ public NMSString0x10 DefaultWeaponFireParticlesId;
        /* 0x1C0 */ public float MuzzleFlashScale;
        /* 0x1C4 */ public float ChargingMuzzleFlashMinScale;
        /* 0x1C8 */ public float ChargingMuzzleFlashMaxScale;
        /* 0x1CC */ public float VibrationScale;
        /* 0x1D0 */ public float RumbleScale;
        /* 0x1D4 */ public float ParticlesOffsetMultiplier;
        /* 0x1D8 */ public NMSString0x10 VibartionId;
        /* 0x1E8 */ public NMSString0x10 ShakeId;
        /* 0x1F8 */ public bool UseMuzzleLight;
        /* 0x1F9 */ public bool MuzzleLightUsesLaserColour;
        /* 0x1FA */ public bool MuzzleLightUsesMuzzleColour;
        /* 0x200 */ public Colour DefaultMuzzleLightColour;
        /* 0x210 */ public float MuzzleLightIntensity;
        /* 0x214 */ public bool FlashMuzzleOnProjectileFire;
        /* 0x215 */ public bool UsesCustomBiomeAnims;
        /* 0x216 */ public bool UsesCustomBiomeMuzzleParticles;
        /* 0x217 */ public bool UsesCustomBiomeProjectile;
        /* 0x218 */ public bool UsesCustomBiomeColour;
        /* 0x219 */ public bool UsesCustomBiomeFireAnims;
        /* 0x21A */ public bool UsesCustomBiomeFireParticles;
        /* 0x21B */ public bool UsesCustomBiomeStats;
        /* 0x220 */ public List<GcPlayerWeaponBiomeProperties> BiomeProperties;
    }
}

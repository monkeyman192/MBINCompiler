using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A3D3CB80E0C6CAA, NameHash = 0xD0F82AE353636444)]
    public class GcPlayerWeaponPropertiesData : NMSTemplate
    {
        [NMS(Index = 27)]
        /* 0x000 */ public Colour DefaultMuzzleLightColour;
        [NMS(Index = 37)]
        /* 0x010 */ public List<GcPlayerWeaponBiomeProperties> BiomeProperties;
        [NMS(Index = 8)]
        /* 0x020 */ public NMSString0x10 DefaultMuzzleChargedAnimId;
        [NMS(Index = 11)]
        /* 0x030 */ public NMSString0x10 DefaultMuzzleChargedParticlesId;
        [NMS(Index = 7)]
        /* 0x040 */ public NMSString0x10 DefaultMuzzleFireAnimId;
        [NMS(Index = 10)]
        /* 0x050 */ public NMSString0x10 DefaultMuzzleFireParticlesId;
        [NMS(Index = 6)]
        /* 0x060 */ public NMSString0x10 DefaultMuzzleIdleAnimId;
        [NMS(Index = 9)]
        /* 0x070 */ public NMSString0x10 DefaultMuzzleIdleParticlesId;
        [NMS(Index = 5)]
        /* 0x080 */ public NMSString0x10 DefaultProjectile;
        [NMS(Index = 14)]
        /* 0x090 */ public NMSString0x10 DefaultWeaponChargedAnimId;
        [NMS(Index = 13)]
        /* 0x0A0 */ public NMSString0x10 DefaultWeaponFireAnimId;
        [NMS(Index = 15)]
        /* 0x0B0 */ public NMSString0x10 DefaultWeaponFireParticlesId;
        [NMS(Index = 12)]
        /* 0x0C0 */ public NMSString0x10 DefaultWeaponIdleAnimId;
        [NMS(Index = 23)]
        /* 0x0D0 */ public NMSString0x10 ShakeId;
        [NMS(Index = 22)]
        /* 0x0E0 */ public NMSString0x10 VibartionId;
        [NMS(Index = 18)]
        /* 0x0F0 */ public float ChargingMuzzleFlashMaxScale;
        [NMS(Index = 17)]
        /* 0x0F4 */ public float ChargingMuzzleFlashMinScale;
        [NMS(Index = 16)]
        /* 0x0F8 */ public float MuzzleFlashScale;
        [NMS(Index = 28)]
        /* 0x0FC */ public float MuzzleLightIntensity;
        [NMS(Index = 21)]
        /* 0x100 */ public float ParticlesOffsetMultiplier;
        [NMS(Index = 2)]
        /* 0x104 */ public GcRemoteWeapons RemoteType;
        [NMS(Index = 20)]
        /* 0x108 */ public float RumbleScale;
        [NMS(Index = 1)]
        /* 0x10C */ public GcStatsTypes Stat;
        [NMS(Index = 19)]
        /* 0x110 */ public float VibrationScale;
        [NMS(Index = 0)]
        /* 0x114 */ public GcPlayerWeaponClass WeaponClass;
        [NMS(Index = 4)]
        /* 0x118 */ public NMSString0x80 MuzzleGunResource;
        [NMS(Index = 3)]
        /* 0x198 */ public NMSString0x80 MuzzleLaserResource;
        [NMS(Index = 29)]
        /* 0x218 */ public bool FlashMuzzleOnProjectileFire;
        [NMS(Index = 25)]
        /* 0x219 */ public bool MuzzleLightUsesLaserColour;
        [NMS(Index = 26)]
        /* 0x21A */ public bool MuzzleLightUsesMuzzleColour;
        [NMS(Index = 24)]
        /* 0x21B */ public bool UseMuzzleLight;
        [NMS(Index = 30)]
        /* 0x21C */ public bool UsesCustomBiomeAnims;
        [NMS(Index = 33)]
        /* 0x21D */ public bool UsesCustomBiomeColour;
        [NMS(Index = 34)]
        /* 0x21E */ public bool UsesCustomBiomeFireAnims;
        [NMS(Index = 35)]
        /* 0x21F */ public bool UsesCustomBiomeFireParticles;
        [NMS(Index = 31)]
        /* 0x220 */ public bool UsesCustomBiomeMuzzleParticles;
        [NMS(Index = 32)]
        /* 0x221 */ public bool UsesCustomBiomeProjectile;
        [NMS(Index = 36)]
        /* 0x222 */ public bool UsesCustomBiomeStats;
    }
}

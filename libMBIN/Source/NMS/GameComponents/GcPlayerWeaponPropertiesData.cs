using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41374FF524DCA04D, NameHash = 0x1B0642FA)]
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
        [NMS(Index = 4)]
        /* 0x0D0 */ public VariableSizeString MuzzleGunResource;
        [NMS(Index = 3)]
        /* 0x0E0 */ public VariableSizeString MuzzleLaserResource;
        [NMS(Index = 23)]
        /* 0x0F0 */ public NMSString0x10 ShakeId;
        [NMS(Index = 22)]
        /* 0x100 */ public NMSString0x10 VibartionId;
        [NMS(Index = 18)]
        /* 0x110 */ public float ChargingMuzzleFlashMaxScale;
        [NMS(Index = 17)]
        /* 0x114 */ public float ChargingMuzzleFlashMinScale;
        [NMS(Index = 16)]
        /* 0x118 */ public float MuzzleFlashScale;
        [NMS(Index = 28)]
        /* 0x11C */ public float MuzzleLightIntensity;
        [NMS(Index = 21)]
        /* 0x120 */ public float ParticlesOffsetMultiplier;
        [NMS(Index = 2)]
        /* 0x124 */ public GcRemoteWeapons RemoteType;
        [NMS(Index = 20)]
        /* 0x128 */ public float RumbleScale;
        [NMS(Index = 1)]
        /* 0x12C */ public GcStatsTypes Stat;
        [NMS(Index = 19)]
        /* 0x130 */ public float VibrationScale;
        [NMS(Index = 0)]
        /* 0x134 */ public GcPlayerWeaponClass WeaponClass;
        [NMS(Index = 29)]
        /* 0x138 */ public bool FlashMuzzleOnProjectileFire;
        [NMS(Index = 25)]
        /* 0x139 */ public bool MuzzleLightUsesLaserColour;
        [NMS(Index = 26)]
        /* 0x13A */ public bool MuzzleLightUsesMuzzleColour;
        [NMS(Index = 24)]
        /* 0x13B */ public bool UseMuzzleLight;
        [NMS(Index = 30)]
        /* 0x13C */ public bool UsesCustomBiomeAnims;
        [NMS(Index = 33)]
        /* 0x13D */ public bool UsesCustomBiomeColour;
        [NMS(Index = 34)]
        /* 0x13E */ public bool UsesCustomBiomeFireAnims;
        [NMS(Index = 35)]
        /* 0x13F */ public bool UsesCustomBiomeFireParticles;
        [NMS(Index = 31)]
        /* 0x140 */ public bool UsesCustomBiomeMuzzleParticles;
        [NMS(Index = 32)]
        /* 0x141 */ public bool UsesCustomBiomeProjectile;
        [NMS(Index = 36)]
        /* 0x142 */ public bool UsesCustomBiomeStats;
    }
}

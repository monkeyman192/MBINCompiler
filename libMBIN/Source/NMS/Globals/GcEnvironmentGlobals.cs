using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x83753B9514A0E9EE, NameHash = 0x1E09DD001FDA82F8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcCloudProperties CloudProperties;
        [NMS(Index = 94)]
        /* 0x0D0 */ public Colour IndoorAmbientColour;
        [NMS(Index = 91)]
        /* 0x0E0 */ public List<float> FarBlendHeight;
        [NMS(Index = 104)]
        /* 0x0F0 */ public List<TkShearWindData> ShearWindSettings;
        [NMS(Index = 90)]
        /* 0x100 */ public List<float> SkyAtmosphereBlendLength;
        [NMS(Index = 88)]
        /* 0x110 */ public List<float> SkyBlendLength;
        [NMS(Index = 87)]
        /* 0x120 */ public List<float> SpacePlanetFogStrength;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x130 */ public TkLODSettingsData[] LODSettings;
        [NMS(Index = 111)]
        /* 0x380 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
        [NMS(Index = 110)]
        /* 0x3F8 */ public GcEnvironmentProperties EnvironmentProperties;
        [NMS(Index = 34)]
        /* 0x470 */ public Vector2f ExposureHeightBracket;
        [NMS(Index = 1)]
        /* 0x478 */ public Vector2f SpaceBuildingTemperature;
        [NMS(Index = 38)]
        /* 0x480 */ public float AbandonedFreighterMaxTemperature;
        [NMS(Index = 37)]
        /* 0x484 */ public float AbandonedFreighterMinTemperature;
        [NMS(Index = 81)]
        /* 0x488 */ public float AsteroidFadeHeightMax;
        [NMS(Index = 80)]
        /* 0x48C */ public float AsteroidFadeHeightMin;
        [NMS(Index = 27)]
        /* 0x490 */ public float AsteroidFieldStableEnterTime;
        [NMS(Index = 28)]
        /* 0x494 */ public float AsteroidFieldStableLeaveTime;
        [NMS(Index = 85)]
        /* 0x498 */ public float AsteroidMaxRotate;
        [NMS(Index = 84)]
        /* 0x49C */ public float AsteroidMinRotate;
        [NMS(Index = 82)]
        /* 0x4A0 */ public float AsteroidScale;
        [NMS(Index = 56)]
        /* 0x4A4 */ public float AtmosphereSpaceRadius;
        [NMS(Index = 26)]
        /* 0x4A8 */ public float CameraLocationStableTime;
        [NMS(Index = 60)]
        /* 0x4AC */ public float CreatureFadeTime;
        [NMS(Index = 35)]
        /* 0x4B0 */ public float DailyTempChangePercent;
        [NMS(Index = 20)]
        /* 0x4B4 */ public float DistortionStep;
        [NMS(Index = 72)]
        /* 0x4B8 */ public float DoFHeightMax;
        [NMS(Index = 71)]
        /* 0x4BC */ public float DoFHeightMin;
        [NMS(Index = 45)]
        /* 0x4C0 */ public float DuplicateColourThreshold;
        [NMS(Index = 33)]
        /* 0x4C4 */ public float ExposureGroundFactorAddMul;
        [NMS(Index = 31)]
        /* 0x4C8 */ public float ExposureSurfaceContrib;
        [NMS(Index = 32)]
        /* 0x4CC */ public float ExposureSurfaceDistMax;
        [NMS(Index = 92)]
        /* 0x4D0 */ public float FarBlendLength;
        [NMS(Index = 62)]
        /* 0x4D4 */ public float FloraFadeTimeMax;
        [NMS(Index = 61)]
        /* 0x4D8 */ public float FloraFadeTimeMin;
        [NMS(Index = 50)]
        /* 0x4DC */ public float GrassNormalMap;
        [NMS(Index = 48)]
        /* 0x4E0 */ public float GrassNormalOffset;
        [NMS(Index = 49)]
        /* 0x4E4 */ public float GrassNormalSpherify;
        [NMS(Index = 47)]
        /* 0x4E8 */ public float GrassNormalUpright;
        [NMS(Index = 21)]
        /* 0x4EC */ public float HDeform;
        [NMS(Index = 75)]
        /* 0x4F0 */ public float HeavyAirFadeDistance;
        [NMS(Index = 76)]
        /* 0x4F4 */ public float HeavyAirFadeInTime;
        [NMS(Index = 77)]
        /* 0x4F8 */ public float HeavyAirFadeOutTime;
        [NMS(Index = 67)]
        /* 0x4FC */ public float HeightFogHeightMin;
        [NMS(Index = 105)]
        /* 0x500 */ public int HotspotsLOD;
        [NMS(Index = 93)]
        /* 0x504 */ public float IndoorColourBlendTime;
        [NMS(Index = 13)]
        /* 0x508 */ public float IndoorsLightingAbandonedFreighterMax;
        [NMS(Index = 15)]
        /* 0x50C */ public float IndoorsLightingFreighterMax;
        [NMS(Index = 14)]
        /* 0x510 */ public float IndoorsLightingNexusMax;
        [NMS(Index = 12)]
        /* 0x514 */ public float IndoorsLightingPlanetMax;
        [NMS(Index = 11)]
        /* 0x518 */ public float IndoorsLightingThreshold;
        [NMS(Index = 10)]
        /* 0x51C */ public float IndoorsLightingTransitionTime;
        [NMS(Index = 6)]
        /* 0x520 */ public float IndoorsLightingWeightAround;
        [NMS(Index = 9)]
        /* 0x524 */ public float IndoorsLightingWeightGround;
        [NMS(Index = 7)]
        /* 0x528 */ public float IndoorsLightingWeightOverhead;
        [NMS(Index = 8)]
        /* 0x52C */ public float IndoorsLightingWeightTowardsSun;
        [NMS(Index = 102)]
        /* 0x530 */ public float InteractionRadius;
        [NMS(Index = 25)]
        /* 0x534 */ public float InterestStableTime;
        [NMS(Index = 98)]
        /* 0x538 */ public float LightColourBlend;
        [NMS(Index = 97)]
        /* 0x53C */ public float LightColourHeight;
        [NMS(Index = 96)]
        /* 0x540 */ public float LightDirectionBlend;
        [NMS(Index = 95)]
        /* 0x544 */ public float LightDirectionHeight;
        [NMS(Index = 24)]
        /* 0x548 */ public float LocationStableTime;
        [NMS(Index = 16)]
        /* 0x54C */ public float MaxElevation;
        [NMS(Index = 109)]
        /* 0x550 */ public float MaxHotspotFalloffDistance;
        [NMS(Index = 107)]
        /* 0x554 */ public float MaxHotspotOffsetDistance;
        [NMS(Index = 53)]
        /* 0x558 */ public float MaxPlacementBlendValuePatch;
        [NMS(Index = 108)]
        /* 0x55C */ public float MinHotspotFalloffDistance;
        [NMS(Index = 51)]
        /* 0x560 */ public float MinPlacementBlendValue;
        [NMS(Index = 52)]
        /* 0x564 */ public float MinPlacementBlendValuePatch;
        [NMS(Index = 54)]
        /* 0x568 */ public float MinPlacementObjectScale;
        [NMS(Index = 86)]
        /* 0x56C */ public float MinWaterReflections;
        [NMS(Index = 101)]
        /* 0x570 */ public float ObjectSpawnDetailRadius;
        [NMS(Index = 100)]
        /* 0x574 */ public float ObjectSpawnFirstDotCheck;
        [NMS(Index = 99)]
        /* 0x578 */ public float ObjectSpawnFirstRadius;
        [NMS(Index = 79)]
        /* 0x57C */ public float PlanetEffectEndDistance;
        [NMS(Index = 78)]
        /* 0x580 */ public float PlanetFlipDistance;
        [NMS(Index = 64)]
        /* 0x584 */ public float PlanetUnwrapMax;
        [NMS(Index = 63)]
        /* 0x588 */ public float PlanetUnwrapMin;
        [NMS(Index = 106)]
        /* 0x58C */ public float RegionHotspotProbability;
        [NMS(Index = 22)]
        /* 0x590 */ public float SDeform;
        [NMS(Index = 3)]
        /* 0x594 */ public float SenseProbingValueSmoothingTime;
        [NMS(Index = 4)]
        /* 0x598 */ public float SenseProbingValueSmoothingTimeMed;
        [NMS(Index = 5)]
        /* 0x59C */ public float SenseProbingValueSmoothingTimeSlow;
        [NMS(Index = 41)]
        /* 0x5A0 */ public float ShipRadiation;
        [NMS(Index = 39)]
        /* 0x5A4 */ public float ShipTemperature;
        [NMS(Index = 43)]
        /* 0x5A8 */ public float ShipToxicity;
        [NMS(Index = 89)]
        /* 0x5AC */ public float SkyAtmospherePower;
        [NMS(Index = 83)]
        /* 0x5B0 */ public float SmallAsteroidScale;
        [NMS(Index = 40)]
        /* 0x5B4 */ public float SpaceRadiation;
        [NMS(Index = 55)]
        /* 0x5B8 */ public float SpaceStationStateBoundingBoxScaler;
        [NMS(Index = 36)]
        /* 0x5BC */ public float SpaceTemperature;
        [NMS(Index = 42)]
        /* 0x5C0 */ public float SpaceToxicity;
        [NMS(Index = 57)]
        /* 0x5C4 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        [NMS(Index = 17)]
        /* 0x5C8 */ public float SphereLodTextureScale;
        [NMS(Index = 74)]
        /* 0x5CC */ public float SunClampHeightMax;
        [NMS(Index = 73)]
        /* 0x5D0 */ public float SunClampHeightMin;
        [NMS(Index = 30)]
        /* 0x5D4 */ public float SunFactorMin;
        // size: 0x3
        public enum SwitchTypeEnum : uint {
            None,
            Debug,
            Enabled,
        }
        [NMS(Index = 46)]
        /* 0x5D8 */ public SwitchTypeEnum SwitchType;
        [NMS(Index = 29)]
        /* 0x5DC */ public float TemperatureSmoothTime;
        [NMS(Index = 58)]
        /* 0x5E0 */ public float TerrainFadeTime;
        [NMS(Index = 59)]
        /* 0x5E4 */ public float TerrainFadeTimeInShip;
        [NMS(Index = 66)]
        /* 0x5E8 */ public float TerrainFlattenMax;
        [NMS(Index = 65)]
        /* 0x5EC */ public float TerrainFlattenMin;
        [NMS(Index = 23)]
        /* 0x5F0 */ public float VDeform;
        [NMS(Index = 70)]
        /* 0x5F4 */ public float WaterAlphaHeightMax;
        [NMS(Index = 69)]
        /* 0x5F8 */ public float WaterAlphaHeightMin;
        [NMS(Index = 68)]
        /* 0x5FC */ public float WaterFogHeightMax;
        [NMS(Index = 103)]
        /* 0x600 */ public bool EnableWind;
        [NMS(Index = 19)]
        /* 0x601 */ public bool ForceAddCaveProps;
        [NMS(Index = 18)]
        /* 0x602 */ public bool ForceAddUnderwaterProps;
        [NMS(Index = 44)]
        /* 0x603 */ public bool MatchPlantPalettes;
    }
}

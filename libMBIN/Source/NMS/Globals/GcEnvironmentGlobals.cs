using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA457A91A93C1E343, NameHash = 0x5EAFF93E)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcCloudProperties CloudProperties;
        [NMS(Index = 115)]
        /* 0x0E0 */ public Colour IndoorAmbientColour;
        [NMS(Index = 27)]
        /* 0x0F0 */ public Colour IndoorsLightingFactorFreighterAbandoned;
        [NMS(Index = 25)]
        /* 0x100 */ public Colour IndoorsLightingFactorPlanet;
        [NMS(Index = 26)]
        /* 0x110 */ public Colour IndoorsLightingFactorSpaceStation;
        [NMS(Index = 29)]
        /* 0x120 */ public Colour IndoorsLightingFactorSpaceStationAbandoned;
        [NMS(Index = 28)]
        /* 0x130 */ public Colour IndoorsLightingFactorSpaceStationPirate;
        [NMS(Index = 112)]
        /* 0x140 */ public List<float> FarBlendHeight;
        [NMS(Index = 126)]
        /* 0x150 */ public List<TkShearWindData> ShearWindSettings;
        [NMS(Index = 111)]
        /* 0x160 */ public List<float> SkyAtmosphereBlendLength;
        [NMS(Index = 109)]
        /* 0x170 */ public List<float> SkyBlendLength;
        [NMS(Index = 108)]
        /* 0x180 */ public List<float> SpacePlanetFogStrength;
        // size: 0x4
        public enum LODSettingsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(LODSettingsEnum))]
        /* 0x190 */ public TkLODSettingsData[] LODSettings;
        [NMS(Index = 134)]
        /* 0x3C0 */ public GcEnvironmentProperties EnvironmentGasGiantProperties;
        [NMS(Index = 133)]
        /* 0x43C */ public GcEnvironmentProperties EnvironmentPrimeProperties;
        [NMS(Index = 132)]
        /* 0x4B8 */ public GcEnvironmentProperties EnvironmentProperties;
        [NMS(Index = 125)]
        /* 0x534 */ public TkDynamicTreeWindFrequency DynamicTreeWindFrequency;
        [NMS(Index = 48)]
        /* 0x554 */ public Vector2f ExposureHeightBracket;
        [NMS(Index = 1)]
        /* 0x55C */ public Vector2f SpaceBuildingTemperature;
        [NMS(Index = 52)]
        /* 0x564 */ public float AbandonedFreighterMaxTemperature;
        [NMS(Index = 51)]
        /* 0x568 */ public float AbandonedFreighterMinTemperature;
        [NMS(Index = 102)]
        /* 0x56C */ public float AsteroidFadeHeightMax;
        [NMS(Index = 101)]
        /* 0x570 */ public float AsteroidFadeHeightMin;
        [NMS(Index = 41)]
        /* 0x574 */ public float AsteroidFieldStableEnterTime;
        [NMS(Index = 42)]
        /* 0x578 */ public float AsteroidFieldStableLeaveTime;
        [NMS(Index = 106)]
        /* 0x57C */ public float AsteroidMaxRotate;
        [NMS(Index = 105)]
        /* 0x580 */ public float AsteroidMinRotate;
        [NMS(Index = 103)]
        /* 0x584 */ public float AsteroidScale;
        [NMS(Index = 72)]
        /* 0x588 */ public float AtmosphereSpaceRadius;
        [NMS(Index = 40)]
        /* 0x58C */ public float CameraLocationStableTime;
        [NMS(Index = 76)]
        /* 0x590 */ public float CreatureFadeTime;
        [NMS(Index = 49)]
        /* 0x594 */ public float DailyTempChangePercent;
        [NMS(Index = 95)]
        /* 0x598 */ public float DeepWaterDepthTransitionMax;
        [NMS(Index = 94)]
        /* 0x59C */ public float DeepWaterDepthTransitionMin;
        [NMS(Index = 96)]
        /* 0x5A0 */ public float DeepWaterOxygenMultiplier;
        [NMS(Index = 34)]
        /* 0x5A4 */ public float DistortionStep;
        [NMS(Index = 88)]
        /* 0x5A8 */ public float DoFHeightMax;
        [NMS(Index = 87)]
        /* 0x5AC */ public float DoFHeightMin;
        [NMS(Index = 61)]
        /* 0x5B0 */ public float DuplicateColourThreshold;
        [NMS(Index = 47)]
        /* 0x5B4 */ public float ExposureGroundFactorAddMul;
        [NMS(Index = 45)]
        /* 0x5B8 */ public float ExposureSurfaceContrib;
        [NMS(Index = 46)]
        /* 0x5BC */ public float ExposureSurfaceDistMax;
        [NMS(Index = 113)]
        /* 0x5C0 */ public float FarBlendLength;
        [NMS(Index = 78)]
        /* 0x5C4 */ public float FloraFadeTimeMax;
        [NMS(Index = 77)]
        /* 0x5C8 */ public float FloraFadeTimeMin;
        [NMS(Index = 66)]
        /* 0x5CC */ public float GrassNormalMap;
        [NMS(Index = 64)]
        /* 0x5D0 */ public float GrassNormalOffset;
        [NMS(Index = 65)]
        /* 0x5D4 */ public float GrassNormalSpherify;
        [NMS(Index = 63)]
        /* 0x5D8 */ public float GrassNormalUpright;
        [NMS(Index = 35)]
        /* 0x5DC */ public float HDeform;
        [NMS(Index = 91)]
        /* 0x5E0 */ public float HeavyAirFadeDistance;
        [NMS(Index = 92)]
        /* 0x5E4 */ public float HeavyAirFadeInTime;
        [NMS(Index = 93)]
        /* 0x5E8 */ public float HeavyAirFadeOutTime;
        [NMS(Index = 83)]
        /* 0x5EC */ public float HeightFogHeightMin;
        [NMS(Index = 127)]
        /* 0x5F0 */ public int HotspotsLOD;
        [NMS(Index = 137)]
        /* 0x5F4 */ public float IblUndergroundFadeSpeed;
        [NMS(Index = 136)]
        /* 0x5F8 */ public float IblUndergroundLightDirectionHorizonBias;
        [NMS(Index = 135)]
        /* 0x5FC */ public float IblUndergroundLightIntensity;
        [NMS(Index = 114)]
        /* 0x600 */ public float IndoorColourBlendTime;
        [NMS(Index = 19)]
        /* 0x604 */ public float IndoorsLightingAbandonedFreighterMax;
        [NMS(Index = 21)]
        /* 0x608 */ public float IndoorsLightingFreighterMax;
        [NMS(Index = 20)]
        /* 0x60C */ public float IndoorsLightingNexusMax;
        [NMS(Index = 18)]
        /* 0x610 */ public float IndoorsLightingPlanetMax;
        [NMS(Index = 24)]
        /* 0x614 */ public float IndoorsLightingSpaceStationAbandonedMax;
        [NMS(Index = 22)]
        /* 0x618 */ public float IndoorsLightingSpaceStationMax;
        [NMS(Index = 23)]
        /* 0x61C */ public float IndoorsLightingSpaceStationPirateMax;
        [NMS(Index = 17)]
        /* 0x620 */ public float IndoorsLightingThreshold;
        [NMS(Index = 16)]
        /* 0x624 */ public float IndoorsLightingTransitionTime;
        [NMS(Index = 12)]
        /* 0x628 */ public float IndoorsLightingWeightAround;
        [NMS(Index = 15)]
        /* 0x62C */ public float IndoorsLightingWeightGround;
        [NMS(Index = 13)]
        /* 0x630 */ public float IndoorsLightingWeightOverhead;
        [NMS(Index = 14)]
        /* 0x634 */ public float IndoorsLightingWeightTowardsSun;
        [NMS(Index = 123)]
        /* 0x638 */ public float InteractionRadius;
        [NMS(Index = 39)]
        /* 0x63C */ public float InterestStableTime;
        [NMS(Index = 119)]
        /* 0x640 */ public float LightColourBlend;
        [NMS(Index = 118)]
        /* 0x644 */ public float LightColourHeight;
        [NMS(Index = 117)]
        /* 0x648 */ public float LightDirectionBlend;
        [NMS(Index = 116)]
        /* 0x64C */ public float LightDirectionHeight;
        [NMS(Index = 38)]
        /* 0x650 */ public float LocationStableTime;
        [NMS(Index = 30)]
        /* 0x654 */ public float MaxElevation;
        [NMS(Index = 131)]
        /* 0x658 */ public float MaxHotspotFalloffDistance;
        [NMS(Index = 129)]
        /* 0x65C */ public float MaxHotspotOffsetDistance;
        [NMS(Index = 4)]
        /* 0x660 */ public float MaxMurkVarianceOverTime;
        [NMS(Index = 69)]
        /* 0x664 */ public float MaxPlacementBlendValuePatch;
        [NMS(Index = 130)]
        /* 0x668 */ public float MinHotspotFalloffDistance;
        [NMS(Index = 67)]
        /* 0x66C */ public float MinPlacementBlendValue;
        [NMS(Index = 68)]
        /* 0x670 */ public float MinPlacementBlendValuePatch;
        [NMS(Index = 70)]
        /* 0x674 */ public float MinPlacementObjectScale;
        [NMS(Index = 107)]
        /* 0x678 */ public float MinWaterReflections;
        [NMS(Index = 122)]
        /* 0x67C */ public float ObjectSpawnDetailRadius;
        [NMS(Index = 121)]
        /* 0x680 */ public float ObjectSpawnFirstDotCheck;
        [NMS(Index = 120)]
        /* 0x684 */ public float ObjectSpawnFirstRadius;
        [NMS(Index = 98)]
        /* 0x688 */ public float PlanetEffectEndDistance;
        [NMS(Index = 97)]
        /* 0x68C */ public float PlanetFlipDistance;
        [NMS(Index = 80)]
        /* 0x690 */ public float PlanetUnwrapMax;
        [NMS(Index = 79)]
        /* 0x694 */ public float PlanetUnwrapMin;
        [NMS(Index = 138)]
        /* 0x698 */ public float ProbeBlendRadiusEdge;
        [NMS(Index = 128)]
        /* 0x69C */ public float RegionHotspotProbability;
        [NMS(Index = 36)]
        /* 0x6A0 */ public float SDeform;
        [NMS(Index = 9)]
        /* 0x6A4 */ public float SenseProbingValueSmoothingTime;
        [NMS(Index = 10)]
        /* 0x6A8 */ public float SenseProbingValueSmoothingTimeMed;
        [NMS(Index = 11)]
        /* 0x6AC */ public float SenseProbingValueSmoothingTimeSlow;
        [NMS(Index = 55)]
        /* 0x6B0 */ public float ShipRadiation;
        [NMS(Index = 59)]
        /* 0x6B4 */ public float ShipSpookLevel;
        [NMS(Index = 53)]
        /* 0x6B8 */ public float ShipTemperature;
        [NMS(Index = 57)]
        /* 0x6BC */ public float ShipToxicity;
        [NMS(Index = 110)]
        /* 0x6C0 */ public float SkyAtmospherePower;
        [NMS(Index = 104)]
        /* 0x6C4 */ public float SmallAsteroidScale;
        [NMS(Index = 54)]
        /* 0x6C8 */ public float SpaceRadiation;
        [NMS(Index = 58)]
        /* 0x6CC */ public float SpaceSpookLevel;
        [NMS(Index = 71)]
        /* 0x6D0 */ public float SpaceStationStateBoundingBoxScaler;
        [NMS(Index = 50)]
        /* 0x6D4 */ public float SpaceTemperature;
        [NMS(Index = 56)]
        /* 0x6D8 */ public float SpaceToxicity;
        [NMS(Index = 73)]
        /* 0x6DC */ public float SpawnLowerAtmosphereRadiusMultiplier;
        [NMS(Index = 31)]
        /* 0x6E0 */ public float SphereLodTextureScale;
        [NMS(Index = 139)]
        /* 0x6E4 */ public float StandardNearProbeRadius;
        [NMS(Index = 90)]
        /* 0x6E8 */ public float SunClampHeightMax;
        [NMS(Index = 89)]
        /* 0x6EC */ public float SunClampHeightMin;
        [NMS(Index = 44)]
        /* 0x6F0 */ public float SunFactorMin;
        // size: 0x3
        public enum SwitchTypeEnum : uint {
            None,
            Debug,
            Enabled,
        }
        [NMS(Index = 62)]
        /* 0x6F4 */ public SwitchTypeEnum SwitchType;
        [NMS(Index = 43)]
        /* 0x6F8 */ public float TemperatureSmoothTime;
        [NMS(Index = 74)]
        /* 0x6FC */ public float TerrainFadeTime;
        [NMS(Index = 75)]
        /* 0x700 */ public float TerrainFadeTimeInShip;
        [NMS(Index = 82)]
        /* 0x704 */ public float TerrainFlattenMax;
        [NMS(Index = 81)]
        /* 0x708 */ public float TerrainFlattenMin;
        [NMS(Index = 141)]
        /* 0x70C */ public float UndergroundFakeSkyFactor;
        [NMS(Index = 140)]
        /* 0x710 */ public float UndergroundNearProbeRadius;
        [NMS(Index = 37)]
        /* 0x714 */ public float VDeform;
        [NMS(Index = 99)]
        /* 0x718 */ public float VolumetricCloudFadeInDistance;
        [NMS(Index = 100)]
        /* 0x71C */ public float VolumetricCloudFadeRange;
        [NMS(Index = 86)]
        /* 0x720 */ public float WaterAlphaHeightMax;
        [NMS(Index = 85)]
        /* 0x724 */ public float WaterAlphaHeightMin;
        [NMS(Index = 6)]
        /* 0x728 */ public int WaterChangeTime;
        [NMS(Index = 7)]
        /* 0x72C */ public float WaterConditionTransitionTime;
        [NMS(Index = 84)]
        /* 0x730 */ public float WaterFogHeightMax;
        [NMS(Index = 3)]
        /* 0x734 */ public float WaterMurkMaxPlayerDepth;
        [NMS(Index = 2)]
        /* 0x738 */ public float WaterMurkMinPlayerDepth;
        [NMS(Index = 5)]
        /* 0x73C */ public float WaterMurkVariancePeriod;
        [NMS(Index = 124)]
        /* 0x740 */ public bool EnableWind;
        [NMS(Index = 33)]
        /* 0x741 */ public bool ForceAddCaveProps;
        [NMS(Index = 32)]
        /* 0x742 */ public bool ForceAddUnderwaterProps;
        [NMS(Index = 60)]
        /* 0x743 */ public bool MatchPlantPalettes;
    }
}

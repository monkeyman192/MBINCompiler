using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x83753B9514A0E9EE, NameHash = 0x1E09DD001FDA82F8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        /* 0x000 */ public GcCloudProperties CloudProperties;
        /* 0x0D0 */ public Colour IndoorAmbientColour;
        /* 0x0E0 */ public List<float> FarBlendHeight;
        /* 0x0F0 */ public List<TkShearWindData> ShearWindSettings;
        /* 0x100 */ public List<float> SkyAtmosphereBlendLength;
        /* 0x110 */ public List<float> SkyBlendLength;
        /* 0x120 */ public List<float> SpacePlanetFogStrength;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x130 */ public TkLODSettingsData[] LODSettings;
        /* 0x380 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
        /* 0x3F8 */ public GcEnvironmentProperties EnvironmentProperties;
        /* 0x470 */ public Vector2f ExposureHeightBracket;
        /* 0x478 */ public Vector2f SpaceBuildingTemperature;
        /* 0x480 */ public float AbandonedFreighterMaxTemperature;
        /* 0x484 */ public float AbandonedFreighterMinTemperature;
        /* 0x488 */ public float AsteroidFadeHeightMax;
        /* 0x48C */ public float AsteroidFadeHeightMin;
        /* 0x490 */ public float AsteroidFieldStableEnterTime;
        /* 0x494 */ public float AsteroidFieldStableLeaveTime;
        /* 0x498 */ public float AsteroidMaxRotate;
        /* 0x49C */ public float AsteroidMinRotate;
        /* 0x4A0 */ public float AsteroidScale;
        /* 0x4A4 */ public float AtmosphereSpaceRadius;
        /* 0x4A8 */ public float CameraLocationStableTime;
        /* 0x4AC */ public float CreatureFadeTime;
        /* 0x4B0 */ public float DailyTempChangePercent;
        /* 0x4B4 */ public float DistortionStep;
        /* 0x4B8 */ public float DoFHeightMax;
        /* 0x4BC */ public float DoFHeightMin;
        /* 0x4C0 */ public float DuplicateColourThreshold;
        /* 0x4C4 */ public float ExposureGroundFactorAddMul;
        /* 0x4C8 */ public float ExposureSurfaceContrib;
        /* 0x4CC */ public float ExposureSurfaceDistMax;
        /* 0x4D0 */ public float FarBlendLength;
        /* 0x4D4 */ public float FloraFadeTimeMax;
        /* 0x4D8 */ public float FloraFadeTimeMin;
        /* 0x4DC */ public float GrassNormalMap;
        /* 0x4E0 */ public float GrassNormalOffset;
        /* 0x4E4 */ public float GrassNormalSpherify;
        /* 0x4E8 */ public float GrassNormalUpright;
        /* 0x4EC */ public float HDeform;
        /* 0x4F0 */ public float HeavyAirFadeDistance;
        /* 0x4F4 */ public float HeavyAirFadeInTime;
        /* 0x4F8 */ public float HeavyAirFadeOutTime;
        /* 0x4FC */ public float HeightFogHeightMin;
        /* 0x500 */ public int HotspotsLOD;
        /* 0x504 */ public float IndoorColourBlendTime;
        /* 0x508 */ public float IndoorsLightingAbandonedFreighterMax;
        /* 0x50C */ public float IndoorsLightingFreighterMax;
        /* 0x510 */ public float IndoorsLightingNexusMax;
        /* 0x514 */ public float IndoorsLightingPlanetMax;
        /* 0x518 */ public float IndoorsLightingThreshold;
        /* 0x51C */ public float IndoorsLightingTransitionTime;
        /* 0x520 */ public float IndoorsLightingWeightAround;
        /* 0x524 */ public float IndoorsLightingWeightGround;
        /* 0x528 */ public float IndoorsLightingWeightOverhead;
        /* 0x52C */ public float IndoorsLightingWeightTowardsSun;
        /* 0x530 */ public float InteractionRadius;
        /* 0x534 */ public float InterestStableTime;
        /* 0x538 */ public float LightColourBlend;
        /* 0x53C */ public float LightColourHeight;
        /* 0x540 */ public float LightDirectionBlend;
        /* 0x544 */ public float LightDirectionHeight;
        /* 0x548 */ public float LocationStableTime;
        /* 0x54C */ public float MaxElevation;
        /* 0x550 */ public float MaxHotspotFalloffDistance;
        /* 0x554 */ public float MaxHotspotOffsetDistance;
        /* 0x558 */ public float MaxPlacementBlendValuePatch;
        /* 0x55C */ public float MinHotspotFalloffDistance;
        /* 0x560 */ public float MinPlacementBlendValue;
        /* 0x564 */ public float MinPlacementBlendValuePatch;
        /* 0x568 */ public float MinPlacementObjectScale;
        /* 0x56C */ public float MinWaterReflections;
        /* 0x570 */ public float ObjectSpawnDetailRadius;
        /* 0x574 */ public float ObjectSpawnFirstDotCheck;
        /* 0x578 */ public float ObjectSpawnFirstRadius;
        /* 0x57C */ public float PlanetEffectEndDistance;
        /* 0x580 */ public float PlanetFlipDistance;
        /* 0x584 */ public float PlanetUnwrapMax;
        /* 0x588 */ public float PlanetUnwrapMin;
        /* 0x58C */ public float RegionHotspotProbability;
        /* 0x590 */ public float SDeform;
        /* 0x594 */ public float SenseProbingValueSmoothingTime;
        /* 0x598 */ public float SenseProbingValueSmoothingTimeMed;
        /* 0x59C */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x5A0 */ public float ShipRadiation;
        /* 0x5A4 */ public float ShipTemperature;
        /* 0x5A8 */ public float ShipToxicity;
        /* 0x5AC */ public float SkyAtmospherePower;
        /* 0x5B0 */ public float SmallAsteroidScale;
        /* 0x5B4 */ public float SpaceRadiation;
        /* 0x5B8 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x5BC */ public float SpaceTemperature;
        /* 0x5C0 */ public float SpaceToxicity;
        /* 0x5C4 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x5C8 */ public float SphereLodTextureScale;
        /* 0x5CC */ public float SunClampHeightMax;
        /* 0x5D0 */ public float SunClampHeightMin;
        /* 0x5D4 */ public float SunFactorMin;
        // size: 0x3
        public enum SwitchTypeEnum : uint {
            None,
            Debug,
            Enabled,
        }
        /* 0x5D8 */ public SwitchTypeEnum SwitchType;
        /* 0x5DC */ public float TemperatureSmoothTime;
        /* 0x5E0 */ public float TerrainFadeTime;
        /* 0x5E4 */ public float TerrainFadeTimeInShip;
        /* 0x5E8 */ public float TerrainFlattenMax;
        /* 0x5EC */ public float TerrainFlattenMin;
        /* 0x5F0 */ public float VDeform;
        /* 0x5F4 */ public float WaterAlphaHeightMax;
        /* 0x5F8 */ public float WaterAlphaHeightMin;
        /* 0x5FC */ public float WaterFogHeightMax;
        /* 0x600 */ public bool EnableWind;
        /* 0x601 */ public bool ForceAddCaveProps;
        /* 0x602 */ public bool ForceAddUnderwaterProps;
        /* 0x603 */ public bool MatchPlantPalettes;
    }
}

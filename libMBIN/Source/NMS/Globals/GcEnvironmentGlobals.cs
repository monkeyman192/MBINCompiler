using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD55E818E8B266EC3, NameHash = 0x1E09DD001FDA82F8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public TkLODSettingsData[] LODSettings;
        /* 0x250 */ public Vector2f SpaceBuildingTemperature;
        /* 0x260 */ public GcCloudProperties CloudProperties;
        /* 0x340 */ public float SenseProbingValueSmoothingTime;
        /* 0x344 */ public float SenseProbingValueSmoothingTimeMed;
        /* 0x348 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x34C */ public float IndoorsLightingWeightAround;
        /* 0x350 */ public float IndoorsLightingWeightOverhead;
        /* 0x354 */ public float IndoorsLightingWeightTowardsSun;
        /* 0x358 */ public float IndoorsLightingWeightGround;
        /* 0x35C */ public float IndoorsLightingTransitionTime;
        /* 0x360 */ public float IndoorsLightingThreshold;
        /* 0x364 */ public float IndoorsLightingPlanetMax;
        /* 0x368 */ public float IndoorsLightingAbandonedFreighterMax;
        /* 0x36C */ public float IndoorsLightingNexusMax;
        /* 0x370 */ public float IndoorsLightingFreighterMax;
        /* 0x374 */ public float MaxElevation;
        /* 0x378 */ public float SphereLodTextureScale;
        /* 0x37C */ public bool ForceAddUnderwaterProps;
        /* 0x37D */ public bool ForceAddCaveProps;
        /* 0x380 */ public float DistortionStep;
        /* 0x384 */ public float HDeform;
        /* 0x388 */ public float SDeform;
        /* 0x38C */ public float VDeform;
        /* 0x390 */ public float LocationStableTime;
        /* 0x394 */ public float InterestStableTime;
        /* 0x398 */ public float AsteroidFieldStableEnterTime;
        /* 0x39C */ public float AsteroidFieldStableLeaveTime;
        /* 0x3A0 */ public float TemperatureSmoothTime;
        /* 0x3A4 */ public float SunFactorMin;
        /* 0x3A8 */ public float ExposureSurfaceContrib;
        /* 0x3AC */ public float ExposureSurfaceDistMax;
        /* 0x3B0 */ public float ExposureGroundFactorAddMul;
        /* 0x3B4 */ public Vector2f ExposureHeightBracket;
        /* 0x3BC */ public float DailyTempChangePercent;
        /* 0x3C0 */ public float SpaceTemperature;
        /* 0x3C4 */ public float AbandonedFreighterMinTemperature;
        /* 0x3C8 */ public float AbandonedFreighterMaxTemperature;
        /* 0x3CC */ public float ShipTemperature;
        /* 0x3D0 */ public float SpaceRadiation;
        /* 0x3D4 */ public float ShipRadiation;
        /* 0x3D8 */ public float SpaceToxicity;
        /* 0x3DC */ public float ShipToxicity;
        /* 0x3E0 */ public bool MatchPlantPalettes;
        /* 0x3E4 */ public float DuplicateColourThreshold;
        // size: 0x3
        public enum SwitchTypeEnum { None, Debug, Enabled }
        /* 0x3E8 */ public SwitchTypeEnum SwitchType;
        /* 0x3EC */ public float GrassNormalUpright;
        /* 0x3F0 */ public float GrassNormalOffset;
        /* 0x3F4 */ public float GrassNormalSpherify;
        /* 0x3F8 */ public float GrassNormalMap;
        /* 0x3FC */ public float MinPlacementBlendValue;
        /* 0x400 */ public float MinPlacementBlendValuePatch;
        /* 0x404 */ public float MaxPlacementBlendValuePatch;
        /* 0x408 */ public float MinPlacementObjectScale;
        /* 0x40C */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x410 */ public float AtmosphereSpaceRadius;
        /* 0x414 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x418 */ public float TerrainFadeTime;
        /* 0x41C */ public float TerrainFadeTimeInShip;
        /* 0x420 */ public float CreatureFadeTime;
        /* 0x424 */ public float FloraFadeTimeMin;
        /* 0x428 */ public float FloraFadeTimeMax;
        /* 0x42C */ public float PlanetUnwrapMin;
        /* 0x430 */ public float PlanetUnwrapMax;
        /* 0x434 */ public float TerrainFlattenMin;
        /* 0x438 */ public float TerrainFlattenMax;
        /* 0x43C */ public float HeightFogHeightMin;
        /* 0x440 */ public float WaterFogHeightMax;
        /* 0x444 */ public float WaterAlphaHeightMin;
        /* 0x448 */ public float WaterAlphaHeightMax;
        /* 0x44C */ public float DoFHeightMin;
        /* 0x450 */ public float DoFHeightMax;
        /* 0x454 */ public float SunClampHeightMin;
        /* 0x458 */ public float SunClampHeightMax;
        /* 0x45C */ public float HeavyAirFadeDistance;
        /* 0x460 */ public float HeavyAirFadeInTime;
        /* 0x464 */ public float HeavyAirFadeOutTime;
        /* 0x468 */ public float PlanetFlipDistance;
        /* 0x46C */ public float PlanetEffectEndDistance;
        /* 0x470 */ public float AsteroidFadeHeightMin;
        /* 0x474 */ public float AsteroidFadeHeightMax;
        /* 0x478 */ public float AsteroidScale;
        /* 0x47C */ public float SmallAsteroidScale;
        /* 0x480 */ public float AsteroidMinRotate;
        /* 0x484 */ public float AsteroidMaxRotate;
        /* 0x488 */ public float MinWaterReflections;
        /* 0x490 */ public List<float> SpacePlanetFogStrength;
        /* 0x4A0 */ public List<float> SkyBlendLength;
        /* 0x4B0 */ public float SkyAtmospherePower;
        /* 0x4B8 */ public List<float> SkyAtmosphereBlendLength;
        /* 0x4C8 */ public List<float> FarBlendHeight;
        /* 0x4D8 */ public float FarBlendLength;
        /* 0x4DC */ public float IndoorColourBlendTime;
        /* 0x4E0 */ public Colour IndoorAmbientColour;
        /* 0x4F0 */ public float LightDirectionHeight;
        /* 0x4F4 */ public float LightDirectionBlend;
        /* 0x4F8 */ public float LightColourHeight;
        /* 0x4FC */ public float LightColourBlend;
        /* 0x500 */ public float ObjectSpawnFirstRadius;
        /* 0x504 */ public float ObjectSpawnFirstDotCheck;
        /* 0x508 */ public float ObjectSpawnDetailRadius;
        /* 0x50C */ public float InteractionRadius;
        /* 0x510 */ public bool EnableWind;
        /* 0x518 */ public List<TkShearWindData> ShearWindSettings;
        /* 0x528 */ public int HotspotsLOD;
        /* 0x52C */ public float RegionHotspotProbability;
        /* 0x530 */ public float MaxHotspotOffsetDistance;
        /* 0x534 */ public float MinHotspotFalloffDistance;
        /* 0x538 */ public float MaxHotspotFalloffDistance;
        /* 0x53C */ public GcEnvironmentProperties EnvironmentProperties;
        /* 0x5B4 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
    }
}

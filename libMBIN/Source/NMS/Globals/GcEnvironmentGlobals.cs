using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x6F0, GUID = 0x4AB168D8BF669DDC)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public TkLODSettingsData[] LODSettings;
        /* 0x1D0 */ public Vector2f SpaceBuildingTemperature;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1D8 */ public byte[] Padding1D8;
        /* 0x1E0 */ public GcCloudProperties CloudProperties;
        /* 0x2C0 */ public float SenseProbingValueSmoothingTime;
        /* 0x2C4 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x2C8 */ public float MaxElevation;
        /* 0x2CC */ public float SphereLodTextureScale;
        /* 0x2D0 */ public bool ForceAddUnderwaterProps;
        /* 0x2D1 */ public bool ForceAddCaveProps;
        /* 0x2D4 */ public float DistortionStep;
        /* 0x2D8 */ public float HDeform;
        /* 0x2DC */ public float SDeform;
        /* 0x2E0 */ public float VDeform;
        /* 0x2E4 */ public float LocationStableTime;
        /* 0x2E8 */ public float InterestStableTime;
        /* 0x2EC */ public float TemperatureSmoothTime;
        /* 0x2F0 */ public float SunFactorMin;
        /* 0x2F4 */ public float ExposureSurfaceContrib;
        /* 0x2F8 */ public float ExposureSurfaceDistMax;
        /* 0x2FC */ public float ExposureGroundFactorAddMul;
        /* 0x300 */ public Vector2f ExposureHeightBracket;
        /* 0x308 */ public float DailyTempChangePercent;
        /* 0x30C */ public float SpaceTemperature;
        /* 0x310 */ public float AbandonedFreighterMinTemperature;
        /* 0x314 */ public float AbandonedFreighterMaxTemperature;
        /* 0x318 */ public float ShipTemperature;
        /* 0x31C */ public float SpaceRadiation;
        /* 0x320 */ public float ShipRadiation;
        /* 0x324 */ public float SpaceToxicity;
        /* 0x328 */ public float ShipToxicity;
        /* 0x32C */ public bool MatchPlantPalettes;
        /* 0x330 */ public float DuplicateColourThreshold;
        public enum SwitchTypeEnum { None, Debug, Enabled }
        /* 0x334 */ public SwitchTypeEnum SwitchType;
        /* 0x338 */ public float GrassNormalUpright;
        /* 0x33C */ public float GrassNormalOffset;
        /* 0x340 */ public float GrassNormalSpherify;
        /* 0x344 */ public float GrassNormalMap;
        /* 0x348 */ public float MinPlacementBlendValue;
        /* 0x34C */ public float MinPlacementBlendValuePatch;
        /* 0x350 */ public float MaxPlacementBlendValuePatch;
        /* 0x354 */ public float MinPlacementObjectScale;
        /* 0x358 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x35C */ public float AtmosphereSpaceRadius;
        /* 0x360 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x364 */ public float TerrainFadeTime;
        /* 0x368 */ public float TerrainFadeTimeInShip;
        /* 0x36C */ public float CreatureFadeTime;
        /* 0x370 */ public float FloraFadeTimeMin;
        /* 0x374 */ public float FloraFadeTimeMax;
        /* 0x378 */ public float PlanetUnwrapMin;
        /* 0x37C */ public float PlanetUnwrapMax;
        /* 0x380 */ public float TerrainFlattenMin;
        /* 0x384 */ public float TerrainFlattenMax;
        /* 0x388 */ public float HeightFogHeightMin;
        /* 0x38C */ public float WaterFogHeightMax;
        /* 0x390 */ public float WaterAlphaHeightMin;
        /* 0x394 */ public float WaterAlphaHeightMax;
        /* 0x398 */ public float DoFHeightMin;
        /* 0x39C */ public float DoFHeightMax;
        /* 0x3A0 */ public float SunClampHeightMin;
        /* 0x3A4 */ public float SunClampHeightMax;
        /* 0x3A8 */ public float HeavyAirFadeDistance;
        /* 0x3AC */ public float HeavyAirFadeInTime;
        /* 0x3B0 */ public float HeavyAirFadeOutTime;
        /* 0x3B4 */ public float PlanetFlipDistance;
        /* 0x3B8 */ public float PlanetEffectEndDistance;
        /* 0x3BC */ public float AsteroidFadeHeightMin;
        /* 0x3C0 */ public float AsteroidFadeHeightMax;
        /* 0x3C4 */ public float AsteroidScale;
        /* 0x3C8 */ public float SmallAsteroidScale;
        /* 0x3CC */ public float AsteroidMinRotate;
        /* 0x3D0 */ public float AsteroidMaxRotate;
        /* 0x3D4 */ public float MinWaterReflections;
        [NMS(Size = 0x4)]
        /* 0x3D8 */ public float[] SpacePlanetFogStrength;
        [NMS(Size = 0x4)]
        /* 0x3E8 */ public float[] SkyBlendLength;
        /* 0x3F8 */ public float SkyAtmospherePower;
        [NMS(Size = 0x4)]
        /* 0x3FC */ public float[] SkyAtmosphereBlendLength;
        [NMS(Size = 0x4)]
        /* 0x40C */ public float[] FarBlendHeight;
        /* 0x41C */ public float FarBlendLength;
        /* 0x420 */ public float IndoorColourBlendTime;
        /* 0x430 */ public Colour IndoorAmbientColour;
        /* 0x440 */ public float LightDirectionHeight;
        /* 0x444 */ public float LightDirectionBlend;
        /* 0x448 */ public float LightColourHeight;
        /* 0x44C */ public float LightColourBlend;
        /* 0x450 */ public float ObjectSpawnFirstRadius;
        /* 0x454 */ public float ObjectSpawnFirstDotCheck;
        /* 0x458 */ public float ObjectSpawnDetailRadius;
        /* 0x45C */ public float InteractionRadius;
        /* 0x460 */ public bool EnableWind;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x461 */ public byte[] Padding461;
        [NMS(Size = 0x3)]
        /* 0x468 */ public TkShearWindData[] ShearWindSettings;
        /* 0x5E8 */ public int HotspotsLOD;
        /* 0x5EC */ public float RegionHotspotProbability;
        /* 0x5F0 */ public float MaxHotspotOffsetDistance;
        /* 0x5F4 */ public float MinHotspotFalloffDistance;
        /* 0x5F8 */ public float MaxHotspotFalloffDistance;
        /* 0x5FC */ public GcEnvironmentProperties EnvironmentProperties;
        /* 0x674 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6EC */ public byte[] EndPadding;
    }
}

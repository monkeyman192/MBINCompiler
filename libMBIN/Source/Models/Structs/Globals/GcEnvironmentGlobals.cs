namespace libMBIN.Models.Structs.Unfinished
{
    public class GcEnvironmentGlobals : NMSTemplate
    {
        /* 0x0 */ public Vector2f SpaceBuildingTemperature;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x8 */ public byte[] Padding8;
        /* 0x10 */ public GcCloudProperties CloudProperties;
        /* 0x100 */ public float SenseProbingValueSmoothingTime;
        /* 0x104 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x108 */ public float MaxElevation;
        /* 0x10C */ public float SphereLodTextureScale;
        /* 0x110 */ public bool ForceAddUnderwaterProps;
        /* 0x111 */ public bool ForceAddCaveProps;
        /* 0x114 */ public float DistortionStep;
        /* 0x118 */ public float HDeform;
        /* 0x11C */ public float SDeform;
        /* 0x120 */ public float VDeform;
        /* 0x124 */ public float LocationStableTime;
        /* 0x128 */ public float InterestStableTime;
        /* 0x12C */ public float TemperatureSmoothTime;
        /* 0x130 */ public float SunFactorMin;
        /* 0x134 */ public float ExposureSurfaceContrib;
        /* 0x138 */ public float ExposureSurfaceDistMax;
        /* 0x13C */ public float ExposureGroundFactorAddMul;
        /* 0x140 */ public Vector2f ExposureHeightBracket;
        /* 0x148 */ public float DailyTempChangePercent;
        /* 0x14C */ public float SpaceTemperature;
        /* 0x150 */ public float ShipTemperature;
        /* 0x154 */ public float SpaceRadiation;
        /* 0x158 */ public float ShipRadiation;
        /* 0x15C */ public float SpaceToxicity;
        /* 0x160 */ public float ShipToxicity;
        /* 0x164 */ public bool MatchPlantPalettes;
        /* 0x168 */ public float DuplicateColourThreshold;
        /* 0x16C */ public int SwitchType;
        /* 0x170 */ public float GrassNormalUpright;
        /* 0x174 */ public float GrassNormalOffset;
        /* 0x178 */ public float GrassNormalSpherify;
        /* 0x17C */ public float GrassNormalMap;
        /* 0x180 */ public float MinPlacementBlendValue;
        /* 0x184 */ public float MinPlacementBlendValuePatch;
        /* 0x188 */ public float MaxPlacementBlendValuePatch;
        /* 0x18C */ public float MinPlacementObjectScale;
        /* 0x190 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x194 */ public float AtmosphereSpaceRadius;
        /* 0x198 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x19C */ public float TerrainFadeTime;
        /* 0x1A0 */ public float TerrainFadeTimeInShip;
        /* 0x1A4 */ public float CreatureFadeTime;
        /* 0x1A8 */ public float FloraFadeTimeMin;
        /* 0x1AC */ public float FloraFadeTimeMax;
        /* 0x1B0 */ public float PlanetUnwrapMin;
        /* 0x1B4 */ public float PlanetUnwrapMax;
        /* 0x1B8 */ public float TerrainFlattenMin;
        /* 0x1BC */ public float TerrainFlattenMax;
        /* 0x1C0 */ public float FogHeightMin;
        /* 0x1C4 */ public float FogHeightMax;
        /* 0x1C8 */ public float HeightFogHeightMin;
        /* 0x1CC */ public float HeightFogHeightMax;
        /* 0x1D0 */ public float WaterFogHeightMin;
        /* 0x1D4 */ public float WaterFogHeightMax;
        /* 0x1D8 */ public float WaterAlphaHeightMin;
        /* 0x1DC */ public float WaterAlphaHeightMax;
        /* 0x1E0 */ public float CloudHeightMin;
        /* 0x1E4 */ public float CloudHeightMax;
        /* 0x1E8 */ public float DoFHeightMin;
        /* 0x1EC */ public float DoFHeightMax;
        /* 0x1F0 */ public float SunClampHeightMin;
        /* 0x1F4 */ public float SunClampHeightMax;
        /* 0x1F8 */ public float HeavyAirFadeDistance;
        /* 0x1FC */ public float HeavyAirHeightMin;
        /* 0x200 */ public float HeavyAirHeightMax;
        /* 0x204 */ public float HeavyAirFadeInTime;
        /* 0x208 */ public float HeavyAirFadeOutTime;
        /* 0x20C */ public float PlanetObjectSwitch;
        /* 0x210 */ public float PlanetLodSwitch0;
        /* 0x214 */ public float PlanetLodSwitch0Elevation;
        /* 0x218 */ public float PlanetLodSwitch1;
        /* 0x21C */ public float PlanetLodSwitch2;
        /* 0x220 */ public float PlanetLodSwitch3;
        /* 0x224 */ public float PlanetFlipDistance;
        /* 0x228 */ public float PlanetEffectEndDistance;
        /* 0x22C */ public float AsteroidFadeHeightMin;
        /* 0x230 */ public float AsteroidFadeHeightMax;
        /* 0x234 */ public float AsteroidScale;
        /* 0x238 */ public float SmallAsteroidScale;
        /* 0x23C */ public float AsteroidMinRotate;
        /* 0x240 */ public float AsteroidMaxRotate;
        /* 0x244 */ public float MinWaterReflections;
        [NMS(Size = 0x4)]
        /* 0x248 */ public float[] SpacePlanetFogStrength;
        [NMS(Size = 0x4)]
        /* 0x258 */ public float[] SkyHeight;
        [NMS(Size = 0x4)]
        /* 0x268 */ public float[] SkyBlendLength;
        /* 0x278 */ public float SkyAtmospherePower;
        /* 0x27C */ public float SkyAtmosphereHeight;
        [NMS(Size = 0x4)]
        /* 0x280 */ public float[] SkyAtmosphereBlendLength;
        /* 0x290 */ public float HorizonBlendHeight;
        /* 0x294 */ public float HorizonBlendLength;
        [NMS(Size = 0x4)]
        /* 0x298 */ public float[] FarBlendHeight;
        /* 0x2A8 */ public float FarBlendLength;
        /* 0x2AC */ public float SkyColourHeight;
        /* 0x2B0 */ public float SkyColourBlendLength;
        /* 0x2B4 */ public float SkyPositionHeight;
        /* 0x2B8 */ public float SkyPositionBlendLength;
        /* 0x2BC */ public float LightDirectionHeight;
        /* 0x2C0 */ public float LightDirectionBlend;
        /* 0x2C4 */ public float LightColourHeight;
        /* 0x2C8 */ public float LightColourBlend;
        /* 0x2CC */ public float FlightFogHeight;
        /* 0x2D0 */ public float FlightFogBlend;
        /* 0x2D4 */ public float SolarSystemLUTHeight;
        /* 0x2D8 */ public float SolarSystemLUTBlendLength;
        /* 0x2DC */ public float ObjectSpawnFirstRadius;
        /* 0x2E0 */ public float ObjectSpawnFirstDotCheck;
        /* 0x2E4 */ public float ObjectSpawnDetailRadius;
        /* 0x2E8 */ public float InteractionRadius;
        /* 0x2EC */ public bool EnableWind;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2ED */ public byte[] Padding2ED;
        [NMS(Size = 0x3)]
        /* 0x2F0 */ public TkShearWindData[] ShearWindSettings;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCE6A167659169449, NameHash = 0x5BED7FBA4647E787)]
    public class GcSkyGlobals : NMSTemplate
    {
        [NMS(Index = 130)]
        /* 0x000 */ public GcPlanetWeatherColourData NightSkyColours;
        [NMS(Index = 128)]
        /* 0x0B0 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Index = 127)]
        /* 0x150 */ public GcSpaceSkyProperties SpaceSkyMin;
        [NMS(Index = 68)]
        /* 0x1F0 */ public Colour AbandonedFreighterFogColour;
        [NMS(Index = 62)]
        /* 0x200 */ public Colour AsteroidColour;
        [NMS(Index = 63)]
        /* 0x210 */ public Colour DayLightColour;
        [NMS(Index = 65)]
        /* 0x220 */ public Colour DuskLightColour;
        [NMS(Index = 131)]
        /* 0x230 */ public Colour HeavyAirColour1;
        [NMS(Index = 132)]
        /* 0x240 */ public Colour HeavyAirColour2;
        [NMS(Index = 135)]
        /* 0x250 */ public Colour NightFogColour;
        [NMS(Index = 66)]
        /* 0x260 */ public Colour NightHeavyAirColour;
        [NMS(Index = 136)]
        /* 0x270 */ public Colour NightHeightFogColour;
        [NMS(Index = 133)]
        /* 0x280 */ public Colour NightHorizonColour;
        [NMS(Index = 64)]
        /* 0x290 */ public Colour NightLightColour;
        [NMS(Index = 134)]
        /* 0x2A0 */ public Colour NightSkyColour;
        [NMS(Index = 60)]
        /* 0x2B0 */ public Vector3f SleepSunFromSettingsPos;
        [NMS(Index = 67)]
        /* 0x2C0 */ public Colour SpaceLightColour;
        [NMS(Index = 61)]
        /* 0x2D0 */ public Vector3f SunPosition;
        [NMS(Index = 12)]
        /* 0x2E0 */ public Vector3f SunRotationAxis;
        [NMS(Index = 138)]
        /* 0x2F0 */ public GcPlanetCloudProperties PlanetCloudsMax;
        [NMS(Index = 137)]
        /* 0x330 */ public GcPlanetCloudProperties PlanetCloudsMin;
        [NMS(Index = 129)]
        /* 0x370 */ public List<GcSpaceSkyColours> SpaceSkyColours;
        [NMS(Index = 125)]
        /* 0x380 */ public GcPlanetSkyProperties PlanetPrimeProperties;
        [NMS(Index = 124)]
        /* 0x730 */ public GcPlanetSkyProperties PlanetProperties;
        [NMS(Index = 126)]
        /* 0xAE0 */ public GcFogProperties AbandonedFreighterFog;
        [NMS(Index = 8)]
        /* 0xBC0 */ public GcPhotoModeAdjustData CloudAdjust;
        [NMS(Index = 7)]
        /* 0xBD0 */ public GcPhotoModeAdjustData FogAdjust;
        [NMS(Index = 9)]
        /* 0xBE0 */ public GcPhotoModeAdjustData VignetteAdjust;
        [NMS(Index = 18)]
        /* 0xBF0 */ public Vector2f PhotoModeVignette;
        [NMS(Index = 70)]
        /* 0xBF8 */ public float AmbientFactor;
        [NMS(Index = 139)]
        /* 0xBFC */ public float BinaryStarChance;
        [NMS(Index = 106)]
        /* 0xC00 */ public float CloudColourH;
        [NMS(Index = 107)]
        /* 0xC04 */ public float CloudColourS;
        [NMS(Index = 108)]
        /* 0xC08 */ public float CloudColourV;
        [NMS(Index = 52)]
        /* 0xC0C */ public float CloudCoverSmoothTime;
        [NMS(Index = 53)]
        /* 0xC10 */ public float CloudRatioSmoothTime;
        [NMS(Index = 48)]
        /* 0xC14 */ public float CreatureStormThreshold;
        [NMS(Index = 11)]
        /* 0xC18 */ public int DayLength;
        [NMS(Index = 50)]
        /* 0xC1C */ public float ExtremeAudioLevel;
        [NMS(Index = 44)]
        /* 0xC20 */ public float ForceFlightStrength;
        [NMS(Index = 118)]
        /* 0xC24 */ public float ForceNightBlendValue;
        [NMS(Index = 26)]
        /* 0xC28 */ public float ForceStormStrength;
        [NMS(Index = 24)]
        /* 0xC2C */ public float FreshStartTimeOfDay;
        [NMS(Index = 16)]
        /* 0xC30 */ public int FrozenSkyMaxIndex;
        [NMS(Index = 15)]
        /* 0xC34 */ public int FrozenSkyMinIndex;
        [NMS(Index = 69)]
        /* 0xC38 */ public float HeavyAirScale;
        [NMS(Index = 47)]
        /* 0xC3C */ public float InFlightStormStrength;
        [NMS(Index = 123)]
        /* 0xC40 */ public float LowFlightFogThreshold;
        [NMS(Index = 41)]
        /* 0xC44 */ public float MaxCloudCover;
        [NMS(Index = 94)]
        /* 0xC48 */ public float MaxColourS;
        [NMS(Index = 96)]
        /* 0xC4C */ public float MaxColourV;
        [NMS(Index = 90)]
        /* 0xC50 */ public float MaxFogSaturation;
        [NMS(Index = 92)]
        /* 0xC54 */ public float MaxFogValue;
        [NMS(Index = 76)]
        /* 0xC58 */ public float MaxNightFade;
        [NMS(Index = 147)]
        /* 0xC5C */ public float MaxRainWetness;
        [NMS(Index = 86)]
        /* 0xC60 */ public float MaxSaturation;
        [NMS(Index = 42)]
        /* 0xC64 */ public float MaxStormCloudCover;
        [NMS(Index = 38)]
        /* 0xC68 */ public float MaxStormLengthHigh;
        [NMS(Index = 36)]
        /* 0xC6C */ public float MaxStormLengthLow;
        [NMS(Index = 82)]
        /* 0xC70 */ public float MaxSunsetAtmosphereFade;
        [NMS(Index = 84)]
        /* 0xC74 */ public float MaxSunsetColourFade;
        [NMS(Index = 72)]
        /* 0xC78 */ public float MaxSunsetFade;
        [NMS(Index = 80)]
        /* 0xC7C */ public float MaxSunsetFogFade;
        [NMS(Index = 74)]
        /* 0xC80 */ public float MaxSunsetHorizonFade;
        [NMS(Index = 78)]
        /* 0xC84 */ public float MaxSunsetPosFade;
        [NMS(Index = 34)]
        /* 0xC88 */ public float MaxTimeBetweenStormsExtremeFallback;
        [NMS(Index = 32)]
        /* 0xC8C */ public float MaxTimeBetweenStormsHigh;
        [NMS(Index = 30)]
        /* 0xC90 */ public float MaxTimeBetweenStormsLow;
        [NMS(Index = 88)]
        /* 0xC94 */ public float MaxValue;
        [NMS(Index = 103)]
        /* 0xC98 */ public float MidColourH;
        [NMS(Index = 104)]
        /* 0xC9C */ public float MidColourS;
        [NMS(Index = 105)]
        /* 0xCA0 */ public float MidColourV;
        [NMS(Index = 93)]
        /* 0xCA4 */ public float MinColourS;
        [NMS(Index = 95)]
        /* 0xCA8 */ public float MinColourV;
        [NMS(Index = 89)]
        /* 0xCAC */ public float MinFogSaturation;
        [NMS(Index = 91)]
        /* 0xCB0 */ public float MinFogValue;
        [NMS(Index = 75)]
        /* 0xCB4 */ public float MinNightFade;
        [NMS(Index = 85)]
        /* 0xCB8 */ public float MinSaturation;
        [NMS(Index = 37)]
        /* 0xCBC */ public float MinStormLengthHigh;
        [NMS(Index = 35)]
        /* 0xCC0 */ public float MinStormLengthLow;
        [NMS(Index = 81)]
        /* 0xCC4 */ public float MinSunsetAtmosphereFade;
        [NMS(Index = 83)]
        /* 0xCC8 */ public float MinSunsetColourFade;
        [NMS(Index = 71)]
        /* 0xCCC */ public float MinSunsetFade;
        [NMS(Index = 79)]
        /* 0xCD0 */ public float MinSunsetFogFade;
        [NMS(Index = 73)]
        /* 0xCD4 */ public float MinSunsetHorizonFade;
        [NMS(Index = 77)]
        /* 0xCD8 */ public float MinSunsetPosFade;
        [NMS(Index = 33)]
        /* 0xCDC */ public float MinTimeBetweenStormsExtremeFallback;
        [NMS(Index = 31)]
        /* 0xCE0 */ public float MinTimeBetweenStormsHigh;
        [NMS(Index = 29)]
        /* 0xCE4 */ public float MinTimeBetweenStormsLow;
        [NMS(Index = 87)]
        /* 0xCE8 */ public float MinValue;
        [NMS(Index = 97)]
        /* 0xCEC */ public float MulticolourH;
        [NMS(Index = 99)]
        /* 0xCF0 */ public float NebulaColour1S;
        [NMS(Index = 100)]
        /* 0xCF4 */ public float NebulaColour1V;
        [NMS(Index = 101)]
        /* 0xCF8 */ public float NebulaColour2S;
        [NMS(Index = 102)]
        /* 0xCFC */ public float NebulaColour2V;
        [NMS(Index = 98)]
        /* 0xD00 */ public float NebulaColourH;
        [NMS(Index = 112)]
        /* 0xD04 */ public float NightHorizonBlendMax;
        [NMS(Index = 111)]
        /* 0xD08 */ public float NightHorizonBlendMin;
        [NMS(Index = 116)]
        /* 0xD0C */ public float NightLightBlendMax;
        [NMS(Index = 115)]
        /* 0xD10 */ public float NightLightBlendMin;
        [NMS(Index = 114)]
        /* 0xD14 */ public float NightSkyBlendMax;
        [NMS(Index = 113)]
        /* 0xD18 */ public float NightSkyBlendMin;
        [NMS(Index = 6)]
        /* 0xD1C */ public float NightThreshold;
        [NMS(Index = 122)]
        /* 0xD20 */ public float NoAtmosphereColourMax;
        [NMS(Index = 121)]
        /* 0xD24 */ public float NoAtmosphereColourStrength;
        [NMS(Index = 120)]
        /* 0xD28 */ public float NoAtmosphereFogMax;
        [NMS(Index = 119)]
        /* 0xD2C */ public float NoAtmosphereFogStrength;
        [NMS(Index = 20)]
        /* 0xD30 */ public float PhotoModeMacroMaxDOFAngle;
        [NMS(Index = 21)]
        /* 0xD34 */ public float PhotoModeMacroMaxDOFAperture;
        [NMS(Index = 19)]
        /* 0xD38 */ public float PhotoModeSunSpeed;
        [NMS(Index = 3)]
        /* 0xD3C */ public float RainbowAlpha;
        [NMS(Index = 0)]
        /* 0xD40 */ public float RainbowDistance;
        [NMS(Index = 5)]
        /* 0xD44 */ public float RainbowFadeWidth;
        [NMS(Index = 1)]
        /* 0xD48 */ public float RainbowScale;
        [NMS(Index = 4)]
        /* 0xD4C */ public float RainbowStormAlpha;
        [NMS(Index = 2)]
        /* 0xD50 */ public float RainbowWidth;
        [NMS(Index = 148)]
        /* 0xD54 */ public float RainWetnessFadeInTime;
        [NMS(Index = 149)]
        /* 0xD58 */ public float RainWetnessFadeOutTime;
        [NMS(Index = 14)]
        /* 0xD5C */ public int SafeSkyMaxIndex;
        [NMS(Index = 13)]
        /* 0xD60 */ public int SafeSkyMinIndex;
        [NMS(Index = 109)]
        /* 0xD64 */ public float SpaceAtmosphereThickness;
        [NMS(Index = 51)]
        /* 0xD68 */ public float StormAudioLevel;
        [NMS(Index = 57)]
        /* 0xD6C */ public float StormCloudBottomColourMaxBlend;
        [NMS(Index = 56)]
        /* 0xD70 */ public float StormCloudBottomColourMinBlend;
        [NMS(Index = 58)]
        /* 0xD74 */ public float StormCloudSmoothTime;
        [NMS(Index = 55)]
        /* 0xD78 */ public float StormCloudTopColourMaxBlend;
        [NMS(Index = 54)]
        /* 0xD7C */ public float StormCloudTopColourMinBlend;
        [NMS(Index = 28)]
        /* 0xD80 */ public float StormScreenFilterDistance;
        [NMS(Index = 27)]
        /* 0xD84 */ public float StormScreenFilterFadeTime;
        [NMS(Index = 40)]
        /* 0xD88 */ public float StormTransitionTime;
        [NMS(Index = 39)]
        /* 0xD8C */ public float StormWarningTime;
        [NMS(Index = 17)]
        /* 0xD90 */ public float SunClampAngle;
        [NMS(Index = 49)]
        /* 0xD94 */ public float TakeoffStormThreshold;
        [NMS(Index = 140)]
        /* 0xD98 */ public float TernaryStarChance;
        [NMS(Index = 46)]
        /* 0xD9C */ public float ToFlightFadeTime;
        [NMS(Index = 45)]
        /* 0xDA0 */ public float ToFootFadeTime;
        [NMS(Index = 110)]
        /* 0xDA4 */ public float WaterHeavyAirAlpha;
        [NMS(Index = 141)]
        /* 0xDA8 */ public float WeatherBloomGain;
        [NMS(Index = 142)]
        /* 0xDAC */ public float WeatherBloomGainSpeed;
        [NMS(Index = 145)]
        /* 0xDB0 */ public float WeatherBloomImpulseSpeed;
        [NMS(Index = 143)]
        /* 0xDB4 */ public float WeatherBloomThreshold;
        [NMS(Index = 144)]
        /* 0xDB8 */ public float WeatherBloomThresholdSpeed;
        [NMS(Index = 23)]
        /* 0xDBC */ public float WeatherFilterSpaceTransitionChangeTime;
        [NMS(Index = 10)]
        /* 0xDC0 */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        [NMS(Index = 43)]
        /* 0xDC1 */ public bool ForceFlightSetting;
        [NMS(Index = 117)]
        /* 0xDC2 */ public bool ForceNightBlend;
        [NMS(Index = 25)]
        /* 0xDC3 */ public bool ForceStormSetting;
        [NMS(Index = 59)]
        /* 0xDC4 */ public bool SleepSunFromSettings;
        [NMS(Index = 22)]
        /* 0xDC5 */ public bool UpdateWeatherWhenSunLocked;
        [NMS(Index = 146)]
        /* 0xDC6 */ public TkCurveType WeatherBloomCurve;
    }
}

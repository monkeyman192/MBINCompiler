using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x88BAB4ADD6F169CA, NameHash = 0x20D1EBD0)]
    public class GcSkyGlobals : NMSTemplate
    {
        [NMS(Index = 122)]
        /* 0x0000 */ public GcPlanetSkyProperties PlanetGasGiantProperties;
        [NMS(Index = 121)]
        /* 0x0770 */ public GcPlanetSkyProperties PlanetPrimeProperties;
        [NMS(Index = 120)]
        /* 0x0EE0 */ public GcPlanetSkyProperties PlanetProperties;
        [NMS(Index = 123)]
        /* 0x1650 */ public GcFogProperties AbandonedFreighterFog;
        [NMS(Index = 127)]
        /* 0x1820 */ public GcPlanetWeatherColourData NightSkyColours;
        [NMS(Index = 125)]
        /* 0x1900 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Index = 124)]
        /* 0x19A0 */ public GcSpaceSkyProperties SpaceSkyMin;
        [NMS(Index = 64)]
        /* 0x1A40 */ public Colour AbandonedFreighterFogColour;
        [NMS(Index = 59)]
        /* 0x1A50 */ public Colour AsteroidColour;
        [NMS(Index = 60)]
        /* 0x1A60 */ public Colour DayLightColour;
        [NMS(Index = 62)]
        /* 0x1A70 */ public Colour DuskLightColour;
        [NMS(Index = 128)]
        /* 0x1A80 */ public Colour HeavyAirColour1;
        [NMS(Index = 129)]
        /* 0x1A90 */ public Colour HeavyAirColour2;
        [NMS(Index = 132)]
        /* 0x1AA0 */ public Colour NightFogColour;
        [NMS(Index = 133)]
        /* 0x1AB0 */ public Colour NightHeightFogColour;
        [NMS(Index = 130)]
        /* 0x1AC0 */ public Colour NightHorizonColour;
        [NMS(Index = 61)]
        /* 0x1AD0 */ public Colour NightLightColour;
        [NMS(Index = 131)]
        /* 0x1AE0 */ public Colour NightSkyColour;
        [NMS(Index = 57)]
        /* 0x1AF0 */ public Vector3f SleepSunFromSettingsPos;
        [NMS(Index = 63)]
        /* 0x1B00 */ public Colour SpaceLightColour;
        [NMS(Index = 58)]
        /* 0x1B10 */ public Vector3f SunPosition;
        [NMS(Index = 13)]
        /* 0x1B20 */ public Vector3f SunRotationAxis;
        [NMS(Index = 135)]
        /* 0x1B30 */ public GcPlanetCloudProperties PlanetCloudsMax;
        [NMS(Index = 134)]
        /* 0x1B78 */ public GcPlanetCloudProperties PlanetCloudsMin;
        [NMS(Index = 126)]
        /* 0x1BC0 */ public List<GcSpaceSkyColours> SpaceSkyColours;
        [NMS(Index = 8)]
        /* 0x1BD0 */ public GcPhotoModeAdjustData CloudAdjust;
        [NMS(Index = 7)]
        /* 0x1BE0 */ public GcPhotoModeAdjustData FogAdjust;
        [NMS(Index = 9)]
        /* 0x1BF0 */ public GcPhotoModeAdjustData VignetteAdjust;
        [NMS(Index = 15)]
        /* 0x1C00 */ public Vector2f PhotoModeVignette;
        [NMS(Index = 66)]
        /* 0x1C08 */ public float AmbientFactor;
        [NMS(Index = 136)]
        /* 0x1C0C */ public float BinaryStarChance;
        [NMS(Index = 102)]
        /* 0x1C10 */ public float CloudColourH;
        [NMS(Index = 103)]
        /* 0x1C14 */ public float CloudColourS;
        [NMS(Index = 104)]
        /* 0x1C18 */ public float CloudColourV;
        [NMS(Index = 49)]
        /* 0x1C1C */ public float CloudCoverSmoothTime;
        [NMS(Index = 50)]
        /* 0x1C20 */ public float CloudRatioSmoothTime;
        [NMS(Index = 45)]
        /* 0x1C24 */ public float CreatureStormThreshold;
        [NMS(Index = 12)]
        /* 0x1C28 */ public int DayLength;
        [NMS(Index = 11)]
        /* 0x1C2C */ public float DayLengthSpookMultiplier;
        [NMS(Index = 47)]
        /* 0x1C30 */ public float ExtremeAudioLevel;
        [NMS(Index = 41)]
        /* 0x1C34 */ public float ForceFlightStrength;
        [NMS(Index = 114)]
        /* 0x1C38 */ public float ForceNightBlendValue;
        [NMS(Index = 23)]
        /* 0x1C3C */ public float ForceStormStrength;
        [NMS(Index = 21)]
        /* 0x1C40 */ public float FreshStartTimeOfDay;
        [NMS(Index = 65, MxmlName = "HeavyAirScale ")]
        /* 0x1C44 */ public float HeavyAirScale;
        [NMS(Index = 44)]
        /* 0x1C48 */ public float InFlightStormStrength;
        [NMS(Index = 119)]
        /* 0x1C4C */ public float LowFlightFogThreshold;
        [NMS(Index = 38)]
        /* 0x1C50 */ public float MaxCloudCover;
        [NMS(Index = 90)]
        /* 0x1C54 */ public float MaxColourS;
        [NMS(Index = 92)]
        /* 0x1C58 */ public float MaxColourV;
        [NMS(Index = 86)]
        /* 0x1C5C */ public float MaxFogSaturation;
        [NMS(Index = 88)]
        /* 0x1C60 */ public float MaxFogValue;
        [NMS(Index = 72)]
        /* 0x1C64 */ public float MaxNightFade;
        [NMS(Index = 144)]
        /* 0x1C68 */ public float MaxRainWetness;
        [NMS(Index = 82)]
        /* 0x1C6C */ public float MaxSaturation;
        [NMS(Index = 39)]
        /* 0x1C70 */ public float MaxStormCloudCover;
        [NMS(Index = 35)]
        /* 0x1C74 */ public float MaxStormLengthHigh;
        [NMS(Index = 33)]
        /* 0x1C78 */ public float MaxStormLengthLow;
        [NMS(Index = 78)]
        /* 0x1C7C */ public float MaxSunsetAtmosphereFade;
        [NMS(Index = 80)]
        /* 0x1C80 */ public float MaxSunsetColourFade;
        [NMS(Index = 68)]
        /* 0x1C84 */ public float MaxSunsetFade;
        [NMS(Index = 76)]
        /* 0x1C88 */ public float MaxSunsetFogFade;
        [NMS(Index = 70)]
        /* 0x1C8C */ public float MaxSunsetHorizonFade;
        [NMS(Index = 74)]
        /* 0x1C90 */ public float MaxSunsetPosFade;
        [NMS(Index = 31)]
        /* 0x1C94 */ public float MaxTimeBetweenStormsExtremeFallback;
        [NMS(Index = 29)]
        /* 0x1C98 */ public float MaxTimeBetweenStormsHigh;
        [NMS(Index = 27)]
        /* 0x1C9C */ public float MaxTimeBetweenStormsLow;
        [NMS(Index = 84)]
        /* 0x1CA0 */ public float MaxValue;
        [NMS(Index = 99)]
        /* 0x1CA4 */ public float MidColourH;
        [NMS(Index = 100)]
        /* 0x1CA8 */ public float MidColourS;
        [NMS(Index = 101)]
        /* 0x1CAC */ public float MidColourV;
        [NMS(Index = 89)]
        /* 0x1CB0 */ public float MinColourS;
        [NMS(Index = 91)]
        /* 0x1CB4 */ public float MinColourV;
        [NMS(Index = 85)]
        /* 0x1CB8 */ public float MinFogSaturation;
        [NMS(Index = 87)]
        /* 0x1CBC */ public float MinFogValue;
        [NMS(Index = 71)]
        /* 0x1CC0 */ public float MinNightFade;
        [NMS(Index = 81)]
        /* 0x1CC4 */ public float MinSaturation;
        [NMS(Index = 34)]
        /* 0x1CC8 */ public float MinStormLengthHigh;
        [NMS(Index = 32)]
        /* 0x1CCC */ public float MinStormLengthLow;
        [NMS(Index = 77)]
        /* 0x1CD0 */ public float MinSunsetAtmosphereFade;
        [NMS(Index = 79)]
        /* 0x1CD4 */ public float MinSunsetColourFade;
        [NMS(Index = 67)]
        /* 0x1CD8 */ public float MinSunsetFade;
        [NMS(Index = 75)]
        /* 0x1CDC */ public float MinSunsetFogFade;
        [NMS(Index = 69)]
        /* 0x1CE0 */ public float MinSunsetHorizonFade;
        [NMS(Index = 73)]
        /* 0x1CE4 */ public float MinSunsetPosFade;
        [NMS(Index = 30)]
        /* 0x1CE8 */ public float MinTimeBetweenStormsExtremeFallback;
        [NMS(Index = 28)]
        /* 0x1CEC */ public float MinTimeBetweenStormsHigh;
        [NMS(Index = 26)]
        /* 0x1CF0 */ public float MinTimeBetweenStormsLow;
        [NMS(Index = 83)]
        /* 0x1CF4 */ public float MinValue;
        [NMS(Index = 93)]
        /* 0x1CF8 */ public float MulticolourH;
        [NMS(Index = 95)]
        /* 0x1CFC */ public float NebulaColour1S;
        [NMS(Index = 96)]
        /* 0x1D00 */ public float NebulaColour1V;
        [NMS(Index = 97)]
        /* 0x1D04 */ public float NebulaColour2S;
        [NMS(Index = 98)]
        /* 0x1D08 */ public float NebulaColour2V;
        [NMS(Index = 94)]
        /* 0x1D0C */ public float NebulaColourH;
        [NMS(Index = 108)]
        /* 0x1D10 */ public float NightHorizonBlendMax;
        [NMS(Index = 107)]
        /* 0x1D14 */ public float NightHorizonBlendMin;
        [NMS(Index = 112)]
        /* 0x1D18 */ public float NightLightBlendMax;
        [NMS(Index = 111)]
        /* 0x1D1C */ public float NightLightBlendMin;
        [NMS(Index = 110)]
        /* 0x1D20 */ public float NightSkyBlendMax;
        [NMS(Index = 109)]
        /* 0x1D24 */ public float NightSkyBlendMin;
        [NMS(Index = 6)]
        /* 0x1D28 */ public float NightThreshold;
        [NMS(Index = 118)]
        /* 0x1D2C */ public float NoAtmosphereColourMax;
        [NMS(Index = 117)]
        /* 0x1D30 */ public float NoAtmosphereColourStrength;
        [NMS(Index = 116)]
        /* 0x1D34 */ public float NoAtmosphereFogMax;
        [NMS(Index = 115)]
        /* 0x1D38 */ public float NoAtmosphereFogStrength;
        [NMS(Index = 17)]
        /* 0x1D3C */ public float PhotoModeMacroMaxDOFAngle;
        [NMS(Index = 18)]
        /* 0x1D40 */ public float PhotoModeMacroMaxDOFAperture;
        [NMS(Index = 16)]
        /* 0x1D44 */ public float PhotoModeSunSpeed;
        [NMS(Index = 3)]
        /* 0x1D48 */ public float RainbowAlpha;
        [NMS(Index = 0)]
        /* 0x1D4C */ public float RainbowDistance;
        [NMS(Index = 5)]
        /* 0x1D50 */ public float RainbowFadeWidth;
        [NMS(Index = 1)]
        /* 0x1D54 */ public float RainbowScale;
        [NMS(Index = 4)]
        /* 0x1D58 */ public float RainbowStormAlpha;
        [NMS(Index = 2)]
        /* 0x1D5C */ public float RainbowWidth;
        [NMS(Index = 145)]
        /* 0x1D60 */ public float RainWetnessFadeInTime;
        [NMS(Index = 146)]
        /* 0x1D64 */ public float RainWetnessFadeOutTime;
        [NMS(Index = 105)]
        /* 0x1D68 */ public float SpaceAtmosphereThickness;
        [NMS(Index = 48)]
        /* 0x1D6C */ public float StormAudioLevel;
        [NMS(Index = 54)]
        /* 0x1D70 */ public float StormCloudBottomColourMaxBlend;
        [NMS(Index = 53)]
        /* 0x1D74 */ public float StormCloudBottomColourMinBlend;
        [NMS(Index = 55)]
        /* 0x1D78 */ public float StormCloudSmoothTime;
        [NMS(Index = 52)]
        /* 0x1D7C */ public float StormCloudTopColourMaxBlend;
        [NMS(Index = 51)]
        /* 0x1D80 */ public float StormCloudTopColourMinBlend;
        [NMS(Index = 25)]
        /* 0x1D84 */ public float StormScreenFilterDistance;
        [NMS(Index = 24)]
        /* 0x1D88 */ public float StormScreenFilterFadeTime;
        [NMS(Index = 37)]
        /* 0x1D8C */ public float StormTransitionTime;
        [NMS(Index = 36)]
        /* 0x1D90 */ public float StormWarningTime;
        [NMS(Index = 14)]
        /* 0x1D94 */ public float SunClampAngle;
        [NMS(Index = 46)]
        /* 0x1D98 */ public float TakeoffStormThreshold;
        [NMS(Index = 137)]
        /* 0x1D9C */ public float TernaryStarChance;
        [NMS(Index = 43)]
        /* 0x1DA0 */ public float ToFlightFadeTime;
        [NMS(Index = 42)]
        /* 0x1DA4 */ public float ToFootFadeTime;
        [NMS(Index = 106)]
        /* 0x1DA8 */ public float WaterHeavyAirAlpha;
        [NMS(Index = 138)]
        /* 0x1DAC */ public float WeatherBloomGain;
        [NMS(Index = 139)]
        /* 0x1DB0 */ public float WeatherBloomGainSpeed;
        [NMS(Index = 142)]
        /* 0x1DB4 */ public float WeatherBloomImpulseSpeed;
        [NMS(Index = 140)]
        /* 0x1DB8 */ public float WeatherBloomThreshold;
        [NMS(Index = 141)]
        /* 0x1DBC */ public float WeatherBloomThresholdSpeed;
        [NMS(Index = 20)]
        /* 0x1DC0 */ public float WeatherFilterSpaceTransitionChangeTime;
        [NMS(Index = 10)]
        /* 0x1DC4 */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        [NMS(Index = 40)]
        /* 0x1DC5 */ public bool ForceFlightSetting;
        [NMS(Index = 113)]
        /* 0x1DC6 */ public bool ForceNightBlend;
        [NMS(Index = 22)]
        /* 0x1DC7 */ public bool ForceStormSetting;
        [NMS(Index = 56)]
        /* 0x1DC8 */ public bool SleepSunFromSettings;
        [NMS(Index = 19)]
        /* 0x1DC9 */ public bool UpdateWeatherWhenSunLocked;
        [NMS(Index = 143)]
        /* 0x1DCA */ public TkCurveType WeatherBloomCurve;
    }
}

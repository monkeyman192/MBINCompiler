using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD885BCC1EB00B11F, NameHash = 0x20D1EBD0)]
    public class GcSkyGlobals : NMSTemplate
    {
        [NMS(Index = 121)]
        /* 0x0000 */ public GcPlanetSkyProperties PlanetPrimeProperties;
        [NMS(Index = 120)]
        /* 0x0770 */ public GcPlanetSkyProperties PlanetProperties;
        [NMS(Index = 122)]
        /* 0x0EE0 */ public GcFogProperties AbandonedFreighterFog;
        [NMS(Index = 126)]
        /* 0x10B0 */ public GcPlanetWeatherColourData NightSkyColours;
        [NMS(Index = 124)]
        /* 0x1170 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Index = 123)]
        /* 0x1210 */ public GcSpaceSkyProperties SpaceSkyMin;
        [NMS(Index = 64)]
        /* 0x12B0 */ public Colour AbandonedFreighterFogColour;
        [NMS(Index = 58)]
        /* 0x12C0 */ public Colour AsteroidColour;
        [NMS(Index = 59)]
        /* 0x12D0 */ public Colour DayLightColour;
        [NMS(Index = 61)]
        /* 0x12E0 */ public Colour DuskLightColour;
        [NMS(Index = 127)]
        /* 0x12F0 */ public Colour HeavyAirColour1;
        [NMS(Index = 128)]
        /* 0x1300 */ public Colour HeavyAirColour2;
        [NMS(Index = 131)]
        /* 0x1310 */ public Colour NightFogColour;
        [NMS(Index = 62)]
        /* 0x1320 */ public Colour NightHeavyAirColour;
        [NMS(Index = 132)]
        /* 0x1330 */ public Colour NightHeightFogColour;
        [NMS(Index = 129)]
        /* 0x1340 */ public Colour NightHorizonColour;
        [NMS(Index = 60)]
        /* 0x1350 */ public Colour NightLightColour;
        [NMS(Index = 130)]
        /* 0x1360 */ public Colour NightSkyColour;
        [NMS(Index = 56)]
        /* 0x1370 */ public Vector3f SleepSunFromSettingsPos;
        [NMS(Index = 63)]
        /* 0x1380 */ public Colour SpaceLightColour;
        [NMS(Index = 57)]
        /* 0x1390 */ public Vector3f SunPosition;
        [NMS(Index = 12)]
        /* 0x13A0 */ public Vector3f SunRotationAxis;
        [NMS(Index = 134)]
        /* 0x13B0 */ public GcPlanetCloudProperties PlanetCloudsMax;
        [NMS(Index = 133)]
        /* 0x13F8 */ public GcPlanetCloudProperties PlanetCloudsMin;
        [NMS(Index = 125)]
        /* 0x1440 */ public List<GcSpaceSkyColours> SpaceSkyColours;
        [NMS(Index = 8)]
        /* 0x1450 */ public GcPhotoModeAdjustData CloudAdjust;
        [NMS(Index = 7)]
        /* 0x1460 */ public GcPhotoModeAdjustData FogAdjust;
        [NMS(Index = 9)]
        /* 0x1470 */ public GcPhotoModeAdjustData VignetteAdjust;
        [NMS(Index = 14)]
        /* 0x1480 */ public Vector2f PhotoModeVignette;
        [NMS(Index = 66)]
        /* 0x1488 */ public float AmbientFactor;
        [NMS(Index = 135)]
        /* 0x148C */ public float BinaryStarChance;
        [NMS(Index = 102)]
        /* 0x1490 */ public float CloudColourH;
        [NMS(Index = 103)]
        /* 0x1494 */ public float CloudColourS;
        [NMS(Index = 104)]
        /* 0x1498 */ public float CloudColourV;
        [NMS(Index = 48)]
        /* 0x149C */ public float CloudCoverSmoothTime;
        [NMS(Index = 49)]
        /* 0x14A0 */ public float CloudRatioSmoothTime;
        [NMS(Index = 44)]
        /* 0x14A4 */ public float CreatureStormThreshold;
        [NMS(Index = 11)]
        /* 0x14A8 */ public int DayLength;
        [NMS(Index = 46)]
        /* 0x14AC */ public float ExtremeAudioLevel;
        [NMS(Index = 40)]
        /* 0x14B0 */ public float ForceFlightStrength;
        [NMS(Index = 114)]
        /* 0x14B4 */ public float ForceNightBlendValue;
        [NMS(Index = 22)]
        /* 0x14B8 */ public float ForceStormStrength;
        [NMS(Index = 20)]
        /* 0x14BC */ public float FreshStartTimeOfDay;
        [NMS(Index = 65)]
        /* 0x14C0 */ public float HeavyAirScale;
        [NMS(Index = 43)]
        /* 0x14C4 */ public float InFlightStormStrength;
        [NMS(Index = 119)]
        /* 0x14C8 */ public float LowFlightFogThreshold;
        [NMS(Index = 37)]
        /* 0x14CC */ public float MaxCloudCover;
        [NMS(Index = 90)]
        /* 0x14D0 */ public float MaxColourS;
        [NMS(Index = 92)]
        /* 0x14D4 */ public float MaxColourV;
        [NMS(Index = 86)]
        /* 0x14D8 */ public float MaxFogSaturation;
        [NMS(Index = 88)]
        /* 0x14DC */ public float MaxFogValue;
        [NMS(Index = 72)]
        /* 0x14E0 */ public float MaxNightFade;
        [NMS(Index = 143)]
        /* 0x14E4 */ public float MaxRainWetness;
        [NMS(Index = 82)]
        /* 0x14E8 */ public float MaxSaturation;
        [NMS(Index = 38)]
        /* 0x14EC */ public float MaxStormCloudCover;
        [NMS(Index = 34)]
        /* 0x14F0 */ public float MaxStormLengthHigh;
        [NMS(Index = 32)]
        /* 0x14F4 */ public float MaxStormLengthLow;
        [NMS(Index = 78)]
        /* 0x14F8 */ public float MaxSunsetAtmosphereFade;
        [NMS(Index = 80)]
        /* 0x14FC */ public float MaxSunsetColourFade;
        [NMS(Index = 68)]
        /* 0x1500 */ public float MaxSunsetFade;
        [NMS(Index = 76)]
        /* 0x1504 */ public float MaxSunsetFogFade;
        [NMS(Index = 70)]
        /* 0x1508 */ public float MaxSunsetHorizonFade;
        [NMS(Index = 74)]
        /* 0x150C */ public float MaxSunsetPosFade;
        [NMS(Index = 30)]
        /* 0x1510 */ public float MaxTimeBetweenStormsExtremeFallback;
        [NMS(Index = 28)]
        /* 0x1514 */ public float MaxTimeBetweenStormsHigh;
        [NMS(Index = 26)]
        /* 0x1518 */ public float MaxTimeBetweenStormsLow;
        [NMS(Index = 84)]
        /* 0x151C */ public float MaxValue;
        [NMS(Index = 99)]
        /* 0x1520 */ public float MidColourH;
        [NMS(Index = 100)]
        /* 0x1524 */ public float MidColourS;
        [NMS(Index = 101)]
        /* 0x1528 */ public float MidColourV;
        [NMS(Index = 89)]
        /* 0x152C */ public float MinColourS;
        [NMS(Index = 91)]
        /* 0x1530 */ public float MinColourV;
        [NMS(Index = 85)]
        /* 0x1534 */ public float MinFogSaturation;
        [NMS(Index = 87)]
        /* 0x1538 */ public float MinFogValue;
        [NMS(Index = 71)]
        /* 0x153C */ public float MinNightFade;
        [NMS(Index = 81)]
        /* 0x1540 */ public float MinSaturation;
        [NMS(Index = 33)]
        /* 0x1544 */ public float MinStormLengthHigh;
        [NMS(Index = 31)]
        /* 0x1548 */ public float MinStormLengthLow;
        [NMS(Index = 77)]
        /* 0x154C */ public float MinSunsetAtmosphereFade;
        [NMS(Index = 79)]
        /* 0x1550 */ public float MinSunsetColourFade;
        [NMS(Index = 67)]
        /* 0x1554 */ public float MinSunsetFade;
        [NMS(Index = 75)]
        /* 0x1558 */ public float MinSunsetFogFade;
        [NMS(Index = 69)]
        /* 0x155C */ public float MinSunsetHorizonFade;
        [NMS(Index = 73)]
        /* 0x1560 */ public float MinSunsetPosFade;
        [NMS(Index = 29)]
        /* 0x1564 */ public float MinTimeBetweenStormsExtremeFallback;
        [NMS(Index = 27)]
        /* 0x1568 */ public float MinTimeBetweenStormsHigh;
        [NMS(Index = 25)]
        /* 0x156C */ public float MinTimeBetweenStormsLow;
        [NMS(Index = 83)]
        /* 0x1570 */ public float MinValue;
        [NMS(Index = 93)]
        /* 0x1574 */ public float MulticolourH;
        [NMS(Index = 95)]
        /* 0x1578 */ public float NebulaColour1S;
        [NMS(Index = 96)]
        /* 0x157C */ public float NebulaColour1V;
        [NMS(Index = 97)]
        /* 0x1580 */ public float NebulaColour2S;
        [NMS(Index = 98)]
        /* 0x1584 */ public float NebulaColour2V;
        [NMS(Index = 94)]
        /* 0x1588 */ public float NebulaColourH;
        [NMS(Index = 108)]
        /* 0x158C */ public float NightHorizonBlendMax;
        [NMS(Index = 107)]
        /* 0x1590 */ public float NightHorizonBlendMin;
        [NMS(Index = 112)]
        /* 0x1594 */ public float NightLightBlendMax;
        [NMS(Index = 111)]
        /* 0x1598 */ public float NightLightBlendMin;
        [NMS(Index = 110)]
        /* 0x159C */ public float NightSkyBlendMax;
        [NMS(Index = 109)]
        /* 0x15A0 */ public float NightSkyBlendMin;
        [NMS(Index = 6)]
        /* 0x15A4 */ public float NightThreshold;
        [NMS(Index = 118)]
        /* 0x15A8 */ public float NoAtmosphereColourMax;
        [NMS(Index = 117)]
        /* 0x15AC */ public float NoAtmosphereColourStrength;
        [NMS(Index = 116)]
        /* 0x15B0 */ public float NoAtmosphereFogMax;
        [NMS(Index = 115)]
        /* 0x15B4 */ public float NoAtmosphereFogStrength;
        [NMS(Index = 16)]
        /* 0x15B8 */ public float PhotoModeMacroMaxDOFAngle;
        [NMS(Index = 17)]
        /* 0x15BC */ public float PhotoModeMacroMaxDOFAperture;
        [NMS(Index = 15)]
        /* 0x15C0 */ public float PhotoModeSunSpeed;
        [NMS(Index = 3)]
        /* 0x15C4 */ public float RainbowAlpha;
        [NMS(Index = 0)]
        /* 0x15C8 */ public float RainbowDistance;
        [NMS(Index = 5)]
        /* 0x15CC */ public float RainbowFadeWidth;
        [NMS(Index = 1)]
        /* 0x15D0 */ public float RainbowScale;
        [NMS(Index = 4)]
        /* 0x15D4 */ public float RainbowStormAlpha;
        [NMS(Index = 2)]
        /* 0x15D8 */ public float RainbowWidth;
        [NMS(Index = 144)]
        /* 0x15DC */ public float RainWetnessFadeInTime;
        [NMS(Index = 145)]
        /* 0x15E0 */ public float RainWetnessFadeOutTime;
        [NMS(Index = 105)]
        /* 0x15E4 */ public float SpaceAtmosphereThickness;
        [NMS(Index = 47)]
        /* 0x15E8 */ public float StormAudioLevel;
        [NMS(Index = 53)]
        /* 0x15EC */ public float StormCloudBottomColourMaxBlend;
        [NMS(Index = 52)]
        /* 0x15F0 */ public float StormCloudBottomColourMinBlend;
        [NMS(Index = 54)]
        /* 0x15F4 */ public float StormCloudSmoothTime;
        [NMS(Index = 51)]
        /* 0x15F8 */ public float StormCloudTopColourMaxBlend;
        [NMS(Index = 50)]
        /* 0x15FC */ public float StormCloudTopColourMinBlend;
        [NMS(Index = 24)]
        /* 0x1600 */ public float StormScreenFilterDistance;
        [NMS(Index = 23)]
        /* 0x1604 */ public float StormScreenFilterFadeTime;
        [NMS(Index = 36)]
        /* 0x1608 */ public float StormTransitionTime;
        [NMS(Index = 35)]
        /* 0x160C */ public float StormWarningTime;
        [NMS(Index = 13)]
        /* 0x1610 */ public float SunClampAngle;
        [NMS(Index = 45)]
        /* 0x1614 */ public float TakeoffStormThreshold;
        [NMS(Index = 136)]
        /* 0x1618 */ public float TernaryStarChance;
        [NMS(Index = 42)]
        /* 0x161C */ public float ToFlightFadeTime;
        [NMS(Index = 41)]
        /* 0x1620 */ public float ToFootFadeTime;
        [NMS(Index = 106)]
        /* 0x1624 */ public float WaterHeavyAirAlpha;
        [NMS(Index = 137)]
        /* 0x1628 */ public float WeatherBloomGain;
        [NMS(Index = 138)]
        /* 0x162C */ public float WeatherBloomGainSpeed;
        [NMS(Index = 141)]
        /* 0x1630 */ public float WeatherBloomImpulseSpeed;
        [NMS(Index = 139)]
        /* 0x1634 */ public float WeatherBloomThreshold;
        [NMS(Index = 140)]
        /* 0x1638 */ public float WeatherBloomThresholdSpeed;
        [NMS(Index = 19)]
        /* 0x163C */ public float WeatherFilterSpaceTransitionChangeTime;
        [NMS(Index = 10)]
        /* 0x1640 */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        [NMS(Index = 39)]
        /* 0x1641 */ public bool ForceFlightSetting;
        [NMS(Index = 113)]
        /* 0x1642 */ public bool ForceNightBlend;
        [NMS(Index = 21)]
        /* 0x1643 */ public bool ForceStormSetting;
        [NMS(Index = 55)]
        /* 0x1644 */ public bool SleepSunFromSettings;
        [NMS(Index = 18)]
        /* 0x1645 */ public bool UpdateWeatherWhenSunLocked;
        [NMS(Index = 142)]
        /* 0x1646 */ public TkCurveType WeatherBloomCurve;
    }
}

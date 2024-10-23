using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x99B904525A4E1E0E, NameHash = 0x20D1EBD0)]
    public class GcSkyGlobals : NMSTemplate
    {
        [NMS(Index = 122)]
        /* 0x0000 */ public GcPlanetSkyProperties PlanetPrimeProperties;
        [NMS(Index = 121)]
        /* 0x0770 */ public GcPlanetSkyProperties PlanetProperties;
        [NMS(Index = 123)]
        /* 0x0EE0 */ public GcFogProperties AbandonedFreighterFog;
        [NMS(Index = 127)]
        /* 0x10B0 */ public GcPlanetWeatherColourData NightSkyColours;
        [NMS(Index = 125)]
        /* 0x1170 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Index = 124)]
        /* 0x1210 */ public GcSpaceSkyProperties SpaceSkyMin;
        [NMS(Index = 65)]
        /* 0x12B0 */ public Colour AbandonedFreighterFogColour;
        [NMS(Index = 59)]
        /* 0x12C0 */ public Colour AsteroidColour;
        [NMS(Index = 60)]
        /* 0x12D0 */ public Colour DayLightColour;
        [NMS(Index = 62)]
        /* 0x12E0 */ public Colour DuskLightColour;
        [NMS(Index = 128)]
        /* 0x12F0 */ public Colour HeavyAirColour1;
        [NMS(Index = 129)]
        /* 0x1300 */ public Colour HeavyAirColour2;
        [NMS(Index = 132)]
        /* 0x1310 */ public Colour NightFogColour;
        [NMS(Index = 63)]
        /* 0x1320 */ public Colour NightHeavyAirColour;
        [NMS(Index = 133)]
        /* 0x1330 */ public Colour NightHeightFogColour;
        [NMS(Index = 130)]
        /* 0x1340 */ public Colour NightHorizonColour;
        [NMS(Index = 61)]
        /* 0x1350 */ public Colour NightLightColour;
        [NMS(Index = 131)]
        /* 0x1360 */ public Colour NightSkyColour;
        [NMS(Index = 57)]
        /* 0x1370 */ public Vector3f SleepSunFromSettingsPos;
        [NMS(Index = 64)]
        /* 0x1380 */ public Colour SpaceLightColour;
        [NMS(Index = 58)]
        /* 0x1390 */ public Vector3f SunPosition;
        [NMS(Index = 13)]
        /* 0x13A0 */ public Vector3f SunRotationAxis;
        [NMS(Index = 135)]
        /* 0x13B0 */ public GcPlanetCloudProperties PlanetCloudsMax;
        [NMS(Index = 134)]
        /* 0x13F8 */ public GcPlanetCloudProperties PlanetCloudsMin;
        [NMS(Index = 126)]
        /* 0x1440 */ public List<GcSpaceSkyColours> SpaceSkyColours;
        [NMS(Index = 8)]
        /* 0x1450 */ public GcPhotoModeAdjustData CloudAdjust;
        [NMS(Index = 7)]
        /* 0x1460 */ public GcPhotoModeAdjustData FogAdjust;
        [NMS(Index = 9)]
        /* 0x1470 */ public GcPhotoModeAdjustData VignetteAdjust;
        [NMS(Index = 15)]
        /* 0x1480 */ public Vector2f PhotoModeVignette;
        [NMS(Index = 67)]
        /* 0x1488 */ public float AmbientFactor;
        [NMS(Index = 136)]
        /* 0x148C */ public float BinaryStarChance;
        [NMS(Index = 103)]
        /* 0x1490 */ public float CloudColourH;
        [NMS(Index = 104)]
        /* 0x1494 */ public float CloudColourS;
        [NMS(Index = 105)]
        /* 0x1498 */ public float CloudColourV;
        [NMS(Index = 49)]
        /* 0x149C */ public float CloudCoverSmoothTime;
        [NMS(Index = 50)]
        /* 0x14A0 */ public float CloudRatioSmoothTime;
        [NMS(Index = 45)]
        /* 0x14A4 */ public float CreatureStormThreshold;
        [NMS(Index = 12)]
        /* 0x14A8 */ public int DayLength;
        [NMS(Index = 11)]
        /* 0x14AC */ public float DayLengthSpookMultiplier;
        [NMS(Index = 47)]
        /* 0x14B0 */ public float ExtremeAudioLevel;
        [NMS(Index = 41)]
        /* 0x14B4 */ public float ForceFlightStrength;
        [NMS(Index = 115)]
        /* 0x14B8 */ public float ForceNightBlendValue;
        [NMS(Index = 23)]
        /* 0x14BC */ public float ForceStormStrength;
        [NMS(Index = 21)]
        /* 0x14C0 */ public float FreshStartTimeOfDay;
        [NMS(Index = 66)]
        /* 0x14C4 */ public float HeavyAirScale;
        [NMS(Index = 44)]
        /* 0x14C8 */ public float InFlightStormStrength;
        [NMS(Index = 120)]
        /* 0x14CC */ public float LowFlightFogThreshold;
        [NMS(Index = 38)]
        /* 0x14D0 */ public float MaxCloudCover;
        [NMS(Index = 91)]
        /* 0x14D4 */ public float MaxColourS;
        [NMS(Index = 93)]
        /* 0x14D8 */ public float MaxColourV;
        [NMS(Index = 87)]
        /* 0x14DC */ public float MaxFogSaturation;
        [NMS(Index = 89)]
        /* 0x14E0 */ public float MaxFogValue;
        [NMS(Index = 73)]
        /* 0x14E4 */ public float MaxNightFade;
        [NMS(Index = 144)]
        /* 0x14E8 */ public float MaxRainWetness;
        [NMS(Index = 83)]
        /* 0x14EC */ public float MaxSaturation;
        [NMS(Index = 39)]
        /* 0x14F0 */ public float MaxStormCloudCover;
        [NMS(Index = 35)]
        /* 0x14F4 */ public float MaxStormLengthHigh;
        [NMS(Index = 33)]
        /* 0x14F8 */ public float MaxStormLengthLow;
        [NMS(Index = 79)]
        /* 0x14FC */ public float MaxSunsetAtmosphereFade;
        [NMS(Index = 81)]
        /* 0x1500 */ public float MaxSunsetColourFade;
        [NMS(Index = 69)]
        /* 0x1504 */ public float MaxSunsetFade;
        [NMS(Index = 77)]
        /* 0x1508 */ public float MaxSunsetFogFade;
        [NMS(Index = 71)]
        /* 0x150C */ public float MaxSunsetHorizonFade;
        [NMS(Index = 75)]
        /* 0x1510 */ public float MaxSunsetPosFade;
        [NMS(Index = 31)]
        /* 0x1514 */ public float MaxTimeBetweenStormsExtremeFallback;
        [NMS(Index = 29)]
        /* 0x1518 */ public float MaxTimeBetweenStormsHigh;
        [NMS(Index = 27)]
        /* 0x151C */ public float MaxTimeBetweenStormsLow;
        [NMS(Index = 85)]
        /* 0x1520 */ public float MaxValue;
        [NMS(Index = 100)]
        /* 0x1524 */ public float MidColourH;
        [NMS(Index = 101)]
        /* 0x1528 */ public float MidColourS;
        [NMS(Index = 102)]
        /* 0x152C */ public float MidColourV;
        [NMS(Index = 90)]
        /* 0x1530 */ public float MinColourS;
        [NMS(Index = 92)]
        /* 0x1534 */ public float MinColourV;
        [NMS(Index = 86)]
        /* 0x1538 */ public float MinFogSaturation;
        [NMS(Index = 88)]
        /* 0x153C */ public float MinFogValue;
        [NMS(Index = 72)]
        /* 0x1540 */ public float MinNightFade;
        [NMS(Index = 82)]
        /* 0x1544 */ public float MinSaturation;
        [NMS(Index = 34)]
        /* 0x1548 */ public float MinStormLengthHigh;
        [NMS(Index = 32)]
        /* 0x154C */ public float MinStormLengthLow;
        [NMS(Index = 78)]
        /* 0x1550 */ public float MinSunsetAtmosphereFade;
        [NMS(Index = 80)]
        /* 0x1554 */ public float MinSunsetColourFade;
        [NMS(Index = 68)]
        /* 0x1558 */ public float MinSunsetFade;
        [NMS(Index = 76)]
        /* 0x155C */ public float MinSunsetFogFade;
        [NMS(Index = 70)]
        /* 0x1560 */ public float MinSunsetHorizonFade;
        [NMS(Index = 74)]
        /* 0x1564 */ public float MinSunsetPosFade;
        [NMS(Index = 30)]
        /* 0x1568 */ public float MinTimeBetweenStormsExtremeFallback;
        [NMS(Index = 28)]
        /* 0x156C */ public float MinTimeBetweenStormsHigh;
        [NMS(Index = 26)]
        /* 0x1570 */ public float MinTimeBetweenStormsLow;
        [NMS(Index = 84)]
        /* 0x1574 */ public float MinValue;
        [NMS(Index = 94)]
        /* 0x1578 */ public float MulticolourH;
        [NMS(Index = 96)]
        /* 0x157C */ public float NebulaColour1S;
        [NMS(Index = 97)]
        /* 0x1580 */ public float NebulaColour1V;
        [NMS(Index = 98)]
        /* 0x1584 */ public float NebulaColour2S;
        [NMS(Index = 99)]
        /* 0x1588 */ public float NebulaColour2V;
        [NMS(Index = 95)]
        /* 0x158C */ public float NebulaColourH;
        [NMS(Index = 109)]
        /* 0x1590 */ public float NightHorizonBlendMax;
        [NMS(Index = 108)]
        /* 0x1594 */ public float NightHorizonBlendMin;
        [NMS(Index = 113)]
        /* 0x1598 */ public float NightLightBlendMax;
        [NMS(Index = 112)]
        /* 0x159C */ public float NightLightBlendMin;
        [NMS(Index = 111)]
        /* 0x15A0 */ public float NightSkyBlendMax;
        [NMS(Index = 110)]
        /* 0x15A4 */ public float NightSkyBlendMin;
        [NMS(Index = 6)]
        /* 0x15A8 */ public float NightThreshold;
        [NMS(Index = 119)]
        /* 0x15AC */ public float NoAtmosphereColourMax;
        [NMS(Index = 118)]
        /* 0x15B0 */ public float NoAtmosphereColourStrength;
        [NMS(Index = 117)]
        /* 0x15B4 */ public float NoAtmosphereFogMax;
        [NMS(Index = 116)]
        /* 0x15B8 */ public float NoAtmosphereFogStrength;
        [NMS(Index = 17)]
        /* 0x15BC */ public float PhotoModeMacroMaxDOFAngle;
        [NMS(Index = 18)]
        /* 0x15C0 */ public float PhotoModeMacroMaxDOFAperture;
        [NMS(Index = 16)]
        /* 0x15C4 */ public float PhotoModeSunSpeed;
        [NMS(Index = 3)]
        /* 0x15C8 */ public float RainbowAlpha;
        [NMS(Index = 0)]
        /* 0x15CC */ public float RainbowDistance;
        [NMS(Index = 5)]
        /* 0x15D0 */ public float RainbowFadeWidth;
        [NMS(Index = 1)]
        /* 0x15D4 */ public float RainbowScale;
        [NMS(Index = 4)]
        /* 0x15D8 */ public float RainbowStormAlpha;
        [NMS(Index = 2)]
        /* 0x15DC */ public float RainbowWidth;
        [NMS(Index = 145)]
        /* 0x15E0 */ public float RainWetnessFadeInTime;
        [NMS(Index = 146)]
        /* 0x15E4 */ public float RainWetnessFadeOutTime;
        [NMS(Index = 106)]
        /* 0x15E8 */ public float SpaceAtmosphereThickness;
        [NMS(Index = 48)]
        /* 0x15EC */ public float StormAudioLevel;
        [NMS(Index = 54)]
        /* 0x15F0 */ public float StormCloudBottomColourMaxBlend;
        [NMS(Index = 53)]
        /* 0x15F4 */ public float StormCloudBottomColourMinBlend;
        [NMS(Index = 55)]
        /* 0x15F8 */ public float StormCloudSmoothTime;
        [NMS(Index = 52)]
        /* 0x15FC */ public float StormCloudTopColourMaxBlend;
        [NMS(Index = 51)]
        /* 0x1600 */ public float StormCloudTopColourMinBlend;
        [NMS(Index = 25)]
        /* 0x1604 */ public float StormScreenFilterDistance;
        [NMS(Index = 24)]
        /* 0x1608 */ public float StormScreenFilterFadeTime;
        [NMS(Index = 37)]
        /* 0x160C */ public float StormTransitionTime;
        [NMS(Index = 36)]
        /* 0x1610 */ public float StormWarningTime;
        [NMS(Index = 14)]
        /* 0x1614 */ public float SunClampAngle;
        [NMS(Index = 46)]
        /* 0x1618 */ public float TakeoffStormThreshold;
        [NMS(Index = 137)]
        /* 0x161C */ public float TernaryStarChance;
        [NMS(Index = 43)]
        /* 0x1620 */ public float ToFlightFadeTime;
        [NMS(Index = 42)]
        /* 0x1624 */ public float ToFootFadeTime;
        [NMS(Index = 107)]
        /* 0x1628 */ public float WaterHeavyAirAlpha;
        [NMS(Index = 138)]
        /* 0x162C */ public float WeatherBloomGain;
        [NMS(Index = 139)]
        /* 0x1630 */ public float WeatherBloomGainSpeed;
        [NMS(Index = 142)]
        /* 0x1634 */ public float WeatherBloomImpulseSpeed;
        [NMS(Index = 140)]
        /* 0x1638 */ public float WeatherBloomThreshold;
        [NMS(Index = 141)]
        /* 0x163C */ public float WeatherBloomThresholdSpeed;
        [NMS(Index = 20)]
        /* 0x1640 */ public float WeatherFilterSpaceTransitionChangeTime;
        [NMS(Index = 10)]
        /* 0x1644 */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        [NMS(Index = 40)]
        /* 0x1645 */ public bool ForceFlightSetting;
        [NMS(Index = 114)]
        /* 0x1646 */ public bool ForceNightBlend;
        [NMS(Index = 22)]
        /* 0x1647 */ public bool ForceStormSetting;
        [NMS(Index = 56)]
        /* 0x1648 */ public bool SleepSunFromSettings;
        [NMS(Index = 19)]
        /* 0x1649 */ public bool UpdateWeatherWhenSunLocked;
        [NMS(Index = 143)]
        /* 0x164A */ public TkCurveType WeatherBloomCurve;
    }
}

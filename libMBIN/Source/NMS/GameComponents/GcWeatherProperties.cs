using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB5900D18FA98F6D, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Index = 24)]
        /* 0x2A0 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 26)]
        /* 0x2D0 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 9)]
        /* 0x300 */ public List<NMSString0x80> HeavyAir;
        [NMS(Index = 0)]
        /* 0x310 */ public NMSString0x10 Name;
        [NMS(Index = 20)]
        /* 0x320 */ public List<GcScreenFilters> StormFilterOptions;
        [NMS(Index = 8)]
        /* 0x330 */ public List<GcStormProperties> Storms;
        [NMS(Index = 27)]
        /* 0x340 */ public List<NMSString0x10> WeatherEffectsIds;
        [NMS(Index = 28)]
        /* 0x350 */ public List<NMSString0x10> WeatherHazardsIds;
        [NMS(Index = 5)]
        /* 0x360 */ public GcFogProperties ExtremeFog;
        [NMS(Index = 3)]
        /* 0x440 */ public GcFogProperties FlightFog;
        [NMS(Index = 2)]
        /* 0x520 */ public GcFogProperties Fog;
        [NMS(Index = 4)]
        /* 0x600 */ public GcFogProperties StormFog;
        [NMS(Index = 22)]
        /* 0x6E0 */ public GcSkyProperties Sky;
        [NMS(Index = 19, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x710 */ public GcHazardValues[] LifeSupportDrain;
        [NMS(Index = 18, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x738 */ public GcHazardValues[] Radiation;
        [NMS(Index = 14, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x760 */ public GcHazardValues[] Temperature;
        [NMS(Index = 16, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x788 */ public GcHazardValues[] Toxicity;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x7B0 */ public float[] RainbowChance;
        [NMS(Index = 12)]
        /* 0x7C0 */ public float ExtremeWeatherChance;
        [NMS(Index = 11)]
        /* 0x7C4 */ public float HighStormsChance;
        [NMS(Index = 10)]
        /* 0x7C8 */ public float LowStormsChance;
        [NMS(Index = 17)]
        /* 0x7CC */ public bool OverrideRadiation;
        [NMS(Index = 13)]
        /* 0x7CD */ public bool OverrideTemperature;
        [NMS(Index = 15)]
        /* 0x7CE */ public bool OverrideToxicity;
        [NMS(Index = 23)]
        /* 0x7CF */ public bool UseLightShaftProperties;
        [NMS(Index = 25)]
        /* 0x7D0 */ public bool UseStormLightShaftProperties;
        [NMS(Index = 1)]
        /* 0x7D1 */ public bool UseWeatherFog;
        [NMS(Index = 21)]
        /* 0x7D2 */ public bool UseWeatherSky;
    }
}

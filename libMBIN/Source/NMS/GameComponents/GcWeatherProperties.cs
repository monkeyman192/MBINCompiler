using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB5900D18FA98F6D, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        /* 0x2A0 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x2D0 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x300 */ public List<NMSString0x80> HeavyAir;
        /* 0x310 */ public NMSString0x10 Name;
        /* 0x320 */ public List<GcScreenFilters> StormFilterOptions;
        /* 0x330 */ public List<GcStormProperties> Storms;
        /* 0x340 */ public List<NMSString0x10> WeatherEffectsIds;
        /* 0x350 */ public List<NMSString0x10> WeatherHazardsIds;
        /* 0x360 */ public GcFogProperties ExtremeFog;
        /* 0x440 */ public GcFogProperties FlightFog;
        /* 0x520 */ public GcFogProperties Fog;
        /* 0x600 */ public GcFogProperties StormFog;
        /* 0x6E0 */ public GcSkyProperties Sky;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x710 */ public GcHazardValues[] LifeSupportDrain;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x738 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x760 */ public GcHazardValues[] Temperature;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x788 */ public GcHazardValues[] Toxicity;
        [NMS(Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x7B0 */ public float[] RainbowChance;
        /* 0x7C0 */ public float ExtremeWeatherChance;
        /* 0x7C4 */ public float HighStormsChance;
        /* 0x7C8 */ public float LowStormsChance;
        /* 0x7CC */ public bool OverrideRadiation;
        /* 0x7CD */ public bool OverrideTemperature;
        /* 0x7CE */ public bool OverrideToxicity;
        /* 0x7CF */ public bool UseLightShaftProperties;
        /* 0x7D0 */ public bool UseStormLightShaftProperties;
        /* 0x7D1 */ public bool UseWeatherFog;
        /* 0x7D2 */ public bool UseWeatherSky;
    }
}

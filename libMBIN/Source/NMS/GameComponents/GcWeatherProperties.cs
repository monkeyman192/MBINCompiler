using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFA3F3198B086BA8, NameHash = 0x0D216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public bool UseWeatherFog;
        /* 0x014 */ public GcFogProperties Fog;
        /* 0x0F4 */ public GcFogProperties FlightFog;
        /* 0x1D4 */ public GcFogProperties StormFog;
        /* 0x2B4 */ public GcFogProperties ExtremeFog;
        /* 0x3A0 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x640 */ public float[] RainbowChance;
        /* 0x650 */ public List<GcStormProperties> Storms;
        /* 0x660 */ public List<NMSString0x80> HeavyAir;
        /* 0x670 */ public float LowStormsChance;
        /* 0x674 */ public float HighStormsChance;
        /* 0x678 */ public float ExtremeWeatherChance;
        /* 0x67C */ public bool OverrideTemperature;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x680 */ public GcHazardValues[] Temperature;
        /* 0x6A8 */ public bool OverrideToxicity;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6AC */ public GcHazardValues[] Toxicity;
        /* 0x6D4 */ public bool OverrideRadiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6D8 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x700 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x728 */ public List<GcScreenFilters> StormFilterOptions;
        /* 0x738 */ public bool UseWeatherSky;
        /* 0x73C */ public GcSkyProperties Sky;
        /* 0x76C */ public bool UseLightShaftProperties;
        /* 0x770 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x7A0 */ public bool UseStormLightShaftProperties;
        /* 0x7B0 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x7E0 */ public List<NMSString0x10> WeatherEffectsIds;
        /* 0x7F0 */ public List<NMSString0x10> WeatherHazardsIds;
    }
}

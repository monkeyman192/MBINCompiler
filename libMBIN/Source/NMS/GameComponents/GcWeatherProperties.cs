using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x589540C65E43A573, NameHash = 0x51B5691)]
    public class GcWeatherProperties : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Index = 5)]
        /* 0x2A0 */ public GcFogProperties ExtremeFog;
        [NMS(Index = 3)]
        /* 0x470 */ public GcFogProperties FlightFog;
        [NMS(Index = 2)]
        /* 0x640 */ public GcFogProperties Fog;
        [NMS(Index = 4)]
        /* 0x810 */ public GcFogProperties StormFog;
        [NMS(Index = 25)]
        /* 0x9E0 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 27)]
        /* 0xA10 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 10)]
        /* 0xA40 */ public List<VariableSizeString> HeavyAir;
        [NMS(Index = 0)]
        /* 0xA50 */ public NMSString0x10 Name;
        [NMS(Index = 21)]
        /* 0xA60 */ public List<GcScreenFilters> StormFilterOptions;
        [NMS(Index = 9)]
        /* 0xA70 */ public List<GcStormProperties> Storms;
        [NMS(Index = 28)]
        /* 0xA80 */ public List<NMSString0x10> WeatherEffectsIds;
        [NMS(Index = 29)]
        /* 0xA90 */ public List<NMSString0x10> WeatherHazardsIds;
        [NMS(Index = 23)]
        /* 0xAA0 */ public GcSkyProperties Sky;
        [NMS(Index = 20, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xAD0 */ public GcHazardValues[] LifeSupportDrain;
        [NMS(Index = 19, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xAF8 */ public GcHazardValues[] Radiation;
        [NMS(Index = 15, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xB20 */ public GcHazardValues[] Temperature;
        [NMS(Index = 17, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xB48 */ public GcHazardValues[] Toxicity;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0xB70 */ public float[] RainbowChance;
        [NMS(Index = 13)]
        /* 0xB80 */ public float ExtremeWeatherChance;
        [NMS(Index = 12)]
        /* 0xB84 */ public float HighStormsChance;
        [NMS(Index = 11)]
        /* 0xB88 */ public float LowStormsChance;
        [NMS(Index = 6)]
        /* 0xB8C */ public float MaxStormFilterBlend;
        [NMS(Index = 18)]
        /* 0xB90 */ public bool OverrideRadiation;
        [NMS(Index = 14)]
        /* 0xB91 */ public bool OverrideTemperature;
        [NMS(Index = 16)]
        /* 0xB92 */ public bool OverrideToxicity;
        [NMS(Index = 24)]
        /* 0xB93 */ public bool UseLightShaftProperties;
        [NMS(Index = 26)]
        /* 0xB94 */ public bool UseStormLightShaftProperties;
        [NMS(Index = 1)]
        /* 0xB95 */ public bool UseWeatherFog;
        [NMS(Index = 22)]
        /* 0xB96 */ public bool UseWeatherSky;
    }
}

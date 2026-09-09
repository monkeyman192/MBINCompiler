using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54445C642476F08B, NameHash = 0x51B5691)]
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
        [NMS(Index = 27)]
        /* 0x9E0 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 29)]
        /* 0xA10 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 10)]
        /* 0xA40 */ public List<GcFilename> HeavyAir;
        [NMS(Index = 0)]
        /* 0xA50 */ public NMSString0x10 Name;
        [NMS(Index = 23)]
        /* 0xA60 */ public List<GcScreenFilters> StormFilterOptions;
        [NMS(Index = 9)]
        /* 0xA70 */ public List<GcStormProperties> Storms;
        [NMS(Index = 30)]
        /* 0xA80 */ public List<NMSString0x10> WeatherEffectsIds;
        [NMS(Index = 31)]
        /* 0xA90 */ public List<NMSString0x10> WeatherHazardsIds;
        [NMS(Index = 22, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xAA0 */ public GcHazardValues[] LifeSupportDrain;
        [NMS(Index = 19, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xAD0 */ public GcHazardValues[] Radiation;
        [NMS(Index = 25)]
        /* 0xB00 */ public GcSkyProperties Sky;
        [NMS(Index = 21, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xB30 */ public GcHazardValues[] SpookLevel;
        [NMS(Index = 15, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xB60 */ public GcHazardValues[] Temperature;
        [NMS(Index = 17, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0xB90 */ public GcHazardValues[] Toxicity;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0xBC0 */ public float[] RainbowChance;
        [NMS(Index = 13)]
        /* 0xBD0 */ public float ExtremeWeatherChance;
        [NMS(Index = 12)]
        /* 0xBD4 */ public float HighStormsChance;
        [NMS(Index = 11)]
        /* 0xBD8 */ public float LowStormsChance;
        [NMS(Index = 6)]
        /* 0xBDC */ public float MaxStormFilterBlend;
        [NMS(Index = 18)]
        /* 0xBE0 */ public bool OverrideRadiation;
        [NMS(Index = 20)]
        /* 0xBE1 */ public bool OverrideSpookLevel;
        [NMS(Index = 14)]
        /* 0xBE2 */ public bool OverrideTemperature;
        [NMS(Index = 16)]
        /* 0xBE3 */ public bool OverrideToxicity;
        [NMS(Index = 26)]
        /* 0xBE4 */ public bool UseLightShaftProperties;
        [NMS(Index = 28)]
        /* 0xBE5 */ public bool UseStormLightShaftProperties;
        [NMS(Index = 1)]
        /* 0xBE6 */ public bool UseWeatherFog;
        [NMS(Index = 24)]
        /* 0xBE7 */ public bool UseWeatherSky;
    }
}

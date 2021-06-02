using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x7F0, GUID = 0x48FA935D54F804FC, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public bool UseWeatherFog;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x011 */ public byte[] Padding11;
        /* 0x014 */ public GcFogProperties Fog;
        /* 0x0F0 */ public GcFogProperties FlightFog;
        /* 0x1CC */ public GcFogProperties StormFog;
        /* 0x2A8 */ public GcFogProperties ExtremeFog;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x384 */ public byte[] Padding384;
        /* 0x390 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x630 */ public float[] RainbowChance;
        /* 0x640 */ public List<GcStormProperties> Storms;
        /* 0x650 */ public List<NMSString0x80> HeavyAir;
        /* 0x660 */ public float LowStormsChance;
        /* 0x664 */ public float HighStormsChance;
        /* 0x668 */ public float ExtremeWeatherChance;
        /* 0x66C */ public bool OverrideTemperature;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x66D */ public byte[] Padding66D;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x670 */ public GcHazardValues[] Temperature;
        /* 0x698 */ public bool OverrideToxicity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x699 */ public byte[] Padding699;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x69C */ public GcHazardValues[] Toxicity;
        /* 0x6C4 */ public bool OverrideRadiation;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x6C5 */ public byte[] Padding6C5;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6C8 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6F0 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x718 */ public List<GcScreenFilters> StormFilterOptions;
        /* 0x728 */ public bool UseWeatherSky;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x729 */ public byte[] Padding729;
        /* 0x72C */ public GcSkyProperties Sky;
        /* 0x75C */ public bool UseLightShaftProperties;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x75D */ public byte[] Padding75D;
        /* 0x760 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x790 */ public bool UseStormLightShaftProperties;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x791 */ public byte[] Padding791;
        /* 0x7A0 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x7D0 */ public List<NMSString0x10> WeatherEffectsIds;
        /* 0x7E0 */ public List<NMSString0x10> WeatherHazardsIds;
    }
}

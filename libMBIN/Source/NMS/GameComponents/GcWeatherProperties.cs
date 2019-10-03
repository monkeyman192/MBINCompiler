using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x620, GUID = 0x19C3716EE76DF0A6, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;

        /* 0x010 */ public GcFogProperties Fog;
        /* 0x0EC */ public GcFogProperties FlightFog;
        /* 0x1C8 */ public GcFogProperties ExtremeFog;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A4 */ public byte[] Padding2A4;

        /* 0x2B0 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x520 */ public float[] RainbowChance;
        /* 0x530 */ public List<GcStormProperties> Storms;

        /* 0x540 */ public List<NMSString0x80> HeavyAir;

        /* 0x550 */ public float LowStormsChance;
        /* 0x554 */ public float HighStormsChance;
        /* 0x558 */ public float ExtremeWeatherChance;

        /* 0x55C */ public bool OverrideTemperature;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x55D */ public byte[] Padding55D;
        [NMS(Size = 0x5)]
        /* 0x560 */ public GcHazardValues[] Temperature;

        /* 0x588 */ public bool OverrideToxicity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x589 */ public byte[] Padding589;
        [NMS(Size = 0x5)]
        /* 0x58C */ public GcHazardValues[] Toxicity;

        /* 0x5B4 */ public bool OverrideRadiation;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5B5 */ public byte[] Padding5B5;
        [NMS(Size = 0x5)]
        /* 0x5B8 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5)]
        /* 0x5E0 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x608 */ public List<GcScreenFilters> StormFilterOptions;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x618 */ public byte[] EndPadding;
    }
}

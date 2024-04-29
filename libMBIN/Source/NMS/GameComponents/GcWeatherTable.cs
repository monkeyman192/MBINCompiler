using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1711417B669A69D, NameHash = 0x4452780AB55C81D6)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x00 */ public GcHazardValues[] DefaultRadiation;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x28 */ public GcHazardValues[] DefaultTemperature;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x50 */ public GcHazardValues[] DefaultToxicity;
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x78 */ public NMSString0x80[] Table;
    }
}

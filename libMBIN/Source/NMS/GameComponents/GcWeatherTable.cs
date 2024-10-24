using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3509F575EAE717CC, NameHash = 0x1754D309)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x000 */ public VariableSizeString[] Table;
        [NMS(Index = 3, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x100 */ public GcHazardValues[] DefaultRadiation;
        [NMS(Index = 4, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x128 */ public GcHazardValues[] DefaultSpookLevel;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x150 */ public GcHazardValues[] DefaultTemperature;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x178 */ public GcHazardValues[] DefaultToxicity;
    }
}

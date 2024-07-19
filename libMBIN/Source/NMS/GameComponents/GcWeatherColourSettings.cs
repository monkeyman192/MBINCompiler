using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4C090624F92161D, NameHash = 0x7B9648E8)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcWeatherColourSettingList[] PerBiomeSettings;
        [NMS(Index = 1)]
        /* 0x100 */ public GcWeatherColourSettingList DarkSettings;
        [NMS(Index = 0)]
        /* 0x110 */ public GcWeatherColourSettingList GenericSettings;
    }
}

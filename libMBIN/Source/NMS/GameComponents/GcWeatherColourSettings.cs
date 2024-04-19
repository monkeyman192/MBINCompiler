using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49916E75AC6E9D46, NameHash = 0x156BFFBB5A2228FA)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcWeatherColourSettingList[] PerBiomeSettings;
        /* 0x100 */ public GcWeatherColourSettingList GenericSettings;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A627E36AB6AB444, NameHash = 0x908843AB)]
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x0 */ public float[] WeatherWeightings;
    }
}

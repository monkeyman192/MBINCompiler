using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3694978110105288)]
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS( EnumType = typeof( GcWeatherOptions.WeatherEnum ) )]
        /* 0x380 */ public float[] WeatherWeightings;
    }
}

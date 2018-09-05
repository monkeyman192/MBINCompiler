namespace libMBIN.Models.Structs
{
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS(Size = 10, EnumValue = new string[10] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive", "RedWeather", "GreenWeather", "BlueWeather" })]
        /* 0x380 */ public float[] WeatherWeightings;
    }
}

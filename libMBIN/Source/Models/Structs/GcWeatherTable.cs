namespace libMBIN.Models.Structs
{
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Size = 10, EnumValue = new string[] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive", "RedWeather", "GreenWeather", "BlueWeather" })]
        public NMSString0x80[] Table;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultTemperature;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultToxicity;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultRadiation;
    }
}

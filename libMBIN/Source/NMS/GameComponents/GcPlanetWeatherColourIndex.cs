namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA7B02538E408CCA, NameHash = 0x711D9A36)]
    public class GcPlanetWeatherColourIndex : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Index;
        // size: 0x2
        public enum WeatherColourSetEnum : uint {
            Common,
            Rare,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public WeatherColourSetEnum WeatherColourSet;
    }
}

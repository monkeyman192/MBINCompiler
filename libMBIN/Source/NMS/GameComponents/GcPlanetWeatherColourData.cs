using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetWeatherColourData : NMSTemplate
    {
        public Colour SkyColour;
        public Colour SkyUpperColour;
        public Colour SkySolarColour;
        public Colour HorizonColour;
        public Colour SunColour;
        public Colour FogColour;
        public Colour HeightFogColour;

        [NMS(Size = 0x10)]
        public byte[] SkyGradientSpeed; // not sure what type this is?

        public Colour LightColour;
        public Colour CloudColour1;
        public Colour CloudColour2;
    }
}

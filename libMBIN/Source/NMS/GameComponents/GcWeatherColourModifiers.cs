using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x270, GUID = 0x53C079B61B3FB6A4, NameHash = 0x63BA6E198CA6237E)]
    public class GcWeatherColourModifiers : NMSTemplate
    {
        public GcColourModifier SkyColour;
        public GcColourModifier HorizonColour;
        public GcColourModifier SunColour;
        public GcColourModifier FogColour;
        public GcColourModifier HeightFogColour;
        public GcColourModifier LightColour;
        public GcColourModifier CloudColour1;
        public GcColourModifier CloudColour2;

        [NMS(Size = 5)]
        public GcColourModifier[] HeavyAirColour;
    }
}

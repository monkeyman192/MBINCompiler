namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79EC01ECC601AA7F, NameHash = 0xA699A80ACABBB3C5)]
    public class GcPlanetWeatherColourData : NMSTemplate
    {
        /* 0x00 */ public Colour CloudColour1;
        /* 0x10 */ public Colour CloudColour2;
        /* 0x20 */ public Colour FogColour;
        /* 0x30 */ public Colour HeightFogColour;
        /* 0x40 */ public Colour HorizonColour;
        /* 0x50 */ public Colour LightColour;
        /* 0x60 */ public Colour SkyColour;
        /* 0x70 */ public Vector3f SkyGradientSpeed;
        /* 0x80 */ public Colour SkySolarColour;
        /* 0x90 */ public Colour SkyUpperColour;
        /* 0xA0 */ public Colour SunColour;
    }
}

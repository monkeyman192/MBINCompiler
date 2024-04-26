namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79EC01ECC601AA7F, NameHash = 0xA699A80ACABBB3C5)]
    public class GcPlanetWeatherColourData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Colour CloudColour1;
        [NMS(Index = 10)]
        /* 0x10 */ public Colour CloudColour2;
        [NMS(Index = 5)]
        /* 0x20 */ public Colour FogColour;
        [NMS(Index = 6)]
        /* 0x30 */ public Colour HeightFogColour;
        [NMS(Index = 3)]
        /* 0x40 */ public Colour HorizonColour;
        [NMS(Index = 8)]
        /* 0x50 */ public Colour LightColour;
        [NMS(Index = 0)]
        /* 0x60 */ public Colour SkyColour;
        [NMS(Index = 7)]
        /* 0x70 */ public Vector3f SkyGradientSpeed;
        [NMS(Index = 2)]
        /* 0x80 */ public Colour SkySolarColour;
        [NMS(Index = 1)]
        /* 0x90 */ public Colour SkyUpperColour;
        [NMS(Index = 4)]
        /* 0xA0 */ public Colour SunColour;
    }
}

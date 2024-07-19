namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E4B36F3EC4F035C, NameHash = 0x1B787718)]
    public class GcPlanetWeatherColourData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Colour CloudColour1;
        [NMS(Index = 11)]
        /* 0x10 */ public Colour CloudColour2;
        [NMS(Index = 6)]
        /* 0x20 */ public Colour FogColour;
        [NMS(Index = 7)]
        /* 0x30 */ public Colour HeightFogColour;
        [NMS(Index = 4)]
        /* 0x40 */ public Colour HorizonColour;
        [NMS(Index = 9)]
        /* 0x50 */ public Colour LightColour;
        [NMS(Index = 1)]
        /* 0x60 */ public Colour SkyColour;
        [NMS(Index = 8)]
        /* 0x70 */ public Vector3f SkyGradientSpeed;
        [NMS(Index = 3)]
        /* 0x80 */ public Colour SkySolarColour;
        [NMS(Index = 2)]
        /* 0x90 */ public Colour SkyUpperColour;
        [NMS(Index = 5)]
        /* 0xA0 */ public Colour SunColour;
        [NMS(Index = 0)]
        /* 0xB0 */ public float SelectionWeighting;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FCFDB1505B25B0D, NameHash = 0x2C473DC1DB095F44)]
    public class GcSolarSystemSkyColourData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour BottomColour;
        [NMS(Index = 5)]
        /* 0x10 */ public Colour BottomColourPlanet;
        [NMS(Index = 6)]
        /* 0x20 */ public Colour CloudColour;
        [NMS(Index = 11)]
        /* 0x30 */ public Colour FogColour;
        [NMS(Index = 12)]
        /* 0x40 */ public Colour FogColour2;
        [NMS(Index = 7)]
        /* 0x50 */ public Colour LightColour;
        [NMS(Index = 1)]
        /* 0x60 */ public Colour MidColour;
        [NMS(Index = 4)]
        /* 0x70 */ public Colour MidColourPlanet;
        [NMS(Index = 8)]
        /* 0x80 */ public Colour NebulaColour1;
        [NMS(Index = 9)]
        /* 0x90 */ public Colour NebulaColour2;
        [NMS(Index = 10)]
        /* 0xA0 */ public Colour NebulaColour3;
        [NMS(Index = 0)]
        /* 0xB0 */ public Colour TopColour;
        [NMS(Index = 3)]
        /* 0xC0 */ public Colour TopColourPlanet;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD062CBADBAF836BC, NameHash = 0xD8B9D21F)]
    public class GcSpaceSkyColours : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour CloudColour;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour ColourBottom;
        [NMS(Index = 6)]
        /* 0x20 */ public Colour ColourBottomPlanet;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour ColourMid;
        [NMS(Index = 5)]
        /* 0x40 */ public Colour ColourMidPlanet;
        [NMS(Index = 1)]
        /* 0x50 */ public Colour ColourTop;
        [NMS(Index = 4)]
        /* 0x60 */ public Colour ColourTopPlanet;
        [NMS(Index = 12)]
        /* 0x70 */ public Colour FogColour;
        [NMS(Index = 13)]
        /* 0x80 */ public Colour FogColour2;
        [NMS(Index = 8)]
        /* 0x90 */ public Colour NebulaColour1;
        [NMS(Index = 9)]
        /* 0xA0 */ public Colour NebulaColour2;
        [NMS(Index = 10)]
        /* 0xB0 */ public Colour NebulaColour3;
        [NMS(Index = 11)]
        /* 0xC0 */ public Colour NebulaShadowColour;
        [NMS(Index = 7)]
        /* 0xD0 */ public Colour SunColour;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x59EFF0A74DA063C5, NameHash = 0x2C473DC1DB095F44)]
    public class GcSolarSystemSkyColourData : NMSTemplate       // size 0xD0
    {
	  /* 0x00 */ public Colour TopColour;
	  /* 0x10 */ public Colour MidColour;
	  /* 0x20 */ public Colour BottomColour;
	  /* 0x30 */ public Colour TopColourPlanet;
	  /* 0x40 */ public Colour MidColourPlanet;
	  /* 0x50 */ public Colour BottomColourPlanet;
	  /* 0x60 */ public Colour CloudColour;
	  /* 0x70 */ public Colour LightColour;
	  /* 0x80 */ public Colour NebulaColour1;
	  /* 0x90 */ public Colour NebulaColour2;
	  /* 0xA0 */ public Colour NebulaColour3;
      /* 0xB0 */ public Colour FogColour;
      /* 0xC0 */ public Colour FogColour2;
    }
}
using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x370)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public float Weighting;
        /* 0x004 */ public GcFogProperties Fog;
        /* 0x0E0 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Size = 0x4, EnumValue = new string[] { "Temperature", "Toxicity", "Radiation", "LifeSupportDrain" })]
        /* 0x350 */ public GcHazardValues[] HazardModifiers;        // meant to be a Vector2f. This looks nicer though in exml
    }
}

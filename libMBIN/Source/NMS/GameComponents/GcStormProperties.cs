using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x370, GUID = 0xF6C8A41B9F397C60, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public float Weighting;
        /* 0x004 */ public GcFogProperties Fog;
        /* 0x0E0 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x350 */ public GcHazardValues[] HazardModifiers;        // meant to be a Vector2f. This looks nicer though in exml
    }
}

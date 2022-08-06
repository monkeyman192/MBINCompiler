using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BF232BB98512763, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public float Weighting;
        /* 0x004 */ public GcFogProperties Fog;
        /* 0x0F0 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x390 */ public GcHazardValues[] HazardModifiers;        // meant to be a Vector2f. This looks nicer though in exml
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79230B2A49011935, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public GcWeatherColourModifiers ColourModifiers;
        /* 0x2A0 */ public GcFogProperties Fog;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x380 */ public Vector2f[] HazardModifiers;
        /* 0x3A8 */ public float Weighting;
    }
}

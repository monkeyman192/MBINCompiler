using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x353FC6022322D6D8, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Index = 1)]
        /* 0x2A0 */ public GcFogProperties Fog;
        [NMS(Index = 3, Size = 0x5, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x380 */ public Vector2f[] HazardModifiers;
        [NMS(Index = 0)]
        /* 0x3A8 */ public float Weighting;
    }
}

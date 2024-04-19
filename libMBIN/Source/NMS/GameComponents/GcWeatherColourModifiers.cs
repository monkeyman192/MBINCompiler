using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD425864C90EB0317, NameHash = 0x63BA6E198CA6237E)]
    public class GcWeatherColourModifiers : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x000 */ public GcColourModifier[] HeavyAirColour;
        /* 0x0F0 */ public GcColourModifier CloudColour1;
        /* 0x120 */ public GcColourModifier CloudColour2;
        /* 0x150 */ public GcColourModifier FogColour;
        /* 0x180 */ public GcColourModifier HeightFogColour;
        /* 0x1B0 */ public GcColourModifier HorizonColour;
        /* 0x1E0 */ public GcColourModifier LightColour;
        /* 0x210 */ public GcColourModifier SkyColour;
        /* 0x240 */ public GcColourModifier SkyUpperColour;
        /* 0x270 */ public GcColourModifier SunColour;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFC9306D3A83A449, NameHash = 0x63BA6E198CA6237E)]
    public class GcWeatherColourModifiers : NMSTemplate
    {
        [NMS(Index = 9, Size = 0x5)]
        /* 0x000 */ public GcColourModifier[] HeavyAirColour;
        [NMS(Index = 7)]
        /* 0x0F0 */ public GcColourModifier CloudColour1;
        [NMS(Index = 8)]
        /* 0x120 */ public GcColourModifier CloudColour2;
        [NMS(Index = 4)]
        /* 0x150 */ public GcColourModifier FogColour;
        [NMS(Index = 5)]
        /* 0x180 */ public GcColourModifier HeightFogColour;
        [NMS(Index = 2)]
        /* 0x1B0 */ public GcColourModifier HorizonColour;
        [NMS(Index = 6)]
        /* 0x1E0 */ public GcColourModifier LightColour;
        [NMS(Index = 0)]
        /* 0x210 */ public GcColourModifier SkyColour;
        [NMS(Index = 1)]
        /* 0x240 */ public GcColourModifier SkyUpperColour;
        [NMS(Index = 3)]
        /* 0x270 */ public GcColourModifier SunColour;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF80054E2AA7C77FE, NameHash = 0x95E6C4BF9139916C)]
    public class GcLightShaftProperties : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour LightShaftColourBottom;
        [NMS(Index = 5)]
        /* 0x10 */ public Colour LightShaftColourTop;
        [NMS(Index = 2)]
        /* 0x20 */ public float LightShaftBottom;
        [NMS(Index = 0)]
        /* 0x24 */ public float LightShaftScattering;
        [NMS(Index = 1)]
        /* 0x28 */ public float LightShaftStrength;
        [NMS(Index = 3)]
        /* 0x2C */ public float LightShaftTop;
    }
}

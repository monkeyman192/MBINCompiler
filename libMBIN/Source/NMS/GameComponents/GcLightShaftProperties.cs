namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF80054E2AA7C77FE, NameHash = 0x95E6C4BF9139916C)]
    public class GcLightShaftProperties : NMSTemplate
    {
        /* 0x00 */ public Colour LightShaftColourBottom;
        /* 0x10 */ public Colour LightShaftColourTop;
        /* 0x20 */ public float LightShaftBottom;
        /* 0x24 */ public float LightShaftScattering;
        /* 0x28 */ public float LightShaftStrength;
        /* 0x2C */ public float LightShaftTop;
    }
}

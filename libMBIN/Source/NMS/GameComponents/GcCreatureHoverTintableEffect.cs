namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE224BE025A4ECB8, NameHash = 0xFE54641DFEAF51F)]
    public class GcCreatureHoverTintableEffect : NMSTemplate
    {
        /* 0x00 */ public Colour TintColour;
        /* 0x10 */ public float LightStrength;
        /* 0x14 */ public float TintStrength;
        /* 0x18 */ public NMSString0x100 EffectNode;
    }
}

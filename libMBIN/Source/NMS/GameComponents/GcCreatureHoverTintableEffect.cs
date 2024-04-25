namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE224BE025A4ECB8, NameHash = 0xFE54641DFEAF51F)]
    public class GcCreatureHoverTintableEffect : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Colour TintColour;
        [NMS(Index = 1)]
        /* 0x10 */ public float LightStrength;
        [NMS(Index = 2)]
        /* 0x14 */ public float TintStrength;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x100 EffectNode;
    }
}

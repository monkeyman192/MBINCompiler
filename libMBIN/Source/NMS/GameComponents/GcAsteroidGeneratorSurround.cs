using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0845A22A01C777A, NameHash = 0xCBF9C66D539633AF)]
    public class GcAsteroidGeneratorSurround : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGeneratorAssignment Assignment;
        /* 0x48 */ public float LowerRadius;
        /* 0x4C */ public float NoiseApply;
        /* 0x50 */ public float NoiseOffset;
        /* 0x54 */ public float NoiseScale;
        /* 0x58 */ public float UpperRadius;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0845A22A01C777A, NameHash = 0xCBF9C66D539633AF)]
    public class GcAsteroidGeneratorSurround : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcAsteroidGeneratorAssignment Assignment;
        [NMS(Index = 1)]
        /* 0x48 */ public float LowerRadius;
        [NMS(Index = 5)]
        /* 0x4C */ public float NoiseApply;
        [NMS(Index = 3)]
        /* 0x50 */ public float NoiseOffset;
        [NMS(Index = 4)]
        /* 0x54 */ public float NoiseScale;
        [NMS(Index = 2)]
        /* 0x58 */ public float UpperRadius;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FEFBFE351911B, NameHash = 0x9E7EAF02)]
    public class GcAsteroidGeneratorSlab : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Rotation;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f Scale;
        [NMS(Index = 0)]
        /* 0x20 */ public GcAsteroidGeneratorAssignment Assignment;
        [NMS(Index = 5)]
        /* 0x68 */ public float NoiseApply;
        [NMS(Index = 3)]
        /* 0x6C */ public float NoiseOffset;
        [NMS(Index = 4)]
        /* 0x70 */ public float NoiseScale;
    }
}

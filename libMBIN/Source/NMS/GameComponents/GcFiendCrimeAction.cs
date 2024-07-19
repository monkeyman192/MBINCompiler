using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D4FC9BB2B22318A, NameHash = 0x1DAA352E)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FiendCrimeModifier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcFiendCrime FiendCrimeType;
    }
}

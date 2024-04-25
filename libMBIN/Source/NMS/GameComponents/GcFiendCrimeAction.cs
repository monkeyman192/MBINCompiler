using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7FF49F3C462B361B, NameHash = 0xDF042CD9CF0C561)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FiendCrimeModifier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcFiendCrime FiendCrimeType;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCD8B180A3CFDAD4, NameHash = 0xDF042CD9CF0C561)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FiendCrimeModifier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcFiendCrime FiendCrimeType;
    }
}

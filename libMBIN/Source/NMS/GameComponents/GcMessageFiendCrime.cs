using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1ADB4C1D39CBDB5F, NameHash = 0x37D134945C6DC0E)]
    public class GcMessageFiendCrime : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public GcFiendCrime FiendCrimeType;
        /* 0x14 */ public float Value;
        /* 0x18 */ public GcNodeID Victim;
    }
}

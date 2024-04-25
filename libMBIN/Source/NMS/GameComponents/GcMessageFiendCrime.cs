using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1ADB4C1D39CBDB5F, NameHash = 0x37D134945C6DC0E)]
    public class GcMessageFiendCrime : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x10 */ public GcFiendCrime FiendCrimeType;
        [NMS(Index = 3)]
        /* 0x14 */ public float Value;
        [NMS(Index = 1)]
        /* 0x18 */ public GcNodeID Victim;
    }
}

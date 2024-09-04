using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEE4AA58D09BCCC1, NameHash = 0x46E5F98)]
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

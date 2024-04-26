using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F900F22F934C37E, NameHash = 0xB88BA2B1282BE1C1)]
    public class GcNPCWorkerData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public Vector4f BaseOffset;
        [NMS(Index = 0)]
        /* 0x010 */ public GcResourceElement ResourceElement;
        [NMS(Index = 1)]
        /* 0x2B8 */ public GcSeed InteractionSeed;
        [NMS(Index = 4)]
        /* 0x2C8 */ public ulong BaseUA;
        [NMS(Index = 3)]
        /* 0x2D0 */ public bool FreighterBase;
        [NMS(Index = 2)]
        /* 0x2D1 */ public bool HiredWorker;
    }
}

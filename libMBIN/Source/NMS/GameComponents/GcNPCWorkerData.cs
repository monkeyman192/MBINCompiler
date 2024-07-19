using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7FF997A933D001F, NameHash = 0xACE695BE)]
    public class GcNPCWorkerData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector4f BaseOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public GcResourceElement ResourceElement;
        [NMS(Index = 1)]
        /* 0x58 */ public GcSeed InteractionSeed;
        [NMS(Index = 4)]
        /* 0x68 */ public ulong BaseUA;
        [NMS(Index = 3)]
        /* 0x70 */ public bool FreighterBase;
        [NMS(Index = 2)]
        /* 0x71 */ public bool HiredWorker;
    }
}

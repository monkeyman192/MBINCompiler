namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x2E0)]
    public class GcNPCWorkerData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ResourceElement;
        /* 0x2A8 */ public GcSeed InteractionSeed;
        /* 0x2B8 */ public bool HiredWorker;
        /* 0x2B9 */ public bool FreighterBase;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2BA */ public byte[] Padding2BA;
        /* 0x2C0 */ public ulong BaseUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2C8 */ public byte[] Padding2C8;
        /* 0x2D0 */ public Vector4f BaseOffset;
    }
}

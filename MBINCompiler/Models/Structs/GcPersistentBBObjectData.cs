namespace MBINCompiler.Models.Structs
{
    public class GcPersistentBBObjectData : NMSTemplate // size = 0x60
    {
        /* 0x00 */ public ulong Timestamp;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string ObjectId;
        /* 0x18 */ public ulong GalacticAddress;
        /* 0x20 */ public ulong RegionSeed;
        /* 0x28 */ public ulong UserData;
        /* 0x30 */ public Vector4f Position;
        /* 0x40 */ public Vector4f Up;
        /* 0x50 */ public Vector4f At;
    }
}

using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPersistentBase : NMSTemplate // size = 0x40
    {
        /* 0x00 */ public ulong GalacticAddress;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public Vector4f Position;
        /* 0x20 */ public ulong UserData;
        /* 0x28 */ public List<GcPersistentBaseEntry> Objects;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x38 */ public byte[] Padding38;
    }
}

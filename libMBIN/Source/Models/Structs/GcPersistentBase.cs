using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1A0)]
    public class GcPersistentBase : NMSTemplate
    {
        /* 0x000 */ public int BaseVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public ulong GalacticAddress;
        /* 0x010 */ public Vector4f Position;
        /* 0x020 */ public Vector4f Forward;
        /* 0x030 */ public ulong UserData;
        /* 0x038 */ public ulong LastUpdateTimestamp;
        /* 0x040 */ public List<GcPersistentBaseEntry> Objects;

        [NMS(Size = 0x40)]
        /* 0x050 */ public string RID;
        /* 0x090 */ public GcDiscoveryOwner Owner;
        [NMS(Size = 0x40)]
        /* 0x154 */ public string Name;
        /* 0x194 */ public GcPersistentBaseTypes BaseType;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}

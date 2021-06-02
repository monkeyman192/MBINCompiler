using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0xFD90E327F71AB0E7, NameHash = 0xD040D4124F0456EF)]
    public class GcPersistentBaseEntry : NMSTemplate        // size: 0x90
    {
        /* 0x00 */ public ulong Timestamp;
        /* 0x08 */ public NMSString0x10 ObjectId;
        /* 0x18 */ public ulong UserData;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Up;
        /* 0x40 */ public Vector4f At;
        /* 0x50 */ public NMSString0x40 Message;
    }
}
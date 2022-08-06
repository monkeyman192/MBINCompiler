using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFD90E327F71AB0E7, NameHash = 0xD040D4124F0456EF)]
    public class GcPersistentBaseEntry : NMSTemplate
    {
        /* 0x00 */ public ulong Timestamp;
        /* 0x08 */ public NMSString0x10 ObjectID;
        /* 0x18 */ public ulong UserData;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public Vector3f At;
        /* 0x50 */ public NMSString0x40 Message;
    }
}
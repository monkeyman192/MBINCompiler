using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x534F1EAF42644C4A, NameHash = 0x34A3DF6D998CE015)]
    public class GcAtlasSendRequestBlob : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public NMSString0x20 Name;
        /* 0x30 */ public int LastTimestamp;
        /* 0x34 */ public NMSString0x40 Tracker;
    }
}

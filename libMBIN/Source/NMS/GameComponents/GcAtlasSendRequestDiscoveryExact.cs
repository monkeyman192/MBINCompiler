using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79B8FBAA3C146C56, NameHash = 0x3904A7723855ABD2)]
    public class GcAtlasSendRequestDiscoveryExact : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public GcAtlasDiscoveryData Data;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C7C6013F8BCE2AB, NameHash = 0xD72094BF19B7E9ED)]
    public class GcAtlasRecvDiscoveryExact : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public bool Discovered;
        /* 0x20 */ public GcAtlasDiscovery Data;
    }
}

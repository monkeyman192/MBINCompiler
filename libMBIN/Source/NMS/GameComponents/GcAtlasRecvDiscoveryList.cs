using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D3F6BF513471E7F, NameHash = 0x2A5A7D37C0DB81BA)]
    public class GcAtlasRecvDiscoveryList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfThings;
        [NMS(Size = 0x258)]
        /* 0x20 */ public GcAtlasDiscovery[] ThingsFound;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x6E2A0, GUID = 0x9D3F6BF513471E7F, NameHash = 0x2A5A7D37C0DB81BA)]
    public class GcAtlasRecvDiscoveryList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] padding8;
        /* 0x10 */ public int NumberOfThings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x258)]
        /* 0x20 */ public GcAtlasDiscovery[] ThingsFound;
    }
}

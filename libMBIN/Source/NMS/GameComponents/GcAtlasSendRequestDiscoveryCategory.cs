using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xDBD1F2229D6AD49E, NameHash = 0x2411F6998437DA11)]
    public class GcAtlasSendRequestDiscoveryCategory : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public GcDiscoveryTypes Type;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}

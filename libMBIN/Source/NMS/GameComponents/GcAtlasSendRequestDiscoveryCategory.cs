using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9102AD934E34EED9, NameHash = 0x2411F6998437DA11)]
    public class GcAtlasSendRequestDiscoveryCategory : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        /* 0x28 */ public GcDiscoveryTypes Type;
    }
}

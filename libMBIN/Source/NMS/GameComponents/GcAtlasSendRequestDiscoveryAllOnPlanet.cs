using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xAA2968A35BA5A5A8, NameHash = 0xCED5BF08E5CDDB1D)]
    public class GcAtlasSendRequestDiscoveryAllOnPlanet : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public GcUniverseAddressData UniverseAddress;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DFEB50FEF29FC7C, NameHash = 0xCED5BF08E5CDDB1D)]
    public class GcAtlasSendRequestDiscoveryAllOnPlanet : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
    }
}

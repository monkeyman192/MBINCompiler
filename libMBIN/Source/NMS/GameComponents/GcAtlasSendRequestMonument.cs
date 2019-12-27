using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x5310C68E39112DCD, NameHash = 0xA1E5685D1420D1B2)]
    public class GcAtlasSendRequestMonument : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public GcUniverseAddressData UniverseAddress;
    }
}

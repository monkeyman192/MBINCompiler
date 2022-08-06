using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x07B0C9934C1CF50C, NameHash = 0x80557C8FB358D447)]
    public class GcAtlasSendRequestVoxel : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
    }
}

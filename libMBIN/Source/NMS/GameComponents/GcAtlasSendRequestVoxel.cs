using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x0DC4377A82BEB2E0, NameHash = 0x80557C8FB358D447)]
    public class GcAtlasSendRequestVoxel : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public GcUniverseAddressData UniverseAddress;
    }
}

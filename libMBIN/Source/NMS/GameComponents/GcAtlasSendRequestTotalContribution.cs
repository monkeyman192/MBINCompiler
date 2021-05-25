using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x3D02503C2F082AFF, NameHash = 0x43DB1432B149AF84)] //, Alignment = 0x8
    public class GcAtlasSendRequestTotalContribution : NMSTemplate {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
    }

}

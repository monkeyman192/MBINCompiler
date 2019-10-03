using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x2AB1F937E05FEC75, NameHash = 0x4AF1E9D7AD4CC1C7)]
    public class GcMaintenanceContainer : NMSTemplate
    {
        /* 0x00 */ public GcInventoryContainer InventoryContainer;
        /* 0x60 */ public ulong LastUpdateTimestamp;
        /* 0x68 */ public ulong LastCompletedTimestamp;
        /* 0x70 */ public ulong LastBrokenTimestamp;
        /* 0x78 */ public List<float> DamageTimers;
        /* 0x88 */ public uint Flags;
    }
}

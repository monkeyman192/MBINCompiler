using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2771929CD6380A2, NameHash = 0x4AF1E9D7AD4CC1C7)]
    public class GcMaintenanceContainer : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer InventoryContainer;
        /* 0x160 */ public ulong LastUpdateTimestamp;
        /* 0x168 */ public ulong LastCompletedTimestamp;
        /* 0x170 */ public ulong LastBrokenTimestamp;
        /* 0x178 */ public List<float> DamageTimers;
        /* 0x188 */ public List<float> AmountAccumulators;
        /* 0x198 */ public ushort Flags;
    }
}

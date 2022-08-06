using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F4BACCB2B321B30, NameHash = 0x326E60B60CAEEFA6)]
    public class GcSentinelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Resource;
        /* 0x80 */ public int BaseHealth;
        /* 0x84 */ public int HealthIncreasePerLevel;
        /* 0x88 */ public float RepairTime;
        /* 0x8C */ public float RepairThreshold;
    }
}

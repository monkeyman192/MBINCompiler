using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A01D3B8282C7E65, NameHash = 0xB8C015B2B3985468)]
    public class GcSentinelSpawnData : NMSTemplate
    {
        /* 0x0 */ public GcSentinelTypes Type;
        /* 0x4 */ public int MinAmount;
        /* 0x8 */ public int MaxAmount;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD92ADFE549146DF4, NameHash = 0xBB8457797F0508AB)]
    public class GcMultitoolPoolData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 File;
        /* 0x80 */ public int MinDraw;
        /* 0x84 */ public int MaxDraw;
        /* 0x88 */ public float PoolProbability;
        /* 0x8C */ public bool PoolIsSecret;
    }
}

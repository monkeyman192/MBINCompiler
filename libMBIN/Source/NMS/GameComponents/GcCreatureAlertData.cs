using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2268109565EC7291, NameHash = 0xFFF2D3D18F84C008)]
    public class GcCreatureAlertData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureTypes AlertTarget;
		/* 0x04 */ public GcCreatureTypes AlertInitiator;
		/* 0x08 */ public float HearingRange;              // 42C80000h
		/* 0x0C */ public float SightRange;                // 43160000h
		/* 0x10 */ public float SightAngle;                // 42700000h
		/* 0x14 */ public float FleeRange;                 // 41700000h
    }
}

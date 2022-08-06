using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CD1096F981F94BC, NameHash = 0x29C73977774C3241)]
    public class GcStateTimeEvent : NMSTemplate
    {
        /* 0x0 */ public float Seconds;
        /* 0x4 */ public float RandomSeconds;
        /* 0x8 */ public bool UseMissionClock;
    }
}

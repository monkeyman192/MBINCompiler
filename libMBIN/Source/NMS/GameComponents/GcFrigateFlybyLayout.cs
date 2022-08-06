using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF61A2AADC59DCA16, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        /* 0x00 */ public GcFrigateFlybyType FlybyType;
        /* 0x04 */ public float InitialSpeed;
        /* 0x08 */ public float TargetSpeed;
        /* 0x0C */ public float InterestTime;
        /* 0x10 */ public float InterestDistance;
        /* 0x18 */ public List<GcFrigateFlybyOption> Frigates;
    }
}

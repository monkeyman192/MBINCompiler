using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDDA826D0D091C6EF, NameHash = 0x523281BEC01AA0F4)]
    public class TkParticleBurstData : NMSTemplate
    {
        /* 0x00 */ public TkEmitterFloatProperty BurstAmount;
        /* 0x2C */ public TkEmitterFloatProperty BurstInterval;
        /* 0x58 */ public int LoopCount;
    }
}

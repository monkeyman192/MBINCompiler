using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9003B7393B151C5E, NameHash = 0xE81087792E50B0E9)]
    public class GcMessageUpdateFrigateSpeed : NMSTemplate
    {
        /* 0x0 */ public float StartSpeed;
        /* 0x4 */ public float TargetSpeed;
    }
}

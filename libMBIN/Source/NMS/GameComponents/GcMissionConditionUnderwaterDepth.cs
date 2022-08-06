using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AFAB998CDB60C14, NameHash = 0x84273D91716DB052)]
    public class GcMissionConditionUnderwaterDepth : NMSTemplate
    {
        /* 0x0 */ public float Depth;
        /* 0x4 */ public bool TakeAmountFromSeasonData;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DAC5CD2F7B112FA, NameHash = 0x3083BCFB99A561CE)]
    public class GcMissionConditionHasIllegalGoods : NMSTemplate
    {
        /* 0x0 */ public bool IncludeNipNip;
    }
}

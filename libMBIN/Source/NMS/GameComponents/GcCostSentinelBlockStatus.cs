using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CE3F876DE12D5C2, NameHash = 0x74C427160A48E77F)]
    public class GcCostSentinelBlockStatus : NMSTemplate
    {
        public bool CanAffordIfSentinelsDisabled;
    }
}

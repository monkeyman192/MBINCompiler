using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE95AE1F0427E5459, NameHash = 0x69E9FB65CE773F84)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum { Start, GroundStorey, RegularStorey, Roof, Decoration, Other }
        /* 0x0 */ public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}

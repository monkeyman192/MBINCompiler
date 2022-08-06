using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2BB31AC467459AD, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        /* 0x00 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x48 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
    }
}

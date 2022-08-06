using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51ECC77CDE2127ED, NameHash = 0x59344CCB9E9B831E)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        /* 0x0 */ public List<GcBuildingClassification> ValidBuildings;
    }
}

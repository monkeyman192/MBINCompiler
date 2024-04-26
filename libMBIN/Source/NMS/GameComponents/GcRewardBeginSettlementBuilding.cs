using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FB2607EE7E11E56, NameHash = 0x59344CCB9E9B831E)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBuildingClassification> ValidBuildings;
    }
}

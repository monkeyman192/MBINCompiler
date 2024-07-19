using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82BF71DF47FE2E1B, NameHash = 0x5E8D0251)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBuildingClassification> ValidBuildings;
    }
}

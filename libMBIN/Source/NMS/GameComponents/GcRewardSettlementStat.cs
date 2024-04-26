using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CA3D6ACB985D077, NameHash = 0x156A8A17D82AA9E8)]
    public class GcRewardSettlementStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatChange StatToAward;
        [NMS(Index = 1)]
        /* 0x8 */ public bool Silent;
    }
}

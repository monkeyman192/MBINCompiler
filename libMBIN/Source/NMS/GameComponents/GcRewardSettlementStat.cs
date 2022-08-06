using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D59A7647C08C7D3, NameHash = 0x156A8A17D82AA9E8)]
    public class GcRewardSettlementStat : NMSTemplate
    {
        /* 0x0 */ public GcSettlementStatChange StatToAward;
        /* 0x8 */ public bool Silent;
    }
}

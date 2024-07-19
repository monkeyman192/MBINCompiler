using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BEF3A5956CD4042, NameHash = 0xAC3B9854)]
    public class GcRewardMoney : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x8 */ public GcCurrency Currency;
        [NMS(Index = 2)]
        /* 0xC */ public bool RoundNumber;
    }
}

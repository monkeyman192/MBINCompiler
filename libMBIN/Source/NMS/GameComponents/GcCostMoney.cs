using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x382C12C858ADEAC4, NameHash = 0x16B41518)]
    public class GcCostMoney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Cost;
        [NMS(Index = 1)]
        /* 0x4 */ public GcCurrency CostCurrency;
    }
}

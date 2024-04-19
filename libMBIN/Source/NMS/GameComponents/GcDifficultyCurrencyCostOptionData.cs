using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66A507799BC31D19, NameHash = 0x9061069311B1AB2E)]
    public class GcDifficultyCurrencyCostOptionData : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcCurrency.CurrencyEnum))]
        /* 0x00 */ public float[] Multipliers;
        /* 0x0C */ public float TradeBuyPriceMarkupMod;
        // size: 0x3
        public enum FreeCostTypesEnum {
            Currency,
            Substance,
            Product,
        }
        [NMS(Size = 0x3, EnumType = typeof(FreeCostTypesEnum))]
        /* 0x10 */ public bool[] FreeCostTypes;
        /* 0x13 */ public bool CostManagerCostsAreFree;
        /* 0x14 */ public bool InteractionsCostsAreFree;
    }
}

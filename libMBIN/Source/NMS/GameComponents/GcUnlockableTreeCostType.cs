using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35B9E521B8A19330, NameHash = 0x702F7B1A0F3F0830)]
    public class GcUnlockableTreeCostType : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CantAffordString;
        /* 0x20 */ public NMSString0x10 CostTypeID;
        /* 0x30 */ public NMSString0x10 TypeID;
        /* 0x40 */ public GcCurrency CurrencyType;
        // size: 0x3
        public enum TypeOfCostEnum : uint {
            Currency,
            Substance,
            Product,
        }
        /* 0x44 */ public TypeOfCostEnum TypeOfCost;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC499E7E56D70C487, NameHash = 0xA572AC56)]
    public class GcUnlockableTreeCostType : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A CantAffordString;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 CostTypeID;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 TypeID;
        [NMS(Index = 2)]
        /* 0x40 */ public GcCurrency CurrencyType;
        // size: 0x3
        public enum TypeOfCostEnum : uint {
            Currency,
            Substance,
            Product,
        }
        [NMS(Index = 1)]
        /* 0x44 */ public TypeOfCostEnum TypeOfCost;
    }
}

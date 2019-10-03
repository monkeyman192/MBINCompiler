using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA62D744802B00946, NameHash = 0x702F7B1A0F3F0830)]
    public class GcUnlockableTreeCostType : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string CostTypeID;
        public enum TypeOfCostEnum { Currency, Substance, Product}
        /* 0x10 */ public TypeOfCostEnum TypeOfCost;
        /* 0x14 */ public GcCurrency Currency;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string TypeID;
    }
}

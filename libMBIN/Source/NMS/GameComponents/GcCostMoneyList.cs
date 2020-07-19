using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, Alignment = 0x8, GUID = 0x5945CFE26E9A5BFC, NameHash = 0x22A3BF55F268EEBE)]
    public class GcCostMoneyList : NMSTemplate
    {
        public List<int> Costs;
        public GcCurrency CostCurrency;
        public bool AssertIfOutOfBounds;
        public enum OutOfBoundsBehaviourEnum { NoCost, UseFirst, UseLast }
        public OutOfBoundsBehaviourEnum OutOfBoundsBehaviour;
        public enum IndexProviderEnum { None, ShipSlot, ShipClass, DailyFreighters }
        public IndexProviderEnum IndexProvider;
    }
}

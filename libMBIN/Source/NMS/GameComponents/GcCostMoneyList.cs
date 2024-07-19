using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D17FD0036689587, NameHash = 0x31448DA6)]
    public class GcCostMoneyList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<int> Costs;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCurrency CostCurrency;
        // size: 0x9
        public enum IndexProviderEnum : uint {
            None,
            ShipSlot,
            ShipClass,
            DailyFreighters,
            WeaponClass,
            WeaponSlot,
            PetSlot,
            PilotSlot,
            PilotRank,
        }
        [NMS(Index = 4)]
        /* 0x14 */ public IndexProviderEnum IndexProvider;
        // size: 0x3
        public enum OutOfBoundsBehaviourEnum : uint {
            NoCost,
            UseFirst,
            UseLast,
        }
        [NMS(Index = 3)]
        /* 0x18 */ public OutOfBoundsBehaviourEnum OutOfBoundsBehaviour;
        [NMS(Index = 2)]
        /* 0x1C */ public bool AssertIfOutOfBounds;
    }
}

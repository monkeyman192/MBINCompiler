using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BE8D39553D453D, NameHash = 0x2B7022C0)]
    public class GcCostItemListIndexed : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> Costs;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        // size: 0x3
        public enum ItemIndexProviderEnum : uint {
            None,
            Biome,
            SubBiome,
        }
        [NMS(Index = 4)]
        /* 0x14 */ public ItemIndexProviderEnum ItemIndexProvider;
        // size: 0x3
        public enum ItemOutOfBoundsBehaviourEnum : uint {
            NoCost,
            UseFirst,
            UseLast,
        }
        [NMS(Index = 3)]
        /* 0x18 */ public ItemOutOfBoundsBehaviourEnum ItemOutOfBoundsBehaviour;
        [NMS(Index = 2)]
        /* 0x1C */ public bool AssertIfOutOfBounds;
    }
}

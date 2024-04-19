using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C8007CCCC34B3A4, NameHash = 0xA57C34B1B939D649)]
    public class GcCostItemListIndexed : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Costs;
        /* 0x10 */ public int Amount;
        // size: 0x3
        public enum ItemIndexProviderEnum : uint {
            None,
            Biome,
            SubBiome,
        }
        /* 0x14 */ public ItemIndexProviderEnum ItemIndexProvider;
        // size: 0x3
        public enum ItemOutOfBoundsBehaviourEnum : uint {
            NoCost,
            UseFirst,
            UseLast,
        }
        /* 0x18 */ public ItemOutOfBoundsBehaviourEnum ItemOutOfBoundsBehaviour;
        /* 0x1C */ public bool AssertIfOutOfBounds;
    }
}

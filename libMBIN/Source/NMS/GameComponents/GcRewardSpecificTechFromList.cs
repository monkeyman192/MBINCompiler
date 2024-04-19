using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5958A51F9612CFB, NameHash = 0xF33640B1865E5E4B)]
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TechList;
        // size: 0x3
        public enum TechListRewardOrderEnum : uint {
            OneRandom,
            InOrder,
            TryAllRandom,
        }
        /* 0x10 */ public TechListRewardOrderEnum TechListRewardOrder;
        /* 0x14 */ public bool FailIfAllKnown;
    }
}

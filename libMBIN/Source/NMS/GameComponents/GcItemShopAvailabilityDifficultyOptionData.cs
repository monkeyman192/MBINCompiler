using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1D6D352C7C1B438, NameHash = 0xAAAFEA1B7C4E56A8)]
    public class GcItemShopAvailabilityDifficultyOptionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> NeverSoldItems;
    }
}

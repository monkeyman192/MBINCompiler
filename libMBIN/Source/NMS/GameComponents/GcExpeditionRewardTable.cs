using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F46E7D99BD8A5FC, NameHash = 0xDFC93B6F3652FDE5)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}

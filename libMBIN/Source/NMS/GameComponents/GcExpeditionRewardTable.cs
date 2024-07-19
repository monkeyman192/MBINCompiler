using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE5281672658E8B1, NameHash = 0x4835E140)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}

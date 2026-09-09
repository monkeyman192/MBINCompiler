using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF29F814D03FAE3E, NameHash = 0x4835E140)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFF1B747E548690C2, NameHash = 0xDFC93B6F3652FDE5)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> Table;
    }
}

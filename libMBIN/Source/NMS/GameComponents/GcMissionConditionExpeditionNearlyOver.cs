using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9542E382224A1CAC, NameHash = 0x188B717445D36858)]
    public class GcMissionConditionExpeditionNearlyOver : NMSTemplate
    {
        public ulong RemainingTimeToStartWarning;
    }
}

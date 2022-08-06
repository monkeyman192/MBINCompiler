using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A6FDE70E9836E1, NameHash = 0x3820751A1F86DB6)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        public GcMissionConditionTest ConditionTest;

        public List<NMSTemplate> Conditions;
    }
}

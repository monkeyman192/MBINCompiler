using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x9A6FDE70E9836E1, NameHash = 0x3820751A1F86DB6)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<NMSTemplate> Conditions;
    }
}

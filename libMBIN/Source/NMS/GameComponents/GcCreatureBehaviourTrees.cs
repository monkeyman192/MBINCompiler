using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x305779640452B708, NameHash = 0x1C80E29B339A41B9)]
    public class GcCreatureBehaviourTrees : NMSTemplate
    {
        public List<GcCreatureBehaviourTreeData> BehaviourTree;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x186F186B35DC49AC, NameHash = 0xD56EAD1F)]
    public class GcCreatureBehaviourTrees : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureBehaviourTreeData> BehaviourTree;
    }
}

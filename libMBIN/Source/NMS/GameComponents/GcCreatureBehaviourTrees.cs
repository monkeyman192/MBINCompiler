using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAD3453588C6A68E, NameHash = 0x1C80E29B339A41B9)]
    public class GcCreatureBehaviourTrees : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureBehaviourTreeData> BehaviourTree;
    }
}

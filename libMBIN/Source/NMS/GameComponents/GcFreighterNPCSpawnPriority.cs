using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x959045B99C201722, NameHash = 0x98356EEBB5BF8A56)]
    public class GcFreighterNPCSpawnPriority : NMSTemplate
    {
        public List<float> PriorityScale;
    }
}

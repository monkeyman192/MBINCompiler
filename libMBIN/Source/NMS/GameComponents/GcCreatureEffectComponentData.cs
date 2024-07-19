using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63F5F25FA9BBBBB2, NameHash = 0x9B56D2D8)]
    public class GcCreatureEffectComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureEffectTrigger> AnimTriggers;
    }
}

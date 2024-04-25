using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x110790E1F70E10F5, NameHash = 0xA0DADC1850532F54)]
    public class GcCreatureEffectComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureEffectTrigger> AnimTriggers;
    }
}

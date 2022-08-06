using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x778C8BC46E8653F3, NameHash = 0xA0DADC1850532F54)]
    public class GcCreatureEffectComponentData : NMSTemplate
    {
        public List<GcCreatureEffectTrigger> AnimTriggers;
    }
}

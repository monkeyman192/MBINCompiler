using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B7BFC290268D523, NameHash = 0xE02B8846C8E8134E)]
    public class GcNPCAnimationList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCProbabilityAnimationData> Animations;
    }
}

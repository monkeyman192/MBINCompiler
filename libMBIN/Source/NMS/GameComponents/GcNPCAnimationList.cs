using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x284D3E915855883C, NameHash = 0xE02B8846C8E8134E)]
    public class GcNPCAnimationList : NMSTemplate
    {
        public List<GcNPCProbabilityAnimationData> Animations;
    }
}

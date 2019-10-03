using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF515FEC744DF674D, NameHash = 0x53C414A21BE5AF34)]
    public class GcNPCWordReactionList : NMSTemplate
    {
        public List<GcNPCProbabilityWordReactionData> Reactions;
    }
}

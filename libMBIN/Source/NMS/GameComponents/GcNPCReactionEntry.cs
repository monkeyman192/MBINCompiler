using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9608FD01A19635F2, NameHash = 0x55C21F4B95AD18C8)]
    public class GcNPCReactionEntry : NMSTemplate
    {
        public NMSString0x10 Emote;
        public float ReactionChance;
        public List<GcNPCProbabilityReactionData> Animations;
    }
}

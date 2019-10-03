using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x9608FD01A19635F2, NameHash = 0x55C21F4B95AD18C8)]
    public class GcNPCReactionEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Emote;
        public float ReactionChance;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
        public List<GcNPCProbabilityReactionData> Animations;
    }
}

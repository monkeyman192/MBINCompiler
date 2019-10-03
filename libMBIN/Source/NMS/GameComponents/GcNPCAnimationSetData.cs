using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x170, GUID = 0x7E0C02976BA60690, NameHash = 0xF3A35A6135FAD505)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        public List<GcNPCProbabilityAnimationData> IdleAnimations;
        public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        public List<GcNPCProbabilityAnimationData> ListenAnimations;
        public List<GcNPCProbabilityAnimationData> GreetAnimations;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        public GcNPCAnimationList[] MoodAnims;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        public NMSString0x10[] MoodLoops;
    }
}

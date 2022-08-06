using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E0C02976BA60690, NameHash = 0xF3A35A6135FAD505)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        /* 0x000 */ public List<GcNPCProbabilityAnimationData> IdleAnimations;
        /* 0x010 */ public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        /* 0x020 */ public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        /* 0x030 */ public List<GcNPCProbabilityAnimationData> ListenAnimations;
        /* 0x040 */ public List<GcNPCProbabilityAnimationData> GreetAnimations;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x050 */ public GcNPCAnimationList[] MoodAnims;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x0E0 */ public NMSString0x10[] MoodLoops;
    }
}

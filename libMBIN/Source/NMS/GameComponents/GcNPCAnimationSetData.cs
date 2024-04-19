using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1196BB295CE46EAF, NameHash = 0xF3A35A6135FAD505)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x000 */ public GcNPCAnimationList[] MoodAnims;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x090 */ public NMSString0x10[] MoodLoops;
        /* 0x120 */ public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        /* 0x130 */ public List<GcNPCProbabilityAnimationData> GreetAnimations;
        /* 0x140 */ public List<GcNPCProbabilityAnimationData> IdleAnimations;
        /* 0x150 */ public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        /* 0x160 */ public List<GcNPCProbabilityAnimationData> ListenAnimations;
    }
}

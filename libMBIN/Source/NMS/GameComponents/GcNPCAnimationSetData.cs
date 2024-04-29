using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB95CD35A030B4663, NameHash = 0xF3A35A6135FAD505)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x000 */ public GcNPCAnimationList[] MoodAnims;
        [NMS(Index = 6, Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x090 */ public NMSString0x10[] MoodLoops;
        [NMS(Index = 2)]
        /* 0x120 */ public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        [NMS(Index = 4)]
        /* 0x130 */ public List<GcNPCProbabilityAnimationData> GreetAnimations;
        [NMS(Index = 0)]
        /* 0x140 */ public List<GcNPCProbabilityAnimationData> IdleAnimations;
        [NMS(Index = 1)]
        /* 0x150 */ public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        [NMS(Index = 3)]
        /* 0x160 */ public List<GcNPCProbabilityAnimationData> ListenAnimations;
    }
}

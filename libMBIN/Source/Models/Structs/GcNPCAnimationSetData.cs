using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x70)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        public List<GcNPCProbabilityAnimationData> IdleAnimations;
        public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        public List<GcNPCProbabilityAnimationData> GreetAnimations;
        public List<GcNPCProbabilityAnimationData> HappyAnimations;
        public List<GcNPCProbabilityAnimationData> AngryAnimations;
        public List<GcNPCProbabilityAnimationData> NeutralAnimations;
    }
}

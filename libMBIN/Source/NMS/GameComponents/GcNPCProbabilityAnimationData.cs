using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73C45731DC07C6E2, NameHash = 0x6ECD1E12A5E7A194)]
    public class GcNPCProbabilityAnimationData : NMSTemplate
    {
        /* 0x00 */ public List<GcAlienRace> ExcludeRace;
        /* 0x10 */ public NMSString0x10 Name;
        /* 0x20 */ public List<NMSString0x10> Tags;
        // size: 0x4
        public enum AnimationIntensityEnum : uint {
            Low,
            Medium,
            High,
            None,
        }
        /* 0x30 */ public AnimationIntensityEnum AnimationIntensity;
        /* 0x34 */ public float Probability;
    }
}

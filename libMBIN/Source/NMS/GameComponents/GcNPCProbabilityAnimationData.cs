using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE126F798149F3547, NameHash = 0xE2C6556B)]
    public class GcNPCProbabilityAnimationData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcAlienRace> ExcludeRace;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSString0x10> Tags;
        // size: 0x4
        public enum AnimationIntensityEnum : uint {
            Low,
            Medium,
            High,
            None,
        }
        [NMS(Index = 2)]
        /* 0x30 */ public AnimationIntensityEnum AnimationIntensity;
        [NMS(Index = 1)]
        /* 0x34 */ public float Probability;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x9ADBD39AC80BA7EA, NameHash = 0x6ECD1E12A5E7A194)]
    public class GcNPCProbabilityAnimationData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float Probability;
        public enum AnimationIntensityEnum { Low, Medium, High, None }
        /* 0x14 */ public AnimationIntensityEnum AnimationIntensity;
        /* 0x18 */ public List<GcAlienRace> ExcludeRace;
        /* 0x28 */ public List<NMSString0x10> Tags;
    }
}

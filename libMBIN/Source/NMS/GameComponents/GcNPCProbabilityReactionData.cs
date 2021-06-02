using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x77E5494830D1074A, NameHash = 0x260459086692280D)]
    public class GcNPCProbabilityReactionData : NMSTemplate
    {
        public NMSString0x10 Name;
        public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
        public List<GcNPCRaceProbabilityModifierData> RaceModifiers;
    }
}

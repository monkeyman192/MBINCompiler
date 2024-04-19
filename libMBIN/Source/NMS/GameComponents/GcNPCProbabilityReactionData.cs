using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18A1FDE48E76B20, NameHash = 0x260459086692280D)]
    public class GcNPCProbabilityReactionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<GcNPCRaceProbabilityModifierData> RaceModifiers;
        /* 0x20 */ public float Probability;
    }
}

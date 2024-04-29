using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8EED4D0C3150B58, NameHash = 0x55C21F4B95AD18C8)]
    public class GcNPCReactionEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcNPCProbabilityReactionData> Animations;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Emote;
        [NMS(Index = 1)]
        /* 0x20 */ public float ReactionChance;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25BD3ACACAC11957, NameHash = 0x55C21F4B95AD18C8)]
    public class GcNPCReactionEntry : NMSTemplate
    {
        /* 0x00 */ public List<GcNPCProbabilityReactionData> Animations;
        /* 0x10 */ public NMSString0x10 Emote;
        /* 0x20 */ public float ReactionChance;
    }
}

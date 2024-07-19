using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB690A7C1E22D070E, NameHash = 0x88BADF1E)]
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

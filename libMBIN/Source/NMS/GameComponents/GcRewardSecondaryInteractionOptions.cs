using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B37F009F4240EDC, NameHash = 0x4ED8FEEE)]
    public class GcRewardSecondaryInteractionOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienPuzzleOption> Options;
    }
}

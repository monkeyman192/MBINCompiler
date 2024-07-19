using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x306D7A3918DAB5D4, NameHash = 0x4ED8FEEE)]
    public class GcRewardSecondaryInteractionOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienPuzzleOption> Options;
    }
}

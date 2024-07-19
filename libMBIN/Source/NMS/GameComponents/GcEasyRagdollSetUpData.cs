using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x110B74FBFAC5B762, NameHash = 0x18118681)]
    public class GcEasyRagdollSetUpData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x20> ChainEnds;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x20> ExcludeJoints;
    }
}

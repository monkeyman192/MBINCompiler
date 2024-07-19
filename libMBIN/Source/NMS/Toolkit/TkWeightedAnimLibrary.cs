using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5C240D54149229B2, NameHash = 0x7137BDD4)]
    public class TkWeightedAnimLibrary : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkWeightedAnim> Anims;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
    }
}

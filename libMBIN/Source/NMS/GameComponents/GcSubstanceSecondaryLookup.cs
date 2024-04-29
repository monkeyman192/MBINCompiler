using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45E34340431E414A, NameHash = 0x5AF4540465F27753)]
    public class GcSubstanceSecondaryLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PrimaryID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSubstanceSecondary> SecondaryChances;
    }
}

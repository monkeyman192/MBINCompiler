using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6D1A7B47F42D3C7, NameHash = 0x5AF4540465F27753)]
    public class GcSubstanceSecondaryLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PrimaryID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSubstanceSecondary> SecondaryChances;
    }
}

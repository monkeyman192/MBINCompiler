using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5BD1B5C38F8CC50, NameHash = 0x53A77770)]
    public class GcSubstanceSecondaryLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PrimaryID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSubstanceSecondary> SecondaryChances;
    }
}

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C30630C9CDEA8DD, NameHash = 0x38C665B6)]
    public class GcRewardSpecificProductFromList : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 IncrementGlobalStatOnSuccess;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> ProductList;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x28 */ public bool ForceSpecialMessage;
    }
}

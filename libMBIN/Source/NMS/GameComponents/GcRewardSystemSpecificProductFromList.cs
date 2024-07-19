using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90EECB010EA301A1, NameHash = 0x333BADF8)]
    public class GcRewardSystemSpecificProductFromList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> ProductList;
        [NMS(Index = 2)]
        /* 0x10 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x14 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x18 */ public bool ForceSpecialMessage;
    }
}

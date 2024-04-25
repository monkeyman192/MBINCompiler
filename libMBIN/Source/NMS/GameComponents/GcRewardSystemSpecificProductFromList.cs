using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE23F1012DD607C65, NameHash = 0xA84D807B09AAC1E3)]
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

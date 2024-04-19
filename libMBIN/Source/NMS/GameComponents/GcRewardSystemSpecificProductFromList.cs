using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE23F1012DD607C65, NameHash = 0xA84D807B09AAC1E3)]
    public class GcRewardSystemSpecificProductFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        /* 0x10 */ public int AmountMax;
        /* 0x14 */ public int AmountMin;
        /* 0x18 */ public bool ForceSpecialMessage;
    }
}

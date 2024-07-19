using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF5F0C77737DC61C, NameHash = 0x458EED45)]
    public class GcCostItemFromList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> ItemList;
        [NMS(Index = 0)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x14 */ public int Index;
    }
}

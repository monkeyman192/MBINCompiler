using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A0C270A968717A4, NameHash = 0x0D9C971EFC16BB550)]
    public class GcCostItemFromList : NMSTemplate
    {
        /* 0x00 */ public int Amount;
        /* 0x08 */ public List<NMSString0x10> ItemList;
        /* 0x18 */ public int Index;
    }
}

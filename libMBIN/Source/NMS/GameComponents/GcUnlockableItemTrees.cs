using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99D215C27F597EBF, NameHash = 0x2B87D92751133C6D)]
    public class GcUnlockableItemTrees : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcUnlockableItemTree> Trees;
    }
}

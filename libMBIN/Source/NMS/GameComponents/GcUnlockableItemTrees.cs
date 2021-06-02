using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xE5D703286D3A19C5, NameHash = 0x2B87D92751133C6D)]
    public class GcUnlockableItemTrees : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public List<GcUnlockableItemTree> Trees;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xFAE988FFB04C62B2, NameHash = 0xB6094F57F9EFA01D)]
    public class GcUnlockableItemTreeNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Unlockable;
        /* 0x210 */ public List<GcUnlockableItemTreeNode> Children;
    }
}

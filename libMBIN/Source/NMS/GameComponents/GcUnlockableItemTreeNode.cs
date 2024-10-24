using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB815194700620BF9, NameHash = 0x3FA03E52)]
    public class GcUnlockableItemTreeNode : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcUnlockableItemTreeNode> Children;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Unlockable;
    }
}

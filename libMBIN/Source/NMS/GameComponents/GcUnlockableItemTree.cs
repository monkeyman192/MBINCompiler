using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x558E920650090689, NameHash = 0x6B3A62EF81161171)]
    public class GcUnlockableItemTree : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Title;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string CostTypeID;
        /* 0x30 */ public GcUnlockableItemTreeNode Root;
    }
}

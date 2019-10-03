using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x220, GUID = 0xC1369536A8BADFB8, NameHash = 0xDDC3AC505BDF81E2)]
    public class GcUnlockableTrees : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcUnlockableItemTreeGroups.UnlockableItemTreeEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        /* 0x210 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}

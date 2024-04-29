using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x154EACDFDDE9D5DF, NameHash = 0xDDC3AC505BDF81E2)]
    public class GcUnlockableTrees : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xE, EnumType = typeof(GcUnlockableItemTreeGroups.UnlockableItemTreeEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        [NMS(Index = 1)]
        /* 0x2A0 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}

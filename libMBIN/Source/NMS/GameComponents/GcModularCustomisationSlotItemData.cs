using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CB3BCEFC1946DF3, NameHash = 0x660230CBC714CB2C)]
    public class GcModularCustomisationSlotItemData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcModularCustomisationDescriptorGroupData> DescriptorGroupData;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ItemID;
        // size: 0x2
        public enum DescriptorGroupSalvageRuleEnum : uint {
            All,
            Any,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public DescriptorGroupSalvageRuleEnum DescriptorGroupSalvageRule;
        [NMS(Index = 4)]
        /* 0x24 */ public GcInventoryClass InventoryClass;
        [NMS(Index = 3)]
        /* 0x28 */ public bool SetInventoryClass;
    }
}

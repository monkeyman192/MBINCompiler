using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CB3BCEFC1946DF3, NameHash = 0x660230CBC714CB2C)]
    public class GcModularCustomisationSlotItemData : NMSTemplate
    {
        /* 0x00 */ public List<GcModularCustomisationDescriptorGroupData> DescriptorGroupData;
        /* 0x10 */ public NMSString0x10 ItemID;
        // size: 0x2
        public enum DescriptorGroupSalvageRuleEnum : uint {
            All,
            Any,
        }
        /* 0x20 */ public DescriptorGroupSalvageRuleEnum DescriptorGroupSalvageRule;
        /* 0x24 */ public GcInventoryClass InventoryClass;
        /* 0x28 */ public bool SetInventoryClass;
    }
}

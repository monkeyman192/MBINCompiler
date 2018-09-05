using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xD0)]
    public class GcRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> DestructionTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> OldInteractionTable;
        public List<GcGenericRewardTableEntry> SpecialRewardTable;
        public List<GcGenericRewardTableEntry> MissionBoardTable;
        public List<GcGenericRewardTableEntry> FleetTable;
        public List<GcGenericRewardTableEntry> WikiProgressTable;
        public List<GcRewardTableEntitlementItem> EntitlementTable;
        public List<GcRewardTableEntry> Table;
        public List<NMSString0x10> TechRewardOrder;
        public List<NMSString0x10> ProductRewardOrder;
        public List<GcGenericRewardTableEntry> MixerRewardTable;

    }
}

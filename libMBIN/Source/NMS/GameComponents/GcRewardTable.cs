using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE0, GUID = 0x29B7DFCC7CC18D82, NameHash = 0x2ECD4E3663FDB26F)]
    public class GcRewardTable : NMSTemplate
    {
        /* 0x00 */ public List<GcGenericRewardTableEntry> GenericTable;
        /* 0x10 */ public List<GcGenericRewardTableEntry> DestructionTable;
        /* 0x20 */ public List<GcGenericRewardTableEntry> InteractionTable;
        /* 0x30 */ public List<GcGenericRewardTableEntry> OldInteractionTable;
        /* 0x40 */ public List<GcGenericRewardTableEntry> SpecialRewardTable;
        /* 0x50 */ public List<GcGenericRewardTableEntry> MissionBoardTable;
        /* 0x60 */ public List<GcGenericRewardTableEntry> FleetTable;
        /* 0x70 */ public List<GcGenericRewardTableEntry> WikiProgressTable;
        /* 0x80 */ public List<GcRewardTableEntitlementItem> EntitlementTable;
        /* 0x90 */ public List<GcRewardTableEntry> Table;
        /* 0xA0 */ public List<NMSString0x10> TechRewardOrder;
        /* 0xB0 */ public List<NMSString0x10> ProductRewardOrder;
        /* 0xC0 */ public List<GcGenericRewardTableEntry> MixerRewardTable;
        /* 0xC0 */ public List<GcGenericRewardTableEntry> NPCPlanetSiteTable;
    }
}

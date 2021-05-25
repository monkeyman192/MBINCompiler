using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, GUID = 0x29F1A6CFFB862932, NameHash = 0x2ECD4E3663FDB26F)]
    public class GcRewardTable : NMSTemplate
    {
        /* 0x000 */ public List<GcGenericRewardTableEntry> GenericTable;
        /* 0x010 */ public List<GcGenericRewardTableEntry> DestructionTable;
        /* 0x020 */ public List<GcGenericRewardTableEntry> InteractionTable;
        /* 0x030 */ public List<GcGenericRewardTableEntry> OldInteractionTable;
        /* 0x040 */ public List<GcGenericRewardTableEntry> SpecialRewardTable;
        /* 0x050 */ public List<GcGenericRewardTableEntry> MissionBoardTable;
        /* 0x060 */ public List<GcGenericRewardTableEntry> FleetTable;
        /* 0x070 */ public List<GcGenericRewardTableEntry> WikiProgressTable;
        /* 0x080 */ public List<GcGenericRewardTableEntry> ShipSalvageTable;
        /* 0x090 */ public List<GcRewardTableEntitlementItem> EntitlementTable;
        /* 0x0A0 */ public List<GcRewardTableEntry> Table;
        /* 0x0B0 */ public List<NMSString0x10> TechRewardOrder;
        /* 0x0C0 */ public List<NMSString0x10> ProductRewardOrder;
        /* 0x0D0 */ public List<GcGenericRewardTableEntry> MixerRewardTable;
        /* 0x0E0 */ public List<GcGenericRewardTableEntry> TwitchRewardTable;
        /* 0x0F0 */ public List<GcGenericRewardTableEntry> NPCPlanetSiteTable;
        /* 0x100 */ public List<GcGenericRewardTableEntry> SeasonRewardTable1;
        /* 0x110 */ public List<GcGenericRewardTableEntry> SeasonRewardTable2;
        /* 0x120 */ public List<GcGenericRewardTableEntry> SeasonRewardTable3;
    }
}

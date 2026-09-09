using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x752107F5E9264F5D, NameHash = 0x67E289CF)]
    public class GcRewardTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public List<GcGenericRewardTableEntry> DestructionTable;
        [NMS(Index = 10)]
        /* 0x010 */ public List<GcRewardTableEntitlementItem> EntitlementTable;
        [NMS(Index = 7)]
        /* 0x020 */ public List<GcGenericRewardTableEntry> FleetTable;
        [NMS(Index = 18)]
        /* 0x030 */ public List<GcGenericRewardTableEntry> GameTableRewards;
        [NMS(Index = 0)]
        /* 0x040 */ public List<GcGenericRewardTableEntry> GenericTable;
        [NMS(Index = 2)]
        /* 0x050 */ public List<GcGenericRewardTableEntry> InteractionTable;
        [NMS(Index = 6)]
        /* 0x060 */ public List<GcGenericRewardTableEntry> MissionBoardTable;
        [NMS(Index = 14)]
        /* 0x070 */ public List<GcGenericRewardTableEntry> MixerRewardTable;
        [NMS(Index = 16)]
        /* 0x080 */ public List<GcGenericRewardTableEntry> NPCPlanetSiteTable;
        [NMS(Index = 3)]
        /* 0x090 */ public List<GcGenericRewardTableEntry> OldInteractionTable;
        [NMS(Index = 13)]
        /* 0x0A0 */ public List<NMSString0x10> ProductRewardOrder;
        [NMS(Index = 19)]
        /* 0x0B0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable1;
        [NMS(Index = 28)]
        /* 0x0C0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable10;
        [NMS(Index = 29)]
        /* 0x0D0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable11;
        [NMS(Index = 30)]
        /* 0x0E0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable12;
        [NMS(Index = 31)]
        /* 0x0F0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable13;
        [NMS(Index = 32)]
        /* 0x100 */ public List<GcGenericRewardTableEntry> SeasonRewardTable14;
        [NMS(Index = 33)]
        /* 0x110 */ public List<GcGenericRewardTableEntry> SeasonRewardTable15;
        [NMS(Index = 34)]
        /* 0x120 */ public List<GcGenericRewardTableEntry> SeasonRewardTable16;
        [NMS(Index = 35)]
        /* 0x130 */ public List<GcGenericRewardTableEntry> SeasonRewardTable17;
        [NMS(Index = 36)]
        /* 0x140 */ public List<GcGenericRewardTableEntry> SeasonRewardTable18;
        [NMS(Index = 37)]
        /* 0x150 */ public List<GcGenericRewardTableEntry> SeasonRewardTable19;
        [NMS(Index = 20)]
        /* 0x160 */ public List<GcGenericRewardTableEntry> SeasonRewardTable2;
        [NMS(Index = 38)]
        /* 0x170 */ public List<GcGenericRewardTableEntry> SeasonRewardTable20;
        [NMS(Index = 39)]
        /* 0x180 */ public List<GcGenericRewardTableEntry> SeasonRewardTable21;
        [NMS(Index = 40)]
        /* 0x190 */ public List<GcGenericRewardTableEntry> SeasonRewardTable22;
        [NMS(Index = 41)]
        /* 0x1A0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable23;
        [NMS(Index = 42)]
        /* 0x1B0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable24;
        [NMS(Index = 21)]
        /* 0x1C0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable3;
        [NMS(Index = 22)]
        /* 0x1D0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable4;
        [NMS(Index = 23)]
        /* 0x1E0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable5;
        [NMS(Index = 24)]
        /* 0x1F0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable6;
        [NMS(Index = 25)]
        /* 0x200 */ public List<GcGenericRewardTableEntry> SeasonRewardTable7;
        [NMS(Index = 26)]
        /* 0x210 */ public List<GcGenericRewardTableEntry> SeasonRewardTable8;
        [NMS(Index = 27)]
        /* 0x220 */ public List<GcGenericRewardTableEntry> SeasonRewardTable9;
        [NMS(Index = 17)]
        /* 0x230 */ public List<GcGenericRewardTableEntry> SettlementTable;
        [NMS(Index = 9)]
        /* 0x240 */ public List<GcGenericRewardTableEntry> ShipSalvageTable;
        [NMS(Index = 4)]
        /* 0x250 */ public List<GcGenericRewardTableEntry> SpecialRewardTable;
        [NMS(Index = 5)]
        /* 0x260 */ public List<GcGenericRewardTableEntry> StoriesRewardTable;
        [NMS(Index = 11)]
        /* 0x270 */ public List<GcRewardTableEntry> Table;
        [NMS(Index = 12)]
        /* 0x280 */ public List<NMSString0x10> TechRewardOrder;
        [NMS(Index = 15)]
        /* 0x290 */ public List<GcGenericRewardTableEntry> TwitchRewardTable;
        [NMS(Index = 8)]
        /* 0x2A0 */ public List<GcGenericRewardTableEntry> WikiProgressTable;
    }
}

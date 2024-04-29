using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2F993BEAC373679, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public NMSString0x20A CustomRewardLocID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A ProcTechGroup;
        [NMS(Index = 10)]
        /* 0x40 */ public List<NMSString0x10> CommunityTierProductList;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x10 Id;
        [NMS(Index = 12)]
        /* 0x60 */ public NMSString0x10 SeasonRewardListFormat;
        [NMS(Index = 2)]
        /* 0x70 */ public int Amount;
        // size: 0x8
        public enum MultiItemRewardTypeEnum : uint {
            Product,
            Substance,
            ProcTech,
            ProcProduct,
            InventorySlot,
            InventorySlotShip,
            InventorySlotWeapon,
            CommunityTierProduct,
        }
        [NMS(Index = 0)]
        /* 0x74 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        [NMS(Index = 9)]
        /* 0x78 */ public GcRarity ProcProdRarity;
        [NMS(Index = 8)]
        /* 0x7C */ public GcProceduralProductCategory ProcProdType;
        [NMS(Index = 4)]
        /* 0x80 */ public int ProcTechQuality;
        [NMS(Index = 7)]
        /* 0x84 */ public bool AlsoTeachTechBoxRecipe;
        [NMS(Index = 11)]
        /* 0x85 */ public bool HideInSeasonRewards;
        [NMS(Index = 5)]
        /* 0x86 */ public bool IllegalProcTech;
        [NMS(Index = 6)]
        /* 0x87 */ public bool SentinelProcTech;
    }
}

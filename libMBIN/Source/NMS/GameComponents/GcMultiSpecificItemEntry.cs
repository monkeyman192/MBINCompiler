using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D4A4E9F958B1465, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CustomRewardLocID;
        /* 0x20 */ public NMSString0x20A ProcTechGroup;
        /* 0x40 */ public List<NMSString0x10> CommunityTierProductList;
        /* 0x50 */ public NMSString0x10 Id;
        /* 0x60 */ public NMSString0x10 SeasonRewardListFormat;
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
        /* 0x74 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        /* 0x78 */ public GcRarity ProcProdRarity;
        /* 0x7C */ public GcProceduralProductCategory ProcProdType;
        /* 0x80 */ public int ProcTechQuality;
        /* 0x84 */ public bool AlsoTeachTechBoxRecipe;
        /* 0x85 */ public bool HideInSeasonRewards;
        /* 0x86 */ public bool IllegalProcTech;
        /* 0x87 */ public bool SentinelProcTech;
    }
}

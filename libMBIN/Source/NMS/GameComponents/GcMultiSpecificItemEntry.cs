using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B4D90F7E808C657, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        public enum MultiItemRewardTypeEnum { Product, Substance, ProcTech, ProcProduct, InventorySlot, CommunityTierProduct }
        /* 0x00 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x20 */ public NMSString0x20A ProcTechGroup;
        /* 0x40 */ public int ProcTechQuality;
        /* 0x44 */ public bool IllegalProcTech;
        /* 0x48 */ public GcProceduralProductCategory ProcProdType;
        /* 0x4C */ public GcRarity ProcProdRarity;
        /* 0x50 */ public List<NMSString0x10> CommunityTierProductList;
        /* 0x60 */ public bool HideInSeasonRewards;
        /* 0x68 */ public NMSString0x10 SeasonRewardListFormat;

    }
}

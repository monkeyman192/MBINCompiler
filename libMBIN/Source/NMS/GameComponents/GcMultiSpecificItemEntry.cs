using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0x6E82F26909906DB0, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        public enum MultiItemRewardTypeEnum { Product, Substance, ProcTech, ProcProduct, InventorySlot }
        /* 0x00 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x20 */ public NMSString0x20A ProcTechGroup;
        /* 0x40 */ public int ProcTechQuality;
        /* 0x44 */ public GcProceduralProductCategory ProcProdType;
        /* 0x48 */ public GcRarity ProcProdRarity;
        /* 0x4C */ public bool HideInSeasonRewards;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4D */ public byte[] EndPadding;

    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE5E19BF12FB5A55C, NameHash = 0x950617F05949472B)]
    public class GcInventoryStoreBalance : NMSTemplate
    {
        /* 0x00 */ public int DefaultSubstanceMaxAmount;
        /* 0x04 */ public int DefaultProductMaxAmount;
        /* 0x08 */ public int CargoSubstanceStorageMultiplier;
        /* 0x0C */ public int CargoProductStorageMultiplier;
        /* 0x10 */ public int ShipSubstanceStorageMultiplier;
        /* 0x14 */ public int ShipProductStorageMultiplier;
        /* 0x18 */ public int FreighterSubstanceStorageMultiplier;
        /* 0x1C */ public int FreighterProductStorageMultiplier;
        /* 0x20 */ public int ChestSubstanceStorageMultiplier;
        /* 0x24 */ public int ChestProductStorageMultiplier;
        /* 0x28 */ public int BaseCapsuleSubstanceStorageMultiplier;
        /* 0x2C */ public int BaseCapsuleProductStorageMultiplier;
        /* 0x30 */ public int DefaultSubstanceStorageMultiplier;
        /* 0x34 */ public int DefaultProductStorageMultiplier;
        /* 0x38 */ public int SubstanceMaxAmountLimit;
        /* 0x3C */ public int ProductMaxAmountLimit;
        /* 0x40 */ public int PlayerPersonalInventoryTechWidth;
        /* 0x44 */ public int PlayerPersonalInventoryTechHeight;
        /* 0x48 */ public int PlayerPersonalInventoryCargoWidth;
        /* 0x4C */ public int PlayerPersonalInventoryCargoHeight;
        /* 0x50 */ public float DeconstructRefundPercentage;
    }
}

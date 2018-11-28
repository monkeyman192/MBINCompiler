using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xF7353267DC3C55C8)]
    public class GcRewardProduct : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory Category;
        /* 0x04 */ public GcRarity Rarity;
        /* 0x08 */ public int ItemLevel;
        [NMS( EnumType = typeof( GcProductCategory.ProductCategoryEnum ) )]
        /* 0x0C */ public bool[] AllowedProductTypes;
        /* 0x14 */ public int AmountMin;
        /* 0x18 */ public int AmountMax;
    }
}

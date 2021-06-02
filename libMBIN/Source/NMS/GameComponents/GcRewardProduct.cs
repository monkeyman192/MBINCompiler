using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x4, GUID = 0xF7353267DC3C55C8, NameHash = 0x893933F89479A7D8)]
    public class GcRewardProduct : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCategory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public int ItemLevel;
        [NMS(Size = 9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0C */ public bool[] AllowedProductTypes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] Padding15;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
    }
}

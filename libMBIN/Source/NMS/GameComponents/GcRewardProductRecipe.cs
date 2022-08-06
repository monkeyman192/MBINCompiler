using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD2A4169D7657745E, NameHash = 0x27661A8643F25227)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCategory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public bool IgnoreRarity;
        /* 0x0C */ public int ItemLevel;
        [NMS(Size = 9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x10 */ public bool[] AllowedProductTypes;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87264FFD7270DC58, NameHash = 0x27661A8643F25227)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCatagory;
        /* 0x04 */ public int ItemLevel;
        /* 0x08 */ public GcRarity ItemRarity;
        [NMS(Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0C */ public bool[] AllowedProductTypes;
        /* 0x15 */ public bool IgnoreRarity;
    }
}

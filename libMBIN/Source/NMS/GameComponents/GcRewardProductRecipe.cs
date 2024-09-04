using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EBCDC5CA2216EAA, NameHash = 0x3AE338E1)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcRealitySubstanceCategory ItemCatagory;
        [NMS(Index = 3)]
        /* 0x04 */ public int ItemLevel;
        [NMS(Index = 1)]
        /* 0x08 */ public GcRarity ItemRarity;
        [NMS(Index = 4, Size = 0xA, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0C */ public bool[] AllowedProductTypes;
        [NMS(Index = 2)]
        /* 0x16 */ public bool IgnoreRarity;
    }
}

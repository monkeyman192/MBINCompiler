using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45FAC0221192A379, NameHash = 0x893933F89479A7D8)]
    public class GcRewardProduct : NMSTemplate
    {
        /* 0x00 */ public int AmountMax;
        /* 0x04 */ public int AmountMin;
        /* 0x08 */ public GcRealitySubstanceCategory ItemCategory;
        /* 0x0C */ public int ItemLevel;
        /* 0x10 */ public GcRarity ItemRarity;
        [NMS(Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x14 */ public bool[] AllowedProductTypes;
    }
}

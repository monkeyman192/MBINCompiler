using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B2470ADEAA1103B, NameHash = 0xD143E4CA)]
    public class GcRewardProduct : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public int AmountMax;
        [NMS(Index = 4)]
        /* 0x04 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x08 */ public GcRealitySubstanceCategory ItemCategory;
        [NMS(Index = 2)]
        /* 0x0C */ public int ItemLevel;
        [NMS(Index = 1)]
        /* 0x10 */ public GcRarity ItemRarity;
        [NMS(Index = 3, Size = 0xA, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x14 */ public bool[] AllowedProductTypes;
    }
}

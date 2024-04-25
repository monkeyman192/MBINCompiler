using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4EEDF35BA1C202B, NameHash = 0x68CB2B62199F1EFA)]
    public class GcNPCWordReactionCategory : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcWordCategoryTableEnum.wordcategorytableEnumEnum))]
        /* 0x00 */ public GcNPCWordReactionList[] Categories;
        [NMS(Index = 1)]
        /* 0x70 */ public GcNPCWordReactionList Fallback;
    }
}

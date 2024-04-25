using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98AFAB0C4330107C, NameHash = 0x5ED90B1D007B2123)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0 */ public GcRewardDestructRarities[] Categories;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89F7B9EF1A67D94F, NameHash = 0x72439AF10F4C849F)]
    public class GcWikiTopicType : NMSTemplate
    {
        // size: 0x1D
        public enum WikiTopicTypeEnum : uint {
            Substances,
            CustomSubstanceList,
            Products,
            CustomProductList,
            CustomItemList,
            Technologies,
            CustomTechnologyList,
            BuildableTech,
            Construction,
            TradeCommodities,
            Curiosities,
            Cooking,
            StoneRunes,
            Words,
            RecipesAll,
            RecipesCooker,
            RecipesRefiner1,
            RecipesRefiner2,
            RecipesRefiner3,
            Guide,
            Stories,
            TreasureWonders,
            WeirdBasePartWonders,
            PlanetWonders,
            CreatureWonders,
            FloraWonders,
            MineralWonders,
            CustomWonders,
            DebugSweep,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WikiTopicTypeEnum WikiTopicType;
    }
}

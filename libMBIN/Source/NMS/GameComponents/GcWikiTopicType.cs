namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BD1356A494F80C6, NameHash = 0x422A5EC3)]
    public class GcWikiTopicType : NMSTemplate
    {
        // size: 0x1E
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
            Fish,
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

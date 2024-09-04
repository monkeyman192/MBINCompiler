namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B65C7F96546BC10, NameHash = 0xE9C3D15D)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0xA
        public enum ProductCategoryEnum : uint {
            Component,
            Consumable,
            Tradeable,
            Curiosity,
            BuildingPart,
            Procedural,
            Emote,
            CustomisationPart,
            CreatureEgg,
            Fish,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProductCategoryEnum ProductCategory;
    }
}

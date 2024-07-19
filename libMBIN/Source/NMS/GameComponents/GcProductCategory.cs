namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD2D86AE268A7F24, NameHash = 0xE9C3D15D)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0x9
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProductCategoryEnum ProductCategory;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC842CA3C5B238806, NameHash = 0xE9C3D15D)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0xC
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
            ExhibitBone,
            SpaceSalvage,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProductCategoryEnum ProductCategory;
    }
}

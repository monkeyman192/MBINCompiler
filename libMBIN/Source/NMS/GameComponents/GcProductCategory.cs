using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x802636D9FB537A25, NameHash = 0xB3E1998DF67B4EF2)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0x9
        public enum ProductCategoryEnum {
            Component, Consumable, Tradeable, Curiosity, BuildingPart, Procedural, Emote, CustomisationPart, CreatureEgg
        }
        public ProductCategoryEnum ProductCategory;
    }
}
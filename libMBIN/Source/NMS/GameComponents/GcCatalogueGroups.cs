namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x261CB4A6885077DC, NameHash = 0x16C989FB)]
    public class GcCatalogueGroups : NMSTemplate
    {
        // size: 0x5
        public enum CatalogueGroupEnum : uint {
            MaterialsAndItems,
            CraftingAndTechnology,
            Buildables,
            Recipes,
            Wonders,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CatalogueGroupEnum CatalogueGroup;
    }
}

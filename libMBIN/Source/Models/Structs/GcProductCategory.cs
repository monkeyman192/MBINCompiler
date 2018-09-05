namespace libMBIN.Models.Structs
{
    public class GcProductCategory : NMSTemplate
    {
        public int ProductCategory;

        public string[] ProductCategoryValues()
        {
            return new[] { "Component", "Consumable", "Tradeable", "Curiousity", "BuildingPart", "Procedural", "Emote", "CustomisationPart" };
        }
    }
}

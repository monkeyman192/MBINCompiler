namespace libMBIN.Models.Structs
{
    public class GcProductCategory : NMSTemplate
    {

		public enum ProductCategoryEnum { Component, Consumable, Tradeable, Curiousity, BuildingPart, Procedural, Emote, CustomisationPart }
		public ProductCategoryEnum ProductCategory;
    }
}

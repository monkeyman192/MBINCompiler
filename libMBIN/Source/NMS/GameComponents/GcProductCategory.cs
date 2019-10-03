using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFE856038031F8FF0, NameHash = 0xB3E1998DF67B4EF2)]
    public class GcProductCategory : NMSTemplate
    {

		public enum ProductCategoryEnum { Component, Consumable, Tradeable, Curiousity, BuildingPart, Procedural, Emote, CustomisationPart }
		public ProductCategoryEnum ProductCategory;
    }
}

namespace libMBIN.Models.Structs
{
    public class GcTechnologyCategory : NMSTemplate
    {
		public enum TechnologyCategoryEnum { Ship, Weapon, Suit, Personal, All, None, Freighter, Vehicle, Maintenance }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}

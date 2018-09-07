namespace libMBIN.Models.Structs
{
    public class GcExpeditionCategory : NMSTemplate
    {
		public enum ExpeditionCategoryEnum { Combat, Exploration, Mining, Diplomacy, Balanced }
		public ExpeditionCategoryEnum ExpeditionCategory;
    }
}

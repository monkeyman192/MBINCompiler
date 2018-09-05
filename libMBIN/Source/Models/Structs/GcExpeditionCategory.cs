namespace libMBIN.Models.Structs
{
    public class GcExpeditionCategory : NMSTemplate
    {
        public int ExpeditionCategory;
        public string[] ExpeditionCategoryValues()
        {
            return new[] { "Combat", "Exploration", "Mining", "Diplomacy", "Balanced" };
        }
    }
}

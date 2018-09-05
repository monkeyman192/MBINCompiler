namespace libMBIN.Models.Structs
{
    public class GcTechnologyCategory : NMSTemplate
    {
        public int TechnologyCategory;
        public string[] TechnologyCategoryValues()
        {
            return new[] { "Ship", "Weapon", "Suit", "Personal", "All", "None", "Freighter", "Vehicle", "Maintenance"};
        }
    }
}

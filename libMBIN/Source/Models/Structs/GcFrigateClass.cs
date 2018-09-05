namespace libMBIN.Models.Structs
{
    public class GcFrigateClass : NMSTemplate
    {
        public int FrigateClass;
        public string[] FrigateClassValues()
        {
            return new[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" };
        }
    }
}

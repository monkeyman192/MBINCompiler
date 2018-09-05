namespace libMBIN.Models.Structs
{
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        public int SubstanceCategory;

        public string[] SubstanceCategoryValues()
        {
            return new[] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" };
        }
    }
}

namespace libMBIN.Models.Structs
{
    public class GcProceduralTechnologyCategory : NMSTemplate
    {
        public int ProceduralTechnologyCategory;
        public string[] ProceduralTechnologyCategoryValues()
        {
            return new[] { "None", "Combat", "Mining", "Scanning", "Protection"};
        }
    }
}

namespace libMBIN.Models.Structs
{
    public class GcProceduralProductCategory : NMSTemplate
    {
        public int ProceduralProductCategory;

        public string[] ProceduralProductCategoryValues()
        {
            return new[] { "Loot", "Document", "BioSample", "Fossil", "Plant", "Tool", "Farm" };
        }
    }
}

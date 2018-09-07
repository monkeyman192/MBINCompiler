namespace libMBIN.Models.Structs
{
    public class GcProceduralProductCategory : NMSTemplate
    {

		public enum ProceduralProductCategoryEnum { Loot, Document, BioSample, Fossil, Plant, Tool, Farm }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}

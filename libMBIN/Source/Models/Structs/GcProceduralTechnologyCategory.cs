namespace libMBIN.Models.Structs
{
    public class GcProceduralTechnologyCategory : NMSTemplate
    {
		public enum ProceduralTechnologyCategoryEnum { None, Combat, Mining, Scanning, Protection }
		public ProceduralTechnologyCategoryEnum ProceduralTechnologyCategory;
    }
}

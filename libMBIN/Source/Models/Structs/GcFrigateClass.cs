namespace libMBIN.Models.Structs
{
    public class GcFrigateClass : NMSTemplate
    {
		public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support }
		public FrigateClassEnum FrigateClass;
    }
}

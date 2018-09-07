namespace libMBIN.Models.Structs
{
    public class GcTechnologyRarity : NMSTemplate
    {

		public enum TechnologyRarityEnum { Normal, VeryCommon, Common, Rare, VeryRare, Impossible, Always }
		public TechnologyRarityEnum TechnologyRarity;
    }
}

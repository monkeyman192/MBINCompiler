namespace libMBIN.Models.Structs
{
    public class GcRarity : NMSTemplate
    {

		public enum RarityEnum { Common, Uncommon, Rare, Extraordinary, None }
		public RarityEnum Rarity;
    }
}

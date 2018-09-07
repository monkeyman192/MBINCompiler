namespace libMBIN.Models.Structs
{
    public class TkProbability : NMSTemplate
    {
		public enum ProbabilityEnum { Common, Uncommon, Rare, Extraordinary }
		public ProbabilityEnum Probability;
    }
}

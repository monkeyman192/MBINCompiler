namespace libMBIN.Models.Structs
{
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
		public enum CentreJourneyDestinationEnum { Next, Abandoned, Vicious, Lush, Balanced }
		public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}

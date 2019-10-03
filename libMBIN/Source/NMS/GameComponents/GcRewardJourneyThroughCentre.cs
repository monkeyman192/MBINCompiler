using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF0196F209D21EB12, NameHash = 0x1D30BD6C3E0FC228)]
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
		public enum CentreJourneyDestinationEnum { Next, Abandoned, Vicious, Lush, Balanced }
		public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}

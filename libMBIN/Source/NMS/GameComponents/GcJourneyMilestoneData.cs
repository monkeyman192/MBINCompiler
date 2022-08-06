using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x70A99E84E5D737DB, NameHash = 0xC35BDABF76750407)]
    public class GcJourneyMilestoneData : NMSTemplate
    {
        public NMSString0x10 JourneyMilestoneId;
        public int PointsToUnlock;
        public NMSString0x20A JourneyMilestoneTitle;
    }
}

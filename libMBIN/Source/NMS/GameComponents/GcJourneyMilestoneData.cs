using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x70A99E84E5D737DB, NameHash = 0xC35BDABF76750407)]
    public class GcJourneyMilestoneData : NMSTemplate
    {
        public NMSString0x10 JourneyMilestoneId;
        public int PointsToUnlock;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
        public NMSString0x20 JourneyMilestoneTitle;
    }
}
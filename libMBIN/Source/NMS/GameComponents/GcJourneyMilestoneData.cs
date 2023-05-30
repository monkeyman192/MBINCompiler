using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcJourneyMilestoneData : NMSTemplate
    {
        public NMSString0x10 JourneyMilestoneId;
        public int PointsToUnlock;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
        public NMSString0x20 JourneyMilestoneTitle;
    }
}

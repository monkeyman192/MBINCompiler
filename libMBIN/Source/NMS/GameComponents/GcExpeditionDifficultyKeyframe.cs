using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x10B8D55460ACA45A, NameHash = 0xEC5C654507FD5E75)]
    public class GcExpeditionDifficultyKeyframe : NMSTemplate
    {
        public int EventNumber;
        public float Difficulty;
    }
}

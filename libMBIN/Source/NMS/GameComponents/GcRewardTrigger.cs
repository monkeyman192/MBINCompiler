using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x91D949875E632251, NameHash = 0x26F7A4B19402484D)]
    // ACTIVATE in big letters above it?

    public class GcRewardTrigger : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Trigger;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x839C25A4CCA9B9FA, NameHash = 0x9387E17DE22981F4)]
    public class GcMissionConditionWaitForTime : NMSTemplate
    {
        public ulong WaitTimeInSeconds;
    }
}

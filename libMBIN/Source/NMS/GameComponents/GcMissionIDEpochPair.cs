using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD2B07B00F953DE26, NameHash = 0x79FB303D79E7B435)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MissionID;
        public ulong RecurrenceDeadline;
    }
}

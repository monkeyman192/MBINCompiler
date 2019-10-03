using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x60314A82826889E0, NameHash = 0x271F1C7199403F55)]
    public class GcMissionSequenceFeed : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public bool RequireSpecificBait;
        public int AmountMin;
        public int Amountmax;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

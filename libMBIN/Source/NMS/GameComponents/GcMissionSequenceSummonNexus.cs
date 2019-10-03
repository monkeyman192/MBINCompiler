using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x48936E1996B98F72, NameHash = 0x96BA7F736F446E96)]
    public class GcMissionSequenceSummonNexus : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

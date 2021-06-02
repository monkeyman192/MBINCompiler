using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x57CFFBF13E7890F2, NameHash = 0xF34AADF7CA91192B)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        public NMSString0x10 Misssion;
        public bool UseSeed;
        public NMSString0x80 DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x57CFFBF13E7890F2, NameHash = 0xF34AADF7CA91192B)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Misssion;
        public bool UseSeed;
        [NMS(Size = 0x80)]
        public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

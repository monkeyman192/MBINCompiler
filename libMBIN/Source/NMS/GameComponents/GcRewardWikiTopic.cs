using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x4ADB6398A852FD7B, NameHash = 0x3C0FEBC212058A11)]
    public class GcRewardWikiTopic : NMSTemplate
    {
        public NMSString0x20A Topic;
        public bool CentreMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4ADB6398A852FD7B, NameHash = 0x3C0FEBC212058A11)]
    public class GcRewardWikiTopic : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Topic;
        public bool CentreMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA3BD75BDCBB35383, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechId;
        public bool AutoPin;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

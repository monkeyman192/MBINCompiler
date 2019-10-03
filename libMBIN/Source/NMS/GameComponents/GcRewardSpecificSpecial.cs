using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8429195766863F79, NameHash = 0xCF9FC45A7B70BB85)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Message;
    }
}

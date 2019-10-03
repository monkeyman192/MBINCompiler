using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4D18939438BD086D, NameHash = 0xFCFEF60947A44802)]
    public class GcRewardMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        public bool SetAsSelected;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

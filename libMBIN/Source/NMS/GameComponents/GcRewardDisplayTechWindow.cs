using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9BBD56EFA4E311E3, NameHash = 0xC04EFF3E2A378ED7)]
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechID;
        public bool Damaged;
        public bool NeedsInstall;
        public bool FullBox;
        [NMS(Size = 0x5)]
        public byte[] EndPadding;
    }
}

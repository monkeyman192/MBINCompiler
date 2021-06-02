using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x9BBD56EFA4E311E3, NameHash = 0xC04EFF3E2A378ED7)]
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        public NMSString0x10 TechID;
        public bool Damaged;
        public bool NeedsInstall;
        public bool FullBox;
        [NMS(Size = 0x5, Ignore = true)]
        public byte[] EndPadding;
    }
}
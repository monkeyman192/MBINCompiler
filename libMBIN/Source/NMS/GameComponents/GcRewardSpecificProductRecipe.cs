using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0xF76E52C52365A783, NameHash = 0xD0AAAD197E826825)]
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        public NMSString0x10 Id;
        public bool Slient;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
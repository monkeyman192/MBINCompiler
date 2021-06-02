using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x6CC8A9F4B7093108, NameHash = 0xAEE2DF0976A04EB1)]
    public class GcFreighterCargoOption : NMSTemplate
    {
        public NMSString0x10 ID;
        public int MinAmount;
        public int MaxAmount;
        public int PercentageChance;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;

    }
}

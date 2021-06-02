using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x360F73387712D16B, NameHash = 0xA655E8FCC4246967)]
    public class GcSubstanceSecondary : NMSTemplate
    {
        public NMSString0x10 ID;
        public float Chance;
        public float AmountMin;
        public float AmountMax;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
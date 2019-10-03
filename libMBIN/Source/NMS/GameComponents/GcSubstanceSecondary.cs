using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x360F73387712D16B, NameHash = 0xA655E8FCC4246967)]
    public class GcSubstanceSecondary : NMSTemplate     // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Chance;
        public float AmountMin;
        public float AmountMax;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}

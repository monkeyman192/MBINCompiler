using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7773BFB15E394873, NameHash = 0xA8C5FB6413CFB7AA)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        public float Amount;
        public bool SetNotAdd;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

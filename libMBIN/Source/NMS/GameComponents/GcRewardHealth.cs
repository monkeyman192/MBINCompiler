using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x27E0D4AB08937C59, NameHash = 0x5A9334071F34CD7A)]
    public class GcRewardHealth : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public bool SilentUnlessShieldAtMax;
    }
}
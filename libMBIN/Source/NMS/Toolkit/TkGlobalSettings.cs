using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x946EBC46CFF712E3, NameHash = 0x895773A5B3602466)]
    public class TkGlobalSettings : NMSTemplate
    {
        public bool DefaultSelectIgnoreAsserts;
        public int LoadBalanceTimeoutMS;
        public int VRLoadBalanceTimeoutMS;
    }
}

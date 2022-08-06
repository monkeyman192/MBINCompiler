using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2127956C2D3B50ED, NameHash = 0x6C8CA65FC11B0F92)]
    public class GcRewardShipMessage : NMSTemplate
    {
        public GcShipMessage ShipMessage;
    }
}
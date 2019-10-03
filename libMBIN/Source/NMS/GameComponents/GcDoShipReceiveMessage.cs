using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCC6D793345BEFEDA, NameHash = 0x7259326795A5F942)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        public GcShipMessage ShipMessage;
    }
}

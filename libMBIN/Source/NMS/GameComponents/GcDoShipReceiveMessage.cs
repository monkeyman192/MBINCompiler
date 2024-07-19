using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB30F2E1F0E6BA06D, NameHash = 0x88AA59E8)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcShipMessage ShipMessage;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x594C3AA0BF1F61C9, NameHash = 0x6C8CA65FC11B0F92)]
    public class GcRewardShipMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcShipMessage ShipMessage;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BC364EDC56B334, NameHash = 0xA947081E204C32BB)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSpaceshipComponentData Data;
    }
}

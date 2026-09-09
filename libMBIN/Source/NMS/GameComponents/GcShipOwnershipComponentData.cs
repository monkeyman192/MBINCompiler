using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x516E9EE74338E341, NameHash = 0xFC3967D1)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSpaceshipComponentData Data;
    }
}

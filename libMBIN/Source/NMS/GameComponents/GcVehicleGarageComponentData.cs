using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D7CAA4439FDFFD6, NameHash = 0xAE845CFB69D727BF)]
    public class GcVehicleGarageComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcVehicleType Vehicle;
    }
}

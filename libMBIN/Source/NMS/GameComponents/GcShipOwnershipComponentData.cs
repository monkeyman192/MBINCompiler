using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x150, Alignment = 0x10, GUID = 0xCEF2498474683652, NameHash = 0xA947081E204C32BB)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        public GcSpaceshipComponentData Data;
    }
}

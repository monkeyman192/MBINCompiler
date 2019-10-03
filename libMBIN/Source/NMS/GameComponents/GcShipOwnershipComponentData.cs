using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x150, GUID = 0x93663E16189CD5B6, NameHash = 0xA947081E204C32BB)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        public GcSpaceshipComponentData Data;
    }
}

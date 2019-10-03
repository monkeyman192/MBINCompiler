using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x328, GUID = 0xD7612D735D0C9C7A, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        public GcResourceElement ShipResource;
        public GcInventoryLayout ShipLayout;
        public GcInventoryContainer ShipInventory;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xD3947F166802A50B, NameHash = 0x46812D05ED43A48D)]
    public class GcVehicleType : NMSTemplate
    {
        //Note: enum in exe shows Buggy, Bike, ... but GcVehicleGlobals.EXML shows that the first entry is the Bike and 2nd the Buggy
        // 0x7 entries
        public enum VehicleTypeEnum { Bike, Buggy, Truck, WheeledBike, Hovercraft, Submarine, Mech }
		public VehicleTypeEnum VehicleType;
    }
}

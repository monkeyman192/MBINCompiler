using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBAADE8803679AD54, NameHash = 0xB9B04C0CA0357C57)]
    public class GcSpaceshipClasses : NMSTemplate
    {
		public enum ShipClassEnum { Freighter, Dropship, Fighter, Scientific, Shuttle, PlayerFreighter, Royal }
		public ShipClassEnum ShipClass;
    }
}

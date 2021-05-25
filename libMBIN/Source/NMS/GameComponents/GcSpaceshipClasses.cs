using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x283835244553D998, NameHash = 0xB9B04C0CA0357C57)]
    public class GcSpaceshipClasses : NMSTemplate
    {
        // size: 0x8
		public enum ShipClassEnum { Freighter, Dropship, Fighter, Scientific, Shuttle, PlayerFreighter, Royal, Alien }
		public ShipClassEnum ShipClass;
    }
}
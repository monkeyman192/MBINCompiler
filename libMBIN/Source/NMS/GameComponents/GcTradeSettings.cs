using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x9A0, GUID = 0x8F68EE50F618E060, NameHash = 0x4B63CD1B58DAF5A4)]
    public class GcTradeSettings : NMSTemplate
    {
        public GcTradeData SpaceStation;
        public GcTradeData Shop;
        public GcTradeData TechShop;
        public GcTradeData ShipTechSpecialist;
        public GcTradeData SuitTechSpecialist;
        public GcTradeData WeapTechSpecialist;
        public GcTradeData VehicleTechSpecialist;
        public GcTradeData Ship;
        public GcTradeData ExpShip;
        public GcTradeData TraShip;
        public GcTradeData WarShip;
        public GcTradeData LoneExp;
        public GcTradeData LoneTra;
        public GcTradeData LoneWar;
    }
}

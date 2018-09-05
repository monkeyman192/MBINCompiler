namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x6E0)]
    public class GcTradeSettings : NMSTemplate
    {
        public GcTradeData SpaceStation;
        public GcTradeData Shop;
        public GcTradeData TechShop;
        public GcTradeData ShipTechSpecialist;
        public GcTradeData SuitTechSpecialist;
        public GcTradeData WeapTechSpecialist;
        public GcTradeData Ship;
        public GcTradeData ExpShip;
        public GcTradeData TraShip;
        public GcTradeData WarShip;
    }
}

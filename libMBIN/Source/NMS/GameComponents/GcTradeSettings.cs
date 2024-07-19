using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x853588A426E3DB9E, NameHash = 0xBB646461)]
    public class GcTradeSettings : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x0000 */ public GcTradeData BuilderShop;
        [NMS(Index = 9)]
        /* 0x00D0 */ public GcTradeData ExpShip;
        [NMS(Index = 16)]
        /* 0x01A0 */ public GcTradeData IllegalProds;
        [NMS(Index = 12)]
        /* 0x0270 */ public GcTradeData LoneExp;
        [NMS(Index = 13)]
        /* 0x0340 */ public GcTradeData LoneTra;
        [NMS(Index = 14)]
        /* 0x0410 */ public GcTradeData LoneWar;
        [NMS(Index = 15)]
        /* 0x04E0 */ public GcTradeData MapShop;
        [NMS(Index = 7)]
        /* 0x05B0 */ public GcTradeData NexusTechSpecialist;
        [NMS(Index = 20)]
        /* 0x0680 */ public GcTradeData PirateTech;
        [NMS(Index = 21)]
        /* 0x0750 */ public GcTradeData PirateVisitor;
        [NMS(Index = 17)]
        /* 0x0820 */ public GcTradeData Scrap;
        [NMS(Index = 18)]
        /* 0x08F0 */ public GcTradeData SeasonRewardsShop;
        [NMS(Index = 8)]
        /* 0x09C0 */ public GcTradeData Ship;
        [NMS(Index = 3)]
        /* 0x0A90 */ public GcTradeData ShipTechSpecialist;
        [NMS(Index = 1)]
        /* 0x0B60 */ public GcTradeData Shop;
        [NMS(Index = 19)]
        /* 0x0C30 */ public GcTradeData SmugglerStation;
        [NMS(Index = 0)]
        /* 0x0D00 */ public GcTradeData SpaceStation;
        [NMS(Index = 4)]
        /* 0x0DD0 */ public GcTradeData SuitTechSpecialist;
        [NMS(Index = 2)]
        /* 0x0EA0 */ public GcTradeData TechShop;
        [NMS(Index = 10)]
        /* 0x0F70 */ public GcTradeData TraShip;
        [NMS(Index = 6)]
        /* 0x1040 */ public GcTradeData VehicleTechSpecialist;
        [NMS(Index = 11)]
        /* 0x1110 */ public GcTradeData WarShip;
        [NMS(Index = 5)]
        /* 0x11E0 */ public GcTradeData WeapTechSpecialist;
    }
}

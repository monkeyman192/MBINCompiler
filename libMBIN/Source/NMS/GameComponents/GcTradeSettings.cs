using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CEBF801DA6307DB, NameHash = 0xBB646461)]
    public class GcTradeSettings : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x0000 */ public GcTradeData BiggsBarterShop;
        [NMS(Index = 25)]
        /* 0x00E8 */ public GcTradeData BiggsBasicShop;
        [NMS(Index = 23)]
        /* 0x01D0 */ public GcTradeData BoneShop;
        [NMS(Index = 22)]
        /* 0x02B8 */ public GcTradeData BuilderShop;
        [NMS(Index = 9)]
        /* 0x03A0 */ public GcTradeData ExpShip;
        [NMS(Index = 16)]
        /* 0x0488 */ public GcTradeData IllegalProds;
        [NMS(Index = 12)]
        /* 0x0570 */ public GcTradeData LoneExp;
        [NMS(Index = 13)]
        /* 0x0658 */ public GcTradeData LoneTra;
        [NMS(Index = 14)]
        /* 0x0740 */ public GcTradeData LoneWar;
        [NMS(Index = 15)]
        /* 0x0828 */ public GcTradeData MapShop;
        [NMS(Index = 7)]
        /* 0x0910 */ public GcTradeData NexusTechSpecialist;
        [NMS(Index = 26)]
        /* 0x09F8 */ public GcTradeData PetShop;
        [NMS(Index = 20)]
        /* 0x0AE0 */ public GcTradeData PirateTech;
        [NMS(Index = 21)]
        /* 0x0BC8 */ public GcTradeData PirateVisitor;
        [NMS(Index = 17)]
        /* 0x0CB0 */ public GcTradeData Scrap;
        [NMS(Index = 18)]
        /* 0x0D98 */ public GcTradeData SeasonRewardsShop;
        [NMS(Index = 8)]
        /* 0x0E80 */ public GcTradeData Ship;
        [NMS(Index = 3)]
        /* 0x0F68 */ public GcTradeData ShipTechSpecialist;
        [NMS(Index = 1)]
        /* 0x1050 */ public GcTradeData Shop;
        [NMS(Index = 19)]
        /* 0x1138 */ public GcTradeData SmugglerStation;
        [NMS(Index = 27)]
        /* 0x1220 */ public GcTradeData SpaceOutpost;
        [NMS(Index = 0)]
        /* 0x1308 */ public GcTradeData SpaceStation;
        [NMS(Index = 4)]
        /* 0x13F0 */ public GcTradeData SuitTechSpecialist;
        [NMS(Index = 2)]
        /* 0x14D8 */ public GcTradeData TechShop;
        [NMS(Index = 10)]
        /* 0x15C0 */ public GcTradeData TraShip;
        [NMS(Index = 6)]
        /* 0x16A8 */ public GcTradeData VehicleTechSpecialist;
        [NMS(Index = 11)]
        /* 0x1790 */ public GcTradeData WarShip;
        [NMS(Index = 5)]
        /* 0x1878 */ public GcTradeData WeapTechSpecialist;
    }
}

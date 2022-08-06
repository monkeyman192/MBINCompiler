using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80B647C151FA4955, NameHash = 0x4B63CD1B58DAF5A4)]
    public class GcTradeSettings : NMSTemplate
    {
        /* 0x0000 */ public GcTradeData SpaceStation;
        /* 0x00D0 */ public GcTradeData Shop;
        /* 0x01A0 */ public GcTradeData TechShop;
        /* 0x0270 */ public GcTradeData ShipTechSpecialist;
        /* 0x0340 */ public GcTradeData SuitTechSpecialist;
        /* 0x0410 */ public GcTradeData WeapTechSpecialist;
        /* 0x04E0 */ public GcTradeData VehicleTechSpecialist;
        /* 0x05B0 */ public GcTradeData NexusTechSpecialist;
        /* 0x0680 */ public GcTradeData Ship;
        /* 0x0750 */ public GcTradeData ExpShip;
        /* 0x0820 */ public GcTradeData TraShip;
        /* 0x08F0 */ public GcTradeData WarShip;
        /* 0x09C0 */ public GcTradeData LoneExp;
        /* 0x0A90 */ public GcTradeData LoneTra;
        /* 0x0B60 */ public GcTradeData LoneWar;
        /* 0x0C30 */ public GcTradeData MapShop;
        /* 0x0D00 */ public GcTradeData IllegalProds;
        /* 0x0DD0 */ public GcTradeData Scrap;
        /* 0x0EA0 */ public GcTradeData SeasonRewardsShop;
        /* 0x0F70 */ public GcTradeData SmugglerStation;
        /* 0x1040 */ public GcTradeData PirateTech;
        /* 0x1110 */ public GcTradeData PirateVisitor;
    }
}

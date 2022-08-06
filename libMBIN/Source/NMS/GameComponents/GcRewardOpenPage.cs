using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E12DB2AF27BE1C0, NameHash = 0xF1F483BCEFC0AD13)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // size: 0xF
        public enum PageToOpenEnum { FreighterShipTransfer, DisplayPortalUa, ExpeditionSelect, TraderInventory,
            ExpeditionDetails, ExpeditionDebrief, BuildingPartsShop, ExocraftShop,
            NexusTechShop, ScrapDealerShop, BuyShip, SettlementManagement, SquadronManagement,
            SquadronRecruitment, FleetManagement
        }
        /* 0x0 */ public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
    }
}

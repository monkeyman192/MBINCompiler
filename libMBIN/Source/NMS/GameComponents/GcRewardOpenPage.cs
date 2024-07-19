namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82C2E1DE66FB5479, NameHash = 0x1AD5DE55)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // size: 0x10
        public enum PageToOpenEnum : uint {
            FreighterShipTransfer,
            DisplayPortalUa,
            ExpeditionSelect,
            TraderInventory,
            ExpeditionDetails,
            ExpeditionDebrief,
            BuildingPartsShop,
            ExocraftShop,
            NexusTechShop,
            ScrapDealerShop,
            BuyShip,
            SettlementManagement,
            SquadronManagement,
            SquadronRecruitment,
            FleetManagement,
            WeaponCustomisation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PageToOpenEnum PageToOpen;
        [NMS(Index = 1)]
        /* 0x4 */ public bool ReinteractWhenComplete;
    }
}

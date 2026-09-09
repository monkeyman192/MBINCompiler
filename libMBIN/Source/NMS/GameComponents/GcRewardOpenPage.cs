namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x573D3D7668DC9265, NameHash = 0x1AD5DE55)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // size: 0x1C
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
            SettlementsOverview,
            SettlementManagement,
            SettlerNPCDetails,
            SquadronManagement,
            SquadronRecruitment,
            FleetManagement,
            WeaponCustomisation,
            FoodUnit,
            CookTrade,
            ArchiveManagementShip,
            BoneShop,
            BiggsBarterShop,
            BiggsBasicShop,
            PetShop,
            ManageBase,
            AlliancesWindow,
            StationOwnership,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PageToOpenEnum PageToOpen;
        [NMS(Index = 1)]
        /* 0x4 */ public bool ReinteractWhenComplete;
    }
}

namespace libMBIN.Models.Structs
{
    public class GcRewardOpenPage : NMSTemplate
    {
        public int PageToOpen;
        public string[] PageToOpenValues()
        {
            return new[] { "FreighterShipTransfer", "DisplayPortalUa", "ExpeditionSelect", "TraderInventory", "ExpeditionDetails",
                           "ExpeditionDebrief", "FreeFreighterReward", "BuildingPartsShop"};
        }
    }
}

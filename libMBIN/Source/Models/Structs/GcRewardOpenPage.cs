namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcRewardOpenPage : NMSTemplate
    {
        /* 0x0 */ public int PageToOpen;
        public string[] PageToOpenValues()
        {
            return new[] { "FreighterShipTransfer", "DisplayPortalUa", "ExpeditionSelect", "TraderInventory", "ExpeditionDetails",
                           "ExpeditionDebrief", "FreeFreighterReward", "BuildingPartsShop"};
        }
        /* 0x4 */ public bool ReinteractWhenComplete;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] Endpadding;
    }
}

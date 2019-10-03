using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x7B315E9093FB9325, Broken = true, NameHash = 0xF1F483BCEFC0AD13)]
    public class GcRewardOpenPage : NMSTemplate
    {
		public enum PageToOpenEnum { FreighterShipTransfer, DisplayPortalUa, ExpeditionSelect, TraderInventory, ExpeditionDetails, ExpeditionDebrief, FreeFreighterReward, BuildingPartsShop }
		public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] Endpadding;
    }
}

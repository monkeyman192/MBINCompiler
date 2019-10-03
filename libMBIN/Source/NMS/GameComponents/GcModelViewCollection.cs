using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xFD0, GUID = 0x24C45175DCC970E9, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        public enum ModelViewEnum { Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain,
                                    ToolboxThumbnail, TradeSuit, TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter,
                                    TradeFreighter, TradeChest, TradeCapsule, TradeFrigate, TerrainBall, FreighterChest, Submarine, TradeCooker }
        [NMS(Size = 0x17, EnumType = typeof(ModelViewEnum))]
        public TkModelRendererData[] ModelViews;
    }
}

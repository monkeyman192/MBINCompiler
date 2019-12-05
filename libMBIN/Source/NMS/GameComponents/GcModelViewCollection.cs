using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1130, GUID = 0xED972786E8177E52, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        public enum ModelViewEnum {
            Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain, ToolboxThumbnail, TradeSuit,
            TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter, TradeFreighter, TradeChest, TradeCapsule, TradeFrigate,
            TerrainBall, FreighterChest, Submarine, TradeCooker, SuitRefiner, FreighterRepair
        }
        [NMS(Size = 0x19, EnumType = typeof(ModelViewEnum))]
        public TkModelRendererData[] ModelViews;
    }
}

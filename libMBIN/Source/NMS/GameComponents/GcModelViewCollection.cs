using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF84EA2D9C6347E4, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        // size: 0x29
        public enum ModelViewsEnum {
            Suit,
            Weapon,
            Ship,
            Vehicle,
            DiscoveryMain,
            DiscoveryThumbnail,
            WonderThumbnail,
            WonderThumbnailCreatureSmall,
            WonderThumbnailCreatureMed,
            WonderThumbnailCreatureLarge,
            WonderThumbnailFloraSmall,
            WonderThumbnailFloraLarge,
            WonderThumbnailMineralSmall,
            WonderThumbnailMineralLarge,
            ToolboxMain,
            ToolboxThumbnail,
            TradeSuit,
            TradeShip,
            TradeCompareShips,
            TradeCompareWeapons,
            HUDThumbnail,
            Interaction,
            Freighter,
            TradeFreighter,
            TradeChest,
            TradeCapsule,
            TradeFrigate,
            TerrainBall,
            FreighterChest,
            Submarine,
            TradeCooker,
            SuitRefiner,
            FreighterRepair,
            DiscoveryPlanetaryMapping,
            Mech,
            PetThumbnail,
            PetThumbnailUI,
            PetLarge,
            SquadronPilotLarge,
            SquadronPilotThumbnail,
            SquadronSpaceshipThumbnail,
        }
        [NMS(Index = 0, Size = 0x29, EnumType = typeof(ModelViewsEnum))]
        /* 0x0 */ public TkModelRendererData[] ModelViews;
    }
}

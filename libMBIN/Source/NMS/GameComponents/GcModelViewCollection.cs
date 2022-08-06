using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A8E04C3E727B08C, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        // size: 0x21
        public enum ModelViewEnum {
            Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain, ToolboxThumbnail, TradeSuit,
            TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter, TradeFreighter,
            TradeChest, TradeCapsule, TradeFrigate, TerrainBall, FreighterChest, Submarine, TradeCooker, SuitRefiner,
            FreighterRepair, DiscoveryPlanetaryMapping, Mech, PetThumbnail, PetThumbnailUI, PetLarge, SquadronPilotLarge,
            SquadronPilotThumbnail, SquadronSpaceshipThumbnail
        }
        [NMS(Size = 0x21, EnumType = typeof(ModelViewEnum))]
        /* 0x0 */ public TkModelRendererData[] ModelViews;
    }
}

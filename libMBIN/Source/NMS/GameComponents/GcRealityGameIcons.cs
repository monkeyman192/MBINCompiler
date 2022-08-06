using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6136CA74055A1C4, NameHash = 0x878911013D83AEE9)]
    public class GcRealityGameIcons : NMSTemplate
    {
        // size: 0x56
        public enum GameIconsEnum { Stamina, NoStamina, EnergyCharge, Scanner, NoScanner, Grave, Resources, Inventory,
            InventoryFull, RareItems, Pirates, PirateScan, Drone, Quad,
            Mech, Walker, DroneOff, Police, AtlasStation, BlackHole, SaveGame, SaveInventory,
            Jetpack, JetpackEmpty, VehicleBoost, VehicleBoostRecharge,
            Fuel, GekStanding, VykeenStanding, KorvaxStanding, GekDiamondStanding,
            VykeenDiamondStanding, KorvaxDiamondStanding, TradeGuildStanding, WarGuildStanding,
            ExplorationGuildStanding, TradeGuildDiamondStanding, WarGuildDiamondStanding,
            ExplorationGuildDiamondStanding, GMPathToCentre,
            GMAtlas, GMBlackHole, GMUserWaypoint, GMUserMission, GMSeasonal, TransferPersonal,
            TransferPersonalCargo, TransferShip, TransferBike, TransferBuggy,
            TransferTruck, TransferWheeledBike, TransferHovercraft, TransferSubmarine,
            TransferMech, TransferFreighter, TransferBase, HazardIndicatorHot,
            HazardIndicatorCold, HazardIndicatorRadiation, HazardIndicatorToxic,
            TerrainAdd, TerrainRemove, TerrainFlatten, TerrainUndo, SpacePhone,
            GarageMarkerBuggy, GarageMarkerBike, GarageMarkerTruck, GarageMarkerWheeledBike,
            GarageMarkerHovercraft, CorruptedDrone, HandHold,
            ShipThumbnailBG, CClass, BClass, AClass, SClass, NoSaveWarning, ExploreMissionPlanetIcon,
            ExploreMissionSystemIcon, PetThumbnailBG, SettlementOSD,
            Stealth, StealthEmpty, DefenceForce
        }
        /* 0x0 */ public GameIconsEnum GameIcons;
    }
}

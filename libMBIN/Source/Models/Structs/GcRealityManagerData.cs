using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x9B00)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public int RealityIteration;

        [NMS(Size = 0xF)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x01A8 */ public float[] CreatureDiscoverySizeMultiplier;

        /* 0x01B8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;

        /* 0x01C8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;

        [NMS(Size = 0x80)]
        /* 0x0368 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x03E8 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0468 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x04E8 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x0568 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x05E8 */ public string LegacyItemConversionTable;

        /* 0x0668 */ public List<TkRawID> LegacyRepairTable;

        [NMS(Size = 0x80)]
        /* 0x0678 */ public string AlienWordsTable;

        /* 0x06F8 */ public List<NMSString0x80> AlienPuzzlesTables;

        [NMS(Size = 0x4B, EnumValue = new string[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver"
            })]
        /* 0x0708 */ public bool[] LoopInteractionPuzzles;

        [NMS(Size = 0x4B, EnumValue = new string[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver"
            })]
        /* 0x0754 */ public int[] InteractionPuzzlesIndexTypes;

        [NMS(Size = 0x7, EnumValue = new string[] { "NoWeighting", "MaxIsUncommon", "MaxIsRare", "MaxIsSuperRare", "MinIsUncommon", "MinIsRare", "MinIsSuperRare" })]
        /* 0x0880 */ public TkCurveType[] WeightingCurves;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x089C */ public byte[] Padding89C;

        /* 0x08A0 */ public List<GcDamageMultiplierLookup> DamageTableMultiplier;

        [NMS(Size = 0x80)]
        /* 0x08B0 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0930 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x09B0 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0A30 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0AB0 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0B30 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0BB0 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0C30 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0CB0 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0D30 */ public string MaintenanceGroupsTable;

        /* 0x0DB0 */ public List<GcRefinerRecipe> RefinerRecipeTable1Input;
        /* 0x0DC0 */ public List<GcRefinerRecipe> RefinerRecipeTable2Input;
        /* 0x0DD0 */ public List<GcRefinerRecipe> RefinerRecipeTable3Input;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Laser", "Projectile", "Shotgun", "Minigun", "Plasma", "Missile", "Rocket"})]
        /* 0x0DE0 */ public GcShipWeapons[] ShipWeapons;

        [NMS(Size = 0xA, EnumValue = new string[] { "Bolt", "Shotgun", "Burst", "Laser", "Rail", "Grenade", "MineGrenade", "Scope", "FrontShield", "TerrainEdit" })]
        /* 0x0FA0 */ public GcPlayerWeaponData[] PlayerWeapons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x1040 */ public NMSString0x10[] FactionStandingIDs;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x10B0 */ public NMSString0x20[] FactionNames;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x1090 */ public GcNumberedTextList[] FactionClients;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x128C */ public GcNumberedTextList[] MissionNameFormats;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x13D0 */ public GcNumberedTextList[] MissionNameAdjectives;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x1514 */ public GcNumberedTextList[] MissionNameNouns;

        [NMS(Size = 0x3)]
        /* 0x1658 */ public float[] WeightedTextWeights;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1664 */ public byte[] Padding1664;

        /* 0x1668 */ public GcRealityIconTable Icons;

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x5370 */ public Colour[] HazardColours;

        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        /* 0x53D0 */ public Colour[] RarityColours;

        [NMS(Size = 9, EnumValue = new string[9] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x5400 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 9, EnumValue = new string[9] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x5490 */ public TkTextureResource[] SubstanceChargeIcons;

        [NMS(Size = 0x6E, EnumValue = new string[0x6E]
            {
                "Unspecified", "Weapon_Laser", "Weapon_Laser_Damage", "Weapon_Laser_Mining_Speed", "Weapon_Laser_HeatTime",
                "Weapon_Laser_Bounce", "Weapon_Laser_ReloadTime", "Weapon_Laser_Recoil", "Weapon_Laser_Drain", "Weapon_Laser_StrongLaser",
                "Weapon_Laser_ChargeTime", "Weapon_Projectile", "Weapon_Projectile_Damage", "Weapon_Projectile_Range", "Weapon_Projectile_Rate",
                "Weapon_Projectile_ClipSize", "Weapon_Projectile_ReloadTime", "Weapon_Projectile_Recoil", "Weapon_Projectile_Bounce",
                "Weapon_Projectile_Homing", "Weapon_Projectile_Dispersion", "Weapon_Projectile_BulletsPerShot", "Weapon_Projectile_MaximumCharge",
                "Weapon_Rail", "Weapon_Shotgun", "Weapon_Burst", "Weapon_Grenade", "Weapon_Grenade_Damage", "Weapon_Grenade_Radius",
                "Weapon_Grenade_Speed", "Weapon_Grenade_Bounce", "Weapon_Grenade_Homing", "Weapon_Grenade_Clusterbomb", "Weapon_TerrainEdit",
                "Weapon_MineGrenade", "Weapon_FrontShield", "Weapon_Scope", "Weapon_Scan", "Weapon_Scan_Radius", "Weapon_Scan_Recharge_Time",
                "Weapon_Scan_Types", "Weapon_Scan_Binoculars", "Weapon_Scan_Discovery_Creature", "Weapon_Scan_Discovery_Flora",
                "Weapon_Scan_Secondary", "Weapon_Scan_Terrain_Resource", "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength",
                "Suit_Energy", "Suit_Energy_Regen", "Suit_Protection", "Suit_Protection_Cold", "Suit_Protection_Heat", "Suit_Protection_Toxic",
                "Suit_Protection_Radiation", "Suit_Underwater", "Suit_DamageReduce_Cold", "Suit_DamageReduce_Heat", "Suit_DamageReduce_Toxic",
                "Suit_DamageReduce_Radiation", "Suit_Stamina_Strength", "Suit_Stamina_Speed", "Suit_Jetpack", "Suit_Jetpack_Tank",
                "Suit_Jetpack_Drain", "Suit_Jetpack_Ignition", "Suit_Jetpack_DoubleJump", "Suit_Utility", "Ship_Weapons_Guns",
                "Ship_Weapons_Guns_Damage", "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime", "Ship_Weapons_Guns_CoolTime",
                "Ship_Weapons_Guns_Scale", "Ship_Weapons_Guns_BulletsPerShot", "Ship_Weapons_Guns_Dispersion", "Ship_Weapons_Guns_Range",
                "Ship_Weapons_Guns_Damage_Radius", "Ship_Weapons_Lasers", "Ship_Weapons_Lasers_Damage", "Ship_Weapons_Lasers_HeatTime",
                "Ship_Weapons_Missiles", "Ship_Weapons_Missiles_NumPerShot", "Ship_Weapons_Missiles_Speed", "Ship_Weapons_Missiles_Damage",
                "Ship_Weapons_Missiles_Size", "Ship_Weapons_Shotgun", "Ship_Weapons_MiniGun", "Ship_Weapons_Plasma", "Ship_Weapons_Rockets",
                "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health", "Ship_Scan", "Ship_Scan_EconomyFilter",
                "Ship_Scan_ConflictFilter", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance", "Ship_Hyperdrive_JumpsPerCell", "Ship_Launcher",
                "Ship_Launcher_TakeOffCost", "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost", "Ship_Maneuverability",
                "Ship_BoostManeuverability", "Ship_Teleport", "Freighter_Hyperdrive", "Freighter_Hyperdrive_JumpDistance"
            })]
        /* 0x5934 */ public TkTextureResource[] StatCategoryIcons;

        [NMS(Size = 4, EnumValue = new string[4] { "Suit", "Weapon", "Ship", "Freighter" })]
        /* 0x91F0 */ public GcStats[] Stats;

        /* 0x9230 */ public GcTechList StationTechShops;

        [NMS(Size = 0xD)]
        /* 0x9240 */ public GcTechList[] PlanetTechShops;

        /* 0x9310 */ public GcTradeSettings TradeSettings;
        /* 0x99F0 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x9A10 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x9A30 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x9A50 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x9A70 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x9A90 */ public List<int> SuitUpgradePrices;
        /* 0x9AA0 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x9AB0 */ public List<int> SuitCargoUpgradePrices;
        /* 0x9AC0 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x9AD0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special"})]         // not sure about these values....
        /* 0x9AE0 */ public float[] NormalizedPriceLimits;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}

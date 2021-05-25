using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x3312ECE81220D1FF, NameHash = 0x47E189998F5D82E7)]
    public class GcInteractionType : NMSTemplate
    {
        // size: 0x73
        public enum InteractionTypeEnum {
            None, Shop, NPC, NPC_Secondary, NPC_Anomaly, NPC_Anomaly_Secondary, Ship, Outpost, SpaceStation, RadioTower,
            Monolith, Factory, AbandonedShip, Harvester, Observatory, TradingPost, DistressBeacon, Portal, Plaque, AtlasStation,
            AbandonedBuildings, WeaponTerminal, SuitTerminal, SignalScanner, Teleporter_Base, Teleporter_Station, ClaimBase, NPC_Freighter_Captain, NPC_HIRE_Weapons, NPC_HIRE_Weapons_Wait,
            NPC_HIRE_Farmer, NPC_HIRE_Farmer_Wait, NPC_HIRE_Builder, NPC_HIRE_Builder_Wait, NPC_HIRE_Vehicles, NPC_HIRE_Vehicles_Wait, MessageBeacon, NPC_HIRE_Scientist, NPC_HIRE_Scientist_Wait, NPC_Recruit,
            NPC_Freighter_Captain_Secondary, NPC_Recruit_Secondary, Vehicle, MessageModule, TechShop, VehicleRaceStart, BuildingShop, MissionGiver, HoloHub, HoloExplorer,
            HoloSceptic, HoloNoone, PortalRuneEntry, PortalActivate, CrashedFreighter, GraveInCave, GlitchyStoryBox, NetworkPlayer, NetworkMonument, AnomalyComputer,
            AtlasPlinth, Epilogue, GuildEnvoy, ManageFleet, ManageExpeditions, Frigate, CustomiseCharacter, CustomiseShip, CustomiseWeapon, CustomiseVehicle,
            ClaimBaseAnywhere, FleetNavigator, FleetCommandPost, StoryUtility, MPMissionGiver, SpecialsShop, WaterRuin, LocationScanner, ByteBeat, NPC_CrashSite,
            NPC_Scavenger, BaseGridPart, NPC_Freighter_Crew, NPC_Freighter_Crew_Owned, AbandonedShip_With_NPC, ShipPilot, NexusMilestones, NexusDailyMission, CreatureFeeder, ExoticExtra1,
            ExoticExtra2, ExoticExtra3, ExoticExtra4, ExoticExtra5, ExoticExtra6, MapShop, NPC_Closure, StorageContainer, Teleporter_Nexus, ShipSalvage,
            ByteBeatSwitch, AbandonedFreighterIntro, AbandonedFreighterEnd, AbandonedFreighterProcText, AbandonedFreighterCaptLog, AbandonedFreighterCrewLog, AbandonedFreighterShop, CustomiseFreighter, LibraryVault, LibraryMainTerminal,
            LibraryMap, WeaponUpgrade, Pet, Creature, FreighterGalacticMap
        }
		public InteractionTypeEnum InteractionType;
    }
}
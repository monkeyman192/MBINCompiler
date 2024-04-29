using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72F432427EAFB1D9, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 68, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 60)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 62)]
        /* 0x25E8 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 61)]
        /* 0x2740 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 63)]
        /* 0x2898 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 64)]
        /* 0x29F0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 40)]
        /* 0x2B48 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 41)]
        /* 0x2C50 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 105)]
        /* 0x2D58 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 65)]
        /* 0x2E28 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 32)]
        /* 0x2E58 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 35)]
        /* 0x2E78 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 33)]
        /* 0x2E98 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 34)]
        /* 0x2EB8 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 21)]
        /* 0x2ED8 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x2EF8 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 30)]
        /* 0x2F18 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 29)]
        /* 0x2F38 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x2F58 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 27)]
        /* 0x2F78 */ public NMSString0x20A SeasonName;
        [NMS(Index = 28)]
        /* 0x2F98 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 57)]
        /* 0x2FB8 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 58)]
        /* 0x2FD0 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 56)]
        /* 0x2FE8 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 38)]
        /* 0x3000 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 15)]
        /* 0x3010 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 19)]
        /* 0x3020 */ public NMSString0x10 FinalReward;
        [NMS(Index = 20)]
        /* 0x3030 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 89)]
        /* 0x3040 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 54)]
        /* 0x3050 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 88)]
        /* 0x3060 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 39)]
        /* 0x3070 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 103)]
        /* 0x3080 */ public List<GcProductData> ProductTable;
        [NMS(Index = 67)]
        /* 0x3090 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 70)]
        /* 0x30A0 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 97)]
        /* 0x30B0 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 46)]
        /* 0x30C0 */ public GcSeed ShipSeed;
        [NMS(Index = 96)]
        /* 0x30D0 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 83)]
        /* 0x30E0 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 99)]
        /* 0x30F0 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 104)]
        /* 0x3100 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 16)]
        /* 0x3110 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 102)]
        /* 0x3120 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 55)]
        /* 0x3130 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 45)]
        /* 0x3140 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x3150 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x3158 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x3160 */ public ulong StartTimeUTC;
        [NMS(Index = 18)]
        /* 0x3168 */ public ulong UAOverrideValue;
        [NMS(Index = 23)]
        /* 0x3170 */ public TkTextureResource MainIcon;
        [NMS(Index = 14)]
        /* 0x31F4 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 91)]
        /* 0x324C */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 77)]
        /* 0x3250 */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 13)]
        /* 0x3254 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 26)]
        /* 0x3258 */ public int DisplayNumber;
        [NMS(Index = 76)]
        /* 0x325C */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 94)]
        /* 0x3260 */ public float EnergyDrainMultiplier;
        [NMS(Index = 92)]
        /* 0x3264 */ public float FarmPlantsTimerMul;
        [NMS(Index = 85)]
        /* 0x3268 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 50)]
        /* 0x326C */ public GcAlienRace FreighterRace;
        [NMS(Index = 12)]
        /* 0x3270 */ public GcGameMode GameMode;
        [NMS(Index = 93)]
        /* 0x3274 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 95)]
        /* 0x3278 */ public int QuestSubstanceReducer;
        [NMS(Index = 25)]
        /* 0x327C */ public int RemixNumber;
        [NMS(Index = 73)]
        /* 0x3280 */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 72)]
        /* 0x3284 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x3288 */ public int SeasonId;
        [NMS(Index = 24)]
        /* 0x328C */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x3290 */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 47)]
        /* 0x3294 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 69)]
        /* 0x3298 */ public int StartingPetSlots;
        [NMS(Index = 44)]
        /* 0x329C */ public int StartingSuitCargoSlots;
        [NMS(Index = 42)]
        /* 0x32A0 */ public int StartingSuitSlots;
        [NMS(Index = 43)]
        /* 0x32A4 */ public int StartingSuitTechSlots;
        [NMS(Index = 87)]
        /* 0x32A8 */ public int TechCostMultiplier;
        [NMS(Index = 22)]
        /* 0x32AC */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 49)]
        /* 0x34AC */ public NMSString0x80 FreighterBaseOverrideFilename;
        [NMS(Index = 6)]
        /* 0x352C */ public NMSString0x20 Description;
        [NMS(Index = 17)]
        /* 0x354C */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x356C */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x358C */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x35AC */ public NMSString0x20 Title;
        [NMS(Index = 81)]
        /* 0x35CC */ public bool AllowMissionDetailMessages;
        [NMS(Index = 80)]
        /* 0x35CD */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 11)]
        /* 0x35CE */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 79)]
        /* 0x35CF */ public bool BlockStormsAtStart;
        [NMS(Index = 100)]
        /* 0x35D0 */ public bool CompatibleWithState;
        [NMS(Index = 36)]
        /* 0x35D1 */ public bool DefaultToPvPOff;
        [NMS(Index = 31)]
        /* 0x35D2 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 86)]
        /* 0x35D3 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 53)]
        /* 0x35D4 */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 52)]
        /* 0x35D5 */ public bool ForceStartSystemTernary;
        [NMS(Index = 101)]
        /* 0x35D6 */ public bool HasBeenConverted;
        [NMS(Index = 90)]
        /* 0x35D7 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 37)]
        /* 0x35D8 */ public bool MustCraftInBases;
        [NMS(Index = 98)]
        /* 0x35D9 */ public bool ResetSaveOnDeath;
        [NMS(Index = 71)]
        /* 0x35DA */ public bool SandwormGlobalOverride;
        [NMS(Index = 75)]
        /* 0x35DB */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 78)]
        /* 0x35DC */ public bool ShipStartsDamaged;
        [NMS(Index = 51)]
        /* 0x35DD */ public bool StartAboardFreighter;
        [NMS(Index = 74)]
        /* 0x35DE */ public bool StartNextToShip;
        [NMS(Index = 48)]
        /* 0x35DF */ public bool StartWithFreighter;
        [NMS(Index = 84)]
        /* 0x35E0 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 59)]
        /* 0x35E1 */ public bool UseDefaultAppearance;
        [NMS(Index = 66)]
        /* 0x35E2 */ public bool UseRandomPet;
        [NMS(Index = 106)]
        /* 0x35E3 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 82)]
        /* 0x35E4 */ public bool UseStartPlanetObjectListOverrides;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C64DED6D9A99E43, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 71, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 63)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 65)]
        /* 0x25E8 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 64)]
        /* 0x2740 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 66)]
        /* 0x2898 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 67)]
        /* 0x29F0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 110)]
        /* 0x2B48 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 40)]
        /* 0x2C18 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 41)]
        /* 0x2CB0 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 68)]
        /* 0x2D48 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 32)]
        /* 0x2D78 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 35)]
        /* 0x2D98 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 33)]
        /* 0x2DB8 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 34)]
        /* 0x2DD8 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 21)]
        /* 0x2DF8 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x2E18 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 30)]
        /* 0x2E38 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 29)]
        /* 0x2E58 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x2E78 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 27)]
        /* 0x2E98 */ public NMSString0x20A SeasonName;
        [NMS(Index = 28)]
        /* 0x2EB8 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 23)]
        /* 0x2ED8 */ public TkTextureResource MainIcon;
        [NMS(Index = 60)]
        /* 0x2EF0 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 61)]
        /* 0x2F08 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 59)]
        /* 0x2F20 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 38)]
        /* 0x2F38 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 15)]
        /* 0x2F48 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 19)]
        /* 0x2F58 */ public NMSString0x10 FinalReward;
        [NMS(Index = 20)]
        /* 0x2F68 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 94)]
        /* 0x2F78 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 50)]
        /* 0x2F88 */ public VariableSizeString FreighterBaseOverrideFilename;
        [NMS(Index = 56)]
        /* 0x2F98 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 93)]
        /* 0x2FA8 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 39)]
        /* 0x2FB8 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 48)]
        /* 0x2FC8 */ public VariableSizeString OverrideMTFilename;
        [NMS(Index = 108)]
        /* 0x2FD8 */ public List<GcProductData> ProductTable;
        [NMS(Index = 70)]
        /* 0x2FE8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 73)]
        /* 0x2FF8 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 102)]
        /* 0x3008 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 46)]
        /* 0x3018 */ public GcSeed ShipSeed;
        [NMS(Index = 101)]
        /* 0x3028 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 88)]
        /* 0x3038 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 104)]
        /* 0x3048 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 109)]
        /* 0x3058 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 16)]
        /* 0x3068 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 107)]
        /* 0x3078 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 58)]
        /* 0x3088 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 45)]
        /* 0x3098 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x30A8 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x30B0 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x30B8 */ public ulong StartTimeUTC;
        [NMS(Index = 18)]
        /* 0x30C0 */ public ulong UAOverrideValue;
        [NMS(Index = 14)]
        /* 0x30C8 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 96)]
        /* 0x3120 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 80)]
        /* 0x3124 */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 13)]
        /* 0x3128 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 26)]
        /* 0x312C */ public int DisplayNumber;
        [NMS(Index = 79)]
        /* 0x3130 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 99)]
        /* 0x3134 */ public float EnergyDrainMultiplier;
        [NMS(Index = 97)]
        /* 0x3138 */ public float FarmPlantsTimerMul;
        [NMS(Index = 90)]
        /* 0x313C */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 51)]
        /* 0x3140 */ public GcAlienRace FreighterRace;
        [NMS(Index = 12)]
        /* 0x3144 */ public GcGameMode GameMode;
        [NMS(Index = 98)]
        /* 0x3148 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 100)]
        /* 0x314C */ public int QuestSubstanceReducer;
        [NMS(Index = 25)]
        /* 0x3150 */ public int RemixNumber;
        [NMS(Index = 76)]
        /* 0x3154 */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 75)]
        /* 0x3158 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x315C */ public int SeasonId;
        [NMS(Index = 24)]
        /* 0x3160 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x3164 */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 47)]
        /* 0x3168 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 72)]
        /* 0x316C */ public int StartingPetSlots;
        [NMS(Index = 44)]
        /* 0x3170 */ public int StartingSuitCargoSlots;
        [NMS(Index = 42)]
        /* 0x3174 */ public int StartingSuitSlots;
        [NMS(Index = 43)]
        /* 0x3178 */ public int StartingSuitTechSlots;
        [NMS(Index = 92)]
        /* 0x317C */ public int TechCostMultiplier;
        [NMS(Index = 22)]
        /* 0x3180 */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 6)]
        /* 0x3380 */ public NMSString0x20 Description;
        [NMS(Index = 17)]
        /* 0x33A0 */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x33C0 */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x33E0 */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x3400 */ public NMSString0x20 Title;
        [NMS(Index = 86)]
        /* 0x3420 */ public bool AllowMissionDetailMessages;
        [NMS(Index = 83)]
        /* 0x3421 */ public bool AlwaysStormy;
        [NMS(Index = 112)]
        /* 0x3422 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 84)]
        /* 0x3423 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 85)]
        /* 0x3424 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 11)]
        /* 0x3425 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 82)]
        /* 0x3426 */ public bool BlockStormsAtStart;
        [NMS(Index = 57)]
        /* 0x3427 */ public bool CarnageMode;
        [NMS(Index = 105)]
        /* 0x3428 */ public bool CompatibleWithState;
        [NMS(Index = 36)]
        /* 0x3429 */ public bool DefaultToPvPOff;
        [NMS(Index = 31)]
        /* 0x342A */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 55)]
        /* 0x342B */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 91)]
        /* 0x342C */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 54)]
        /* 0x342D */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 53)]
        /* 0x342E */ public bool ForceStartSystemTernary;
        [NMS(Index = 106)]
        /* 0x342F */ public bool HasBeenConverted;
        [NMS(Index = 95)]
        /* 0x3430 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 37)]
        /* 0x3431 */ public bool MustCraftInBases;
        [NMS(Index = 103)]
        /* 0x3432 */ public bool ResetSaveOnDeath;
        [NMS(Index = 74)]
        /* 0x3433 */ public bool SandwormGlobalOverride;
        [NMS(Index = 78)]
        /* 0x3434 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 81)]
        /* 0x3435 */ public bool ShipStartsDamaged;
        [NMS(Index = 52)]
        /* 0x3436 */ public bool StartAboardFreighter;
        [NMS(Index = 77)]
        /* 0x3437 */ public bool StartNextToShip;
        [NMS(Index = 49)]
        /* 0x3438 */ public bool StartWithFreighter;
        [NMS(Index = 89)]
        /* 0x3439 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 62)]
        /* 0x343A */ public bool UseDefaultAppearance;
        [NMS(Index = 69)]
        /* 0x343B */ public bool UseRandomPet;
        [NMS(Index = 111)]
        /* 0x343C */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 87)]
        /* 0x343D */ public bool UseStartPlanetObjectListOverrides;
    }
}

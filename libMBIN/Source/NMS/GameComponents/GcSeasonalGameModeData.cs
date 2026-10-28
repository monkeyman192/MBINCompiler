using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE8DD783F7C3C783, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 79, Size = 0x1E)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 125)]
        /* 0x5910 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 71)]
        /* 0x5C88 */ public GcInventoryContainer Inventory;
        [NMS(Index = 73)]
        /* 0x5DE8 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 72)]
        /* 0x5F48 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 74)]
        /* 0x60A8 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 75)]
        /* 0x6208 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 40)]
        /* 0x6368 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 41)]
        /* 0x6400 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 96, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x6498 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 76)]
        /* 0x64C8 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 48, Size = 0x3, EnumType = typeof(GcCommunityTeam.CommunityTeamEnum))]
        /* 0x64F8 */ public GcSeed[] TeamShipSeeds;
        [NMS(Index = 158)]
        /* 0x6528 */ public NMSString0x20A CommunityCompleteMessageSubtitleOverride;
        [NMS(Index = 157)]
        /* 0x6548 */ public NMSString0x20A CommunityCompleteMessageTitleOverride;
        [NMS(Index = 150)]
        /* 0x6568 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 153)]
        /* 0x6588 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 151)]
        /* 0x65A8 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 152)]
        /* 0x65C8 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 23)]
        /* 0x65E8 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x6608 */ public NMSString0x20A FinalMilestoneFormat;
        [NMS(Index = 9)]
        /* 0x6628 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 32)]
        /* 0x6648 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 31)]
        /* 0x6668 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 10)]
        /* 0x6688 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 29)]
        /* 0x66A8 */ public NMSString0x20A SeasonName;
        [NMS(Index = 30)]
        /* 0x66C8 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 33)]
        /* 0x66E8 */ public NMSString0x20A StoriesPageID;
        [NMS(Index = 25)]
        /* 0x6708 */ public TkTextureResource MainIcon;
        [NMS(Index = 68)]
        /* 0x6720 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 69)]
        /* 0x6738 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 67)]
        /* 0x6750 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 108)]
        /* 0x6768 */ public List<NMSString0x10> AdditionalKnownProducts;
        [NMS(Index = 109)]
        /* 0x6778 */ public List<NMSString0x10> AdditionalKnownTech;
        [NMS(Index = 36)]
        /* 0x6788 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 138)]
        /* 0x6798 */ public GcSeed BlockAllBaseAndEndpointSharingUntilMilestoneWithSeedComplete;
        [NMS(Index = 143)]
        /* 0x67A8 */ public GcSeed BlockShipPurchasesUntilMilestoneWithSeedComplete;
        [NMS(Index = 136)]
        /* 0x67B8 */ public GcSeed BlockShipRepairUntilMilestoneWithSeedComplete;
        [NMS(Index = 137)]
        /* 0x67C8 */ public GcSeed BlockThirdPersonUntilMilestoneWithSeedComplete;
        [NMS(Index = 156)]
        /* 0x67D8 */ public List<GcCommunityTeamData> CommunityTeamData;
        [NMS(Index = 17)]
        /* 0x67E8 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 139)]
        /* 0x67F8 */ public GcSeed DisableNPCMovementUntilMilestoneWithSeedComplete;
        [NMS(Index = 163)]
        /* 0x6808 */ public List<GcAtlasDiscovery> discoveries;
        [NMS(Index = 21)]
        /* 0x6818 */ public NMSString0x10 FinalReward;
        [NMS(Index = 22)]
        /* 0x6828 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 38)]
        /* 0x6838 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 106)]
        /* 0x6848 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 107)]
        /* 0x6858 */ public List<NMSString0x10> ForgottenTech;
        [NMS(Index = 52)]
        /* 0x6868 */ public GcFilename FreighterBaseOverrideFilename;
        [NMS(Index = 64)]
        /* 0x6878 */ public List<GcSeasonalIntroQuestion> IntroQuestions;
        [NMS(Index = 60)]
        /* 0x6888 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 105)]
        /* 0x6898 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 37)]
        /* 0x68A8 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x68B8 */ public GcFilename OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x68C8 */ public GcFilename OverrideMTFilename;
        [NMS(Index = 61)]
        /* 0x68D8 */ public NMSString0x10 PersistentPOI;
        [NMS(Index = 123)]
        /* 0x68E8 */ public List<GcProductData> ProductTable;
        [NMS(Index = 78)]
        /* 0x68F8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 81)]
        /* 0x6908 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 117)]
        /* 0x6918 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 46)]
        /* 0x6928 */ public GcSeed ShipSeed;
        [NMS(Index = 116)]
        /* 0x6938 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 100)]
        /* 0x6948 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 63)]
        /* 0x6958 */ public NMSString0x10 StartWithIntroQuizID;
        [NMS(Index = 119)]
        /* 0x6968 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 124)]
        /* 0x6978 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 162)]
        /* 0x6988 */ public NMSString0x10 SwarmMonumentShowWhenMissionComplete;
        [NMS(Index = 18)]
        /* 0x6998 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 122)]
        /* 0x69A8 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 65)]
        /* 0x69B8 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 45)]
        /* 0x69C8 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x69D8 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x69E0 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x69E8 */ public ulong StartTimeUTC;
        [NMS(Index = 20)]
        /* 0x69F0 */ public ulong UAOverrideValue;
        [NMS(Index = 16)]
        /* 0x69F8 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 94)]
        /* 0x6A58 */ public Vector2f CustomFrigateFlybyTimer;
        [NMS(Index = 95)]
        /* 0x6A60 */ public Vector2f CustomPiratePlanetFlybyTimer;
        [NMS(Index = 111)]
        /* 0x6A68 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 88)]
        /* 0x6A6C */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 15)]
        /* 0x6A70 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 28)]
        /* 0x6A74 */ public int DisplayNumber;
        [NMS(Index = 87)]
        /* 0x6A78 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 114)]
        /* 0x6A7C */ public float EnergyDrainMultiplier;
        [NMS(Index = 112)]
        /* 0x6A80 */ public float FarmPlantsTimerMul;
        [NMS(Index = 141)]
        /* 0x6A84 */ public GcAlienRace ForcePlayerRace;
        [NMS(Index = 102)]
        /* 0x6A88 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x6A8C */ public GcAlienRace FreighterRace;
        [NMS(Index = 14)]
        /* 0x6A90 */ public GcGameMode GameMode;
        [NMS(Index = 113)]
        /* 0x6A94 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 115)]
        /* 0x6A98 */ public int QuestSubstanceReducer;
        [NMS(Index = 27)]
        /* 0x6A9C */ public int RemixNumber;
        [NMS(Index = 84)]
        /* 0x6AA0 */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 83)]
        /* 0x6AA4 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x6AA8 */ public int SeasonId;
        [NMS(Index = 26)]
        /* 0x6AAC */ public int SeasonNumber;
        [NMS(Index = 11)]
        /* 0x6AB0 */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x6AB4 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 80)]
        /* 0x6AB8 */ public int StartingPetSlots;
        [NMS(Index = 44)]
        /* 0x6ABC */ public int StartingSuitCargoSlots;
        [NMS(Index = 42)]
        /* 0x6AC0 */ public int StartingSuitSlots;
        [NMS(Index = 43)]
        /* 0x6AC4 */ public int StartingSuitTechSlots;
        [NMS(Index = 133)]
        /* 0x6AC8 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 104)]
        /* 0x6ACC */ public int TechCostMultiplier;
        [NMS(Index = 129)]
        /* 0x6AD0 */ public float UseLegacyStationsRadius;
        [NMS(Index = 24)]
        /* 0x6AD4 */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 66)]
        /* 0x6CD4 */ public NMSString0x80 UseSpawnBuildingNearUDA;
        [NMS(Index = 6)]
        /* 0x6D54 */ public NMSString0x20 Description;
        [NMS(Index = 19)]
        /* 0x6D74 */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x6D94 */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x6DB4 */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x6DD4 */ public NMSString0x20 Title;
        [NMS(Index = 97)]
        /* 0x6DF4 */ public bool AllowMissionDetailMessages;
        [NMS(Index = 145)]
        /* 0x6DF5 */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 148)]
        /* 0x6DF6 */ public bool AllowSaveContextCorvetteTransfer;
        [NMS(Index = 146)]
        /* 0x6DF7 */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 147)]
        /* 0x6DF8 */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 91)]
        /* 0x6DF9 */ public bool AlwaysStormy;
        [NMS(Index = 127)]
        /* 0x6DFA */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 92)]
        /* 0x6DFB */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 140)]
        /* 0x6DFC */ public bool BlockAllBaseAndEndpointSharing;
        [NMS(Index = 93)]
        /* 0x6DFD */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 13)]
        /* 0x6DFE */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 90)]
        /* 0x6DFF */ public bool BlockStormsAtStart;
        [NMS(Index = 159)]
        /* 0x6E00 */ public GcCommunityTeam CachedPlayerCommunityTeam;
        [NMS(Index = 62)]
        /* 0x6E01 */ public bool CarnageMode;
        [NMS(Index = 120)]
        /* 0x6E02 */ public bool CompatibleWithState;
        [NMS(Index = 34)]
        /* 0x6E03 */ public bool DefaultToPvPOff;
        [NMS(Index = 149)]
        /* 0x6E04 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x6E05 */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x6E06 */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 103)]
        /* 0x6E07 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 99)]
        /* 0x6E08 */ public bool ForceStartPlanetToHaveScrap;
        [NMS(Index = 57)]
        /* 0x6E09 */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x6E0A */ public bool ForceStartSystemTernary;
        [NMS(Index = 121)]
        /* 0x6E0B */ public bool HasBeenConverted;
        [NMS(Index = 110)]
        /* 0x6E0C */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 35)]
        /* 0x6E0D */ public bool MustCraftInBases;
        [NMS(Index = 144)]
        /* 0x6E0E */ public bool NeverAllowCorvettePurchases;
        [NMS(Index = 142)]
        /* 0x6E0F */ public bool NeverAllowShipPurchases;
        [NMS(Index = 135)]
        /* 0x6E10 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 134)]
        /* 0x6E11 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 132)]
        /* 0x6E12 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 12)]
        /* 0x6E13 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 131)]
        /* 0x6E14 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 118)]
        /* 0x6E15 */ public bool ResetSaveOnDeath;
        [NMS(Index = 82)]
        /* 0x6E16 */ public bool SandwormGlobalOverride;
        [NMS(Index = 86)]
        /* 0x6E17 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 89)]
        /* 0x6E18 */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x6E19 */ public bool StartAboardFreighter;
        [NMS(Index = 39)]
        /* 0x6E1A */ public bool StartAsOrb;
        [NMS(Index = 85)]
        /* 0x6E1B */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x6E1C */ public bool StartWithFreighter;
        [NMS(Index = 160)]
        /* 0x6E1D */ public bool SwarmMissionsActive;
        [NMS(Index = 161)]
        /* 0x6E1E */ public bool SwarmMonumentActive;
        [NMS(Index = 101)]
        /* 0x6E1F */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 154)]
        /* 0x6E20 */ public bool UseCommunityTeamPalettes;
        [NMS(Index = 70)]
        /* 0x6E21 */ public bool UseDefaultAppearance;
        [NMS(Index = 128)]
        /* 0x6E22 */ public bool UseLegacyStationsNearStartUA;
        [NMS(Index = 77)]
        /* 0x6E23 */ public bool UseRandomPet;
        [NMS(Index = 126)]
        /* 0x6E24 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 130)]
        /* 0x6E25 */ public bool UseSpookHazardOnly;
        [NMS(Index = 98)]
        /* 0x6E26 */ public bool UseStartPlanetObjectListOverrides;
        [NMS(Index = 155)]
        /* 0x6E27 */ public bool UseTeamShipPalettes;
        [NMS(Index = 47)]
        /* 0x6E28 */ public bool UseTeamShipSeeds;
    }
}

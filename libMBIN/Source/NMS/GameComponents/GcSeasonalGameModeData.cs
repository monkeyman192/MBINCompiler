using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47D7159E76D9E4B3, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 79, Size = 0x1E)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 71)]
        /* 0x5910 */ public GcInventoryContainer Inventory;
        [NMS(Index = 73)]
        /* 0x5A70 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 72)]
        /* 0x5BD0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 74)]
        /* 0x5D30 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 75)]
        /* 0x5E90 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 125)]
        /* 0x5FF0 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 40)]
        /* 0x60D8 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 41)]
        /* 0x6170 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 96, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x6208 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 76)]
        /* 0x6238 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 48, Size = 0x3, EnumType = typeof(GcCommunityTeam.CommunityTeamEnum))]
        /* 0x6268 */ public GcSeed[] TeamShipSeeds;
        [NMS(Index = 158)]
        /* 0x6298 */ public NMSString0x20A CommunityCompleteMessageSubtitleOverride;
        [NMS(Index = 157)]
        /* 0x62B8 */ public NMSString0x20A CommunityCompleteMessageTitleOverride;
        [NMS(Index = 150)]
        /* 0x62D8 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 153)]
        /* 0x62F8 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 151)]
        /* 0x6318 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 152)]
        /* 0x6338 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 23)]
        /* 0x6358 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x6378 */ public NMSString0x20A FinalMilestoneFormat;
        [NMS(Index = 9)]
        /* 0x6398 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 32)]
        /* 0x63B8 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 31)]
        /* 0x63D8 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 10)]
        /* 0x63F8 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 29)]
        /* 0x6418 */ public NMSString0x20A SeasonName;
        [NMS(Index = 30)]
        /* 0x6438 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 33)]
        /* 0x6458 */ public NMSString0x20A StoriesPageID;
        [NMS(Index = 25)]
        /* 0x6478 */ public TkTextureResource MainIcon;
        [NMS(Index = 68)]
        /* 0x6490 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 69)]
        /* 0x64A8 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 67)]
        /* 0x64C0 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 108)]
        /* 0x64D8 */ public List<NMSString0x10> AdditionalKnownProducts;
        [NMS(Index = 109)]
        /* 0x64E8 */ public List<NMSString0x10> AdditionalKnownTech;
        [NMS(Index = 36)]
        /* 0x64F8 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 138)]
        /* 0x6508 */ public GcSeed BlockAllBaseAndEndpointSharingUntilMilestoneWithSeedComplete;
        [NMS(Index = 143)]
        /* 0x6518 */ public GcSeed BlockShipPurchasesUntilMilestoneWithSeedComplete;
        [NMS(Index = 136)]
        /* 0x6528 */ public GcSeed BlockShipRepairUntilMilestoneWithSeedComplete;
        [NMS(Index = 137)]
        /* 0x6538 */ public GcSeed BlockThirdPersonUntilMilestoneWithSeedComplete;
        [NMS(Index = 156)]
        /* 0x6548 */ public List<GcCommunityTeamData> CommunityTeamData;
        [NMS(Index = 17)]
        /* 0x6558 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 139)]
        /* 0x6568 */ public GcSeed DisableNPCMovementUntilMilestoneWithSeedComplete;
        [NMS(Index = 163)]
        /* 0x6578 */ public List<GcAtlasDiscovery> discoveries;
        [NMS(Index = 21)]
        /* 0x6588 */ public NMSString0x10 FinalReward;
        [NMS(Index = 22)]
        /* 0x6598 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 38)]
        /* 0x65A8 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 106)]
        /* 0x65B8 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 107)]
        /* 0x65C8 */ public List<NMSString0x10> ForgottenTech;
        [NMS(Index = 52)]
        /* 0x65D8 */ public GcFilename FreighterBaseOverrideFilename;
        [NMS(Index = 64)]
        /* 0x65E8 */ public List<GcSeasonalIntroQuestion> IntroQuestions;
        [NMS(Index = 60)]
        /* 0x65F8 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 105)]
        /* 0x6608 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 37)]
        /* 0x6618 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x6628 */ public GcFilename OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x6638 */ public GcFilename OverrideMTFilename;
        [NMS(Index = 61)]
        /* 0x6648 */ public NMSString0x10 PersistentPOI;
        [NMS(Index = 123)]
        /* 0x6658 */ public List<GcProductData> ProductTable;
        [NMS(Index = 78)]
        /* 0x6668 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 81)]
        /* 0x6678 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 117)]
        /* 0x6688 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 46)]
        /* 0x6698 */ public GcSeed ShipSeed;
        [NMS(Index = 116)]
        /* 0x66A8 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 100)]
        /* 0x66B8 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 63)]
        /* 0x66C8 */ public NMSString0x10 StartWithIntroQuizID;
        [NMS(Index = 119)]
        /* 0x66D8 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 124)]
        /* 0x66E8 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 162)]
        /* 0x66F8 */ public NMSString0x10 SwarmMonumentShowWhenMissionComplete;
        [NMS(Index = 18)]
        /* 0x6708 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 122)]
        /* 0x6718 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 65)]
        /* 0x6728 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 45)]
        /* 0x6738 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x6748 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x6750 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x6758 */ public ulong StartTimeUTC;
        [NMS(Index = 20)]
        /* 0x6760 */ public ulong UAOverrideValue;
        [NMS(Index = 16)]
        /* 0x6768 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 94)]
        /* 0x67C8 */ public Vector2f CustomFrigateFlybyTimer;
        [NMS(Index = 95)]
        /* 0x67D0 */ public Vector2f CustomPiratePlanetFlybyTimer;
        [NMS(Index = 111)]
        /* 0x67D8 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 88)]
        /* 0x67DC */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 15)]
        /* 0x67E0 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 28)]
        /* 0x67E4 */ public int DisplayNumber;
        [NMS(Index = 87)]
        /* 0x67E8 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 114)]
        /* 0x67EC */ public float EnergyDrainMultiplier;
        [NMS(Index = 112)]
        /* 0x67F0 */ public float FarmPlantsTimerMul;
        [NMS(Index = 141)]
        /* 0x67F4 */ public GcAlienRace ForcePlayerRace;
        [NMS(Index = 102)]
        /* 0x67F8 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x67FC */ public GcAlienRace FreighterRace;
        [NMS(Index = 14)]
        /* 0x6800 */ public GcGameMode GameMode;
        [NMS(Index = 113)]
        /* 0x6804 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 115)]
        /* 0x6808 */ public int QuestSubstanceReducer;
        [NMS(Index = 27)]
        /* 0x680C */ public int RemixNumber;
        [NMS(Index = 84)]
        /* 0x6810 */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 83)]
        /* 0x6814 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x6818 */ public int SeasonId;
        [NMS(Index = 26)]
        /* 0x681C */ public int SeasonNumber;
        [NMS(Index = 11)]
        /* 0x6820 */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x6824 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 80)]
        /* 0x6828 */ public int StartingPetSlots;
        [NMS(Index = 44)]
        /* 0x682C */ public int StartingSuitCargoSlots;
        [NMS(Index = 42)]
        /* 0x6830 */ public int StartingSuitSlots;
        [NMS(Index = 43)]
        /* 0x6834 */ public int StartingSuitTechSlots;
        [NMS(Index = 133)]
        /* 0x6838 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 104)]
        /* 0x683C */ public int TechCostMultiplier;
        [NMS(Index = 129)]
        /* 0x6840 */ public float UseLegacyStationsRadius;
        [NMS(Index = 24)]
        /* 0x6844 */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 66)]
        /* 0x6A44 */ public NMSString0x80 UseSpawnBuildingNearUDA;
        [NMS(Index = 6)]
        /* 0x6AC4 */ public NMSString0x20 Description;
        [NMS(Index = 19)]
        /* 0x6AE4 */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x6B04 */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x6B24 */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x6B44 */ public NMSString0x20 Title;
        [NMS(Index = 97)]
        /* 0x6B64 */ public bool AllowMissionDetailMessages;
        [NMS(Index = 145)]
        /* 0x6B65 */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 148)]
        /* 0x6B66 */ public bool AllowSaveContextCorvetteTransfer;
        [NMS(Index = 146)]
        /* 0x6B67 */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 147)]
        /* 0x6B68 */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 91)]
        /* 0x6B69 */ public bool AlwaysStormy;
        [NMS(Index = 127)]
        /* 0x6B6A */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 92)]
        /* 0x6B6B */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 140)]
        /* 0x6B6C */ public bool BlockAllBaseAndEndpointSharing;
        [NMS(Index = 93)]
        /* 0x6B6D */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 13)]
        /* 0x6B6E */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 90)]
        /* 0x6B6F */ public bool BlockStormsAtStart;
        [NMS(Index = 159)]
        /* 0x6B70 */ public GcCommunityTeam CachedPlayerCommunityTeam;
        [NMS(Index = 62)]
        /* 0x6B71 */ public bool CarnageMode;
        [NMS(Index = 120)]
        /* 0x6B72 */ public bool CompatibleWithState;
        [NMS(Index = 34)]
        /* 0x6B73 */ public bool DefaultToPvPOff;
        [NMS(Index = 149)]
        /* 0x6B74 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x6B75 */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x6B76 */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 103)]
        /* 0x6B77 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 99)]
        /* 0x6B78 */ public bool ForceStartPlanetToHaveScrap;
        [NMS(Index = 57)]
        /* 0x6B79 */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x6B7A */ public bool ForceStartSystemTernary;
        [NMS(Index = 121)]
        /* 0x6B7B */ public bool HasBeenConverted;
        [NMS(Index = 110)]
        /* 0x6B7C */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 35)]
        /* 0x6B7D */ public bool MustCraftInBases;
        [NMS(Index = 144)]
        /* 0x6B7E */ public bool NeverAllowCorvettePurchases;
        [NMS(Index = 142)]
        /* 0x6B7F */ public bool NeverAllowShipPurchases;
        [NMS(Index = 135)]
        /* 0x6B80 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 134)]
        /* 0x6B81 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 132)]
        /* 0x6B82 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 12)]
        /* 0x6B83 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 131)]
        /* 0x6B84 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 118)]
        /* 0x6B85 */ public bool ResetSaveOnDeath;
        [NMS(Index = 82)]
        /* 0x6B86 */ public bool SandwormGlobalOverride;
        [NMS(Index = 86)]
        /* 0x6B87 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 89)]
        /* 0x6B88 */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x6B89 */ public bool StartAboardFreighter;
        [NMS(Index = 39)]
        /* 0x6B8A */ public bool StartAsOrb;
        [NMS(Index = 85)]
        /* 0x6B8B */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x6B8C */ public bool StartWithFreighter;
        [NMS(Index = 160)]
        /* 0x6B8D */ public bool SwarmMissionsActive;
        [NMS(Index = 161)]
        /* 0x6B8E */ public bool SwarmMonumentActive;
        [NMS(Index = 101)]
        /* 0x6B8F */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 154)]
        /* 0x6B90 */ public bool UseCommunityTeamPalettes;
        [NMS(Index = 70)]
        /* 0x6B91 */ public bool UseDefaultAppearance;
        [NMS(Index = 128)]
        /* 0x6B92 */ public bool UseLegacyStationsNearStartUA;
        [NMS(Index = 77)]
        /* 0x6B93 */ public bool UseRandomPet;
        [NMS(Index = 126)]
        /* 0x6B94 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 130)]
        /* 0x6B95 */ public bool UseSpookHazardOnly;
        [NMS(Index = 98)]
        /* 0x6B96 */ public bool UseStartPlanetObjectListOverrides;
        [NMS(Index = 155)]
        /* 0x6B97 */ public bool UseTeamShipPalettes;
        [NMS(Index = 47)]
        /* 0x6B98 */ public bool UseTeamShipSeeds;
    }
}

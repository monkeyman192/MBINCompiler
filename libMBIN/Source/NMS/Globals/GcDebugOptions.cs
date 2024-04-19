using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x98EC4F11626B56E1, NameHash = 0x13FED27DF728C38)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        /* 0x0030 */ public NMSString0x10 CreateSeasonContextMaskIdOverride;
        /* 0x0040 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x0050 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x0060 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x0070 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x0080 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        /* 0x0090 */ public List<NMSString0x20> LocTableList;
        /* 0x00A0 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        /* 0x00B0 */ public ulong ForceTimeToEpoch;
        /* 0x00B8 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x00C0 */ public TkGlobals ToolkitGlobals;
        /* 0x0350 */ public float _3dTextDistance;
        /* 0x0354 */ public float _3dTextMinScale;
        /* 0x0358 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x035C */ public float BaseDownloadTimeout;
        /* 0x0360 */ public uint BasePayloadMultiplier;
        /* 0x0364 */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        /* 0x0368 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x036C */ public float BootLogoFadeRate;
        // size: 0x7
        public enum BootModeEnum : uint {
            MinimalSolarSystem,
            SolarSystem,
            GalaxyMap,
            SmokeTest,
            SmokeTestGalaxyMap,
            Scratchpad,
            UnitTest,
        }
        /* 0x0370 */ public BootModeEnum BootMode;
        /* 0x0374 */ public TkLanguages DebugLanguage;
        /* 0x0378 */ public int DebugTextureSize;
        /* 0x037C */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x0380 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x0384 */ public int ForceAsteroidSystemIndex;
        /* 0x0388 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x038C */ public GcBiomeType ForceBiomeTo;
        /* 0x0390 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x0394 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x0398 */ public int ForceGrassColourIndex;
        /* 0x039C */ public float ForceInitialTimeOfDay;
        /* 0x03A0 */ public int ForceInteractionIndex;
        /* 0x03A4 */ public GcAlienRace ForceInteractionRaceTo;
        /* 0x03A8 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x03AC */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        /* 0x03B0 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x03B4 */ public int ForceSkyColourIndex;
        /* 0x03B8 */ public int ForceSpaceBattleLevel;
        /* 0x03BC */ public int ForceSpaceSkyColourIndex;
        /* 0x03C0 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x03C4 */ public float ForceSunAngle;
        /* 0x03C8 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x03CC */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x03D0 */ public float ForceTimeOfDay;
        /* 0x03D4 */ public int ForceWaterColourIndex;
        /* 0x03D8 */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        /* 0x03DC */ public GameStateModeEnum GameStateMode;
        /* 0x03E0 */ public float GenerateCostAngle;
        /* 0x03E4 */ public float GenerateCostDistance;
        /* 0x03E8 */ public float GenerateCostLOD;
        /* 0x03EC */ public float GenerateCostWait;
        /* 0x03F0 */ public int GenerateFarLodBuildingDist;
        /* 0x03F4 */ public int MaxNumDebugMessages;
        /* 0x03F8 */ public int MoveBaseIndex;
        /* 0x03FC */ public int MultipleFingersSamePressFrameDelta;
        /* 0x0400 */ public GcGameMode NewSaveGameMode;
        /* 0x0404 */ public int OctahedralImpostersViewCount;
        /* 0x0408 */ public int OverrideMatchmakingVersion;
        /* 0x040C */ public int OverrideServerSeasonEndTime;
        /* 0x0410 */ public int OverrideServerSeasonNumber;
        /* 0x0414 */ public float PanDeadzone;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum : uint {
            None,
            FromSettings,
            Space,
            SpaceStation,
            RandomPlanet,
            GameStartPlanet,
            SpecificLocation,
        }
        /* 0x0418 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x041C */ public int ProceduralModelBatchSize;
        /* 0x0420 */ public int ProceduralModelFilterMatchretryCount;
        /* 0x0424 */ public int ProceduralModelsShown;
        /* 0x0428 */ public int ProceduralModelsThumbnailSize;
        /* 0x042C */ public int ProfilerPartIndexPhase;
        /* 0x0430 */ public int ProfilerPartIndexStride;
        /* 0x0434 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        /* 0x0438 */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        /* 0x043C */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        /* 0x0440 */ public RecordSettingEnum RecordSetting;
        /* 0x0444 */ public int RecurrenceTimeOffset;
        /* 0x0448 */ public int ScreenshotForUploadHeight;
        /* 0x044C */ public int ScreenshotForUploadWidth;
        // size: 0x8
        public enum ServerEnvEnum : uint {
            Default,
            dev,
            qa,
            prodqa,
            prod,
            custom,
            pentest,
            merged,
        }
        /* 0x0450 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        /* 0x0454 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0458 */ public int ShowSpecificGraph;
        /* 0x045C */ public int SmokeTestConfigCaptureCycles;
        /* 0x0460 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0464 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0468 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x046C */ public float SmokeTestConfigScenarioLength;
        /* 0x0470 */ public float SmokeTestConfigScenarioPreambleLength;
        // size: 0x7
        public enum SmokeTestCycleModeEnum : uint {
            None,
            TourPlanet,
            TourSolarSystem,
            TourGalaxy,
            TourUDAs,
            TourShortUDAs,
            TourRandomWarps,
        }
        /* 0x0474 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0x8
        public enum SmokeTestScenarioEnum : uint {
            None,
            TerrainSnapShotFromAltitude,
            BelowCloudLayerSnapShot,
            Flying,
            UltraBiomeSnapShot,
            Walking,
            LeakDetector,
            WalkingSnapshot,
        }
        /* 0x0478 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x047C */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        /* 0x0480 */ public SolarSystemBootEnum SolarSystemBoot;
        /* 0x0484 */ public int SwipeDetectionMaxFrames;
        /* 0x0488 */ public float SwipeDetectionNormalizedTravelThreshold;
        /* 0x048C */ public int SynergyPort;
        /* 0x0490 */ public float WeaponScale3P;
        /* 0x0494 */ public ushort RealityGenerationIteration;
        /* 0x0496 */ public NMSString0x800 AutoJoinUserNames;
        /* 0x0C96 */ public NMSString0x400 DebugTwitchRewards;
        /* 0x1096 */ public NMSString0x200 LoadToBase;
        /* 0x1296 */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x1496 */ public NMSString0x100 ForcePlayerPosition;
        /* 0x1596 */ public NMSString0x100 ForceUniverseAddress;
        /* 0x1696 */ public NMSString0x100 GOGLogin;
        /* 0x1796 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x1896 */ public NMSString0x100 WorkingDirectory;
        /* 0x1996 */ public NMSString0x80 AuthBaseUrl;
        /* 0x1A16 */ public NMSString0x80 CrashDumpPath;
        /* 0x1A96 */ public NMSString0x80 CursorTexture;
        /* 0x1B16 */ public NMSString0x80 DebugFont;
        /* 0x1B96 */ public NMSString0x80 DebugFontTexture;
        /* 0x1C16 */ public NMSString0x80 DebugScene;
        /* 0x1C96 */ public NMSString0x80 DefaultSaveData;
        /* 0x1D16 */ public NMSString0x80 PauseTexture;
        /* 0x1D96 */ public NMSString0x80 PipelineFile;
        /* 0x1E16 */ public NMSString0x80 PipelineFileApple;
        /* 0x1E96 */ public NMSString0x80 PipelineFileEditor;
        /* 0x1F16 */ public NMSString0x80 PipelineFileFrontend;
        /* 0x1F96 */ public NMSString0x80 PipelineFilePS4;
        /* 0x2016 */ public NMSString0x80 PipelineFileSwitch;
        /* 0x2096 */ public NMSString0x80 PipelineFileSwitchFSR2;
        /* 0x2116 */ public NMSString0x80 PipelineFileVR;
        /* 0x2196 */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x2216 */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x2296 */ public NMSString0x80 PlayTexture;
        /* 0x2316 */ public NMSString0x80 ProxyURI;
        /* 0x2396 */ public NMSString0x80 RealityPresetFile;
        /* 0x2416 */ public NMSString0x80 RenderToTexture;
        /* 0x2496 */ public NMSString0x80 SceneSettings;
        /* 0x2516 */ public NMSString0x80 StepTexture;
        /* 0x2596 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x25D6 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x2616 */ public NMSString0x40 ScreenshotForUploadName;
        /* 0x2656 */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x2676 */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x2696 */ public NMSString0x20 BaseServerPlatform;
        /* 0x26B6 */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x26D6 */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x26F6 */ public NMSString0x20 SaveTestingCommand;
        /* 0x2716 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x2736 */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x2756 */ public NMSString0x20 SynergyServer;
        /* 0x2776 */ public bool AllowGalaxyMapRequests;
        /* 0x2777 */ public bool AllowGlobalPartSnapping;
        /* 0x2778 */ public bool AllowNGuiVR;
        /* 0x2779 */ public bool AllowOverrideSettlementOwnership;
        /* 0x277A */ public bool AllowPause;
        /* 0x277B */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x277C */ public bool AllSeasonMilestonesShowComplete;
        /* 0x277D */ public bool AllSettlementsAreCompleted;
        /* 0x277E */ public bool AlternateControls;
        /* 0x277F */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x2780 */ public bool AlwaysAllowShipOperations;
        /* 0x2781 */ public bool AlwaysAllowVehicleOperations;
        /* 0x2782 */ public bool AlwaysHaveFocus;
        /* 0x2783 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x2784 */ public bool AlwaysSaveGameAsClient;
        /* 0x2785 */ public bool AlwaysShowURI;
        /* 0x2786 */ public bool AlwaysSpaceBattle;
        /* 0x2787 */ public bool AutoJoinRandomGames;
        /* 0x2788 */ public bool AutoJoinUserEnabled;
        /* 0x2789 */ public bool AutomaticPartSpawnInactive;
        /* 0x278A */ public bool BaseAdmin;
        /* 0x278B */ public bool BlockCommunicatorSignals;
        /* 0x278C */ public bool BlockSettlementsNetwork;
        /* 0x278D */ public bool BodyTurning;
        /* 0x278E */ public bool BootDirectlyIntoLastSave;
        /* 0x278F */ public bool BootMusic;
        /* 0x2790 */ public bool CanLeaveDialogs;
        /* 0x2791 */ public bool CertificateSecurityBypass;
        /* 0x2792 */ public bool ClothForceAsyncSimulationOff;
        /* 0x2793 */ public bool ClothForceAsyncSimulationOn;
        /* 0x2794 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        /* 0x2795 */ public bool ClothForcePositionExtrapolationBackOn;
        /* 0x2796 */ public bool ClothForcePositionExtrapolationOff;
        /* 0x2797 */ public bool ClothForcePositionExtrapolationOn;
        /* 0x2798 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        /* 0x2799 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        /* 0x279A */ public bool CompressTextures;
        /* 0x279B */ public bool CreatureChatter;
        /* 0x279C */ public bool CreatureDrawVocals;
        /* 0x279D */ public bool CreatureErrors;
        /* 0x279E */ public bool CrossPlatformFeaturedBases;
        /* 0x279F */ public bool DChecksEnabled;
        /* 0x27A0 */ public bool DChecksOutputBinary;
        /* 0x27A1 */ public bool DChecksOutputFileLine;
        /* 0x27A2 */ public bool DChecksOutputJson;
        /* 0x27A3 */ public bool DebugBuildingSpawns;
        /* 0x27A4 */ public bool DebugDrawPlayerInteract;
        /* 0x27A5 */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x27A6 */ public bool DebugIBL;
        /* 0x27A7 */ public bool DebugPersistentInteractions;
        /* 0x27A8 */ public bool DebugSpotlights;
        /* 0x27A9 */ public bool DebugTerrainTextures;
        /* 0x27AA */ public bool DebugThreatLevels;
        /* 0x27AB */ public bool DeferRegionBodies;
        /* 0x27AC */ public bool DisableAbandonedFreighterRoomsOptimisation;
        /* 0x27AD */ public bool DisableBaseBuilding;
        /* 0x27AE */ public bool DisableBaseBuildingLimits;
        /* 0x27AF */ public bool DisableBasePowerRequirements;
        /* 0x27B0 */ public bool DisableContinuousSaving;
        /* 0x27B1 */ public bool DisableDebugControls;
        /* 0x27B2 */ public bool DisableDiscoveryNaming;
        /* 0x27B3 */ public bool DisableFileWatcher;
        /* 0x27B4 */ public bool DisableHazards;
        /* 0x27B5 */ public bool DisableHeadConstraints;
        /* 0x27B6 */ public bool DisableInvalidSaveVersion;
        /* 0x27B7 */ public bool DisableLeftHand;
        /* 0x27B8 */ public bool DisableLimits;
        /* 0x27B9 */ public bool DisableMissionShop;
        /* 0x27BA */ public bool DisableMonumentDownloads;
        /* 0x27BB */ public bool DisableNPCHiddenUntilScanned;
        /* 0x27BC */ public bool DisableNPCs;
        /* 0x27BD */ public bool DisableOldMissions;
        /* 0x27BE */ public bool DisablePartialStories;
        /* 0x27BF */ public bool DisableProfanityFilter;
        /* 0x27C0 */ public bool DisableSaveSlotSorting;
        /* 0x27C1 */ public bool DisableSaving;
        /* 0x27C2 */ public bool DisableSettlements;
        /* 0x27C3 */ public bool DisableShaderReload;
        /* 0x27C4 */ public bool DisableShadowSwitching;
        /* 0x27C5 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x27C6 */ public bool DisableStorms;
        /* 0x27C7 */ public bool DisableVibration;
        /* 0x27C8 */ public bool DoAlienLanguage;
        /* 0x27C9 */ public bool DrawCreaturesInRoutines;
        /* 0x27CA */ public bool DumpManifestContents;
        /* 0x27CB */ public bool EnableAccessibleUI;
        /* 0x27CC */ public bool EnableBaseBuildingExpandables;
        /* 0x27CD */ public bool EnableBaseMovingOption;
        /* 0x27CE */ public bool EnableCloudAnimation;
        /* 0x27CF */ public bool EnableComputePost;
        /* 0x27D0 */ public bool EnableDayNightCycle;
        /* 0x27D1 */ public bool EnableEvenOddRender;
        /* 0x27D2 */ public bool EnableFrontendPreload;
        /* 0x27D3 */ public bool EnableGalaxyRecolouring;
        /* 0x27D4 */ public bool EnableMemoryPoolAllocPrint;
        /* 0x27D5 */ public bool EnablePhotomodeVR;
        /* 0x27D6 */ public bool EnableSynergy;
        /* 0x27D7 */ public bool EverythingIsFree;
        /* 0x27D8 */ public bool EverythingIsKnown;
        /* 0x27D9 */ public bool EverythingIsStar;
        /* 0x27DA */ public bool FakeHandsInMultiplayer;
        /* 0x27DB */ public bool FastAndFrequentFleetInterventions;
        /* 0x27DC */ public bool FastLoad;
        /* 0x27DD */ public bool FixedFramerate;
        /* 0x27DE */ public bool FleetDirectorAutoMode;
        /* 0x27DF */ public bool ForceBasicLoadScreen;
        /* 0x27E0 */ public bool ForceBinaryStar;
        /* 0x27E1 */ public bool ForceBiome;
        /* 0x27E2 */ public bool ForceBuildersAlwaysKnown;
        /* 0x27E3 */ public bool ForceBuildingRace;
        /* 0x27E4 */ public bool ForceCorruptSentinels;
        /* 0x27E5 */ public bool ForceCreatureLifeLevel;
        /* 0x27E6 */ public bool ForceDefaultCreatureFile;
        /* 0x27E7 */ public bool ForceDisableClothComponent;
        /* 0x27E8 */ public bool ForceDisableNonPlayerRagdollComponents;
        /* 0x27E9 */ public bool ForceDisableRagdollComponent;
        /* 0x27EA */ public bool ForceDisableSplitIkOptimisation;
        /* 0x27EB */ public bool ForceDisableSpringAttachmentComponent;
        /* 0x27EC */ public bool ForceEnableClothComponent;
        /* 0x27ED */ public bool ForceEnableRagdollComponent;
        /* 0x27EE */ public bool ForceEnableSplitIkOptimisation;
        /* 0x27EF */ public bool ForceEnableSpringAttachmentComponent;
        /* 0x27F0 */ public bool ForceExtremeSentinels;
        /* 0x27F1 */ public bool ForceExtremeWeather;
        /* 0x27F2 */ public bool ForceInitialShip;
        /* 0x27F3 */ public bool ForceInitialWeapon;
        /* 0x27F4 */ public bool ForceInteractionToSettings;
        /* 0x27F5 */ public bool ForceLifeLevel;
        /* 0x27F6 */ public bool ForceLoadAllWeather;
        /* 0x27F7 */ public bool ForceNexusInQuickMenu;
        /* 0x27F8 */ public bool ForcePirateSystem;
        /* 0x27F9 */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x27FA */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x27FB */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x27FC */ public bool ForcePlanetsToHaveNoWater;
        /* 0x27FD */ public bool ForcePlanetsToHaveWater;
        /* 0x27FE */ public bool ForcePrimeTerrain;
        /* 0x27FF */ public bool ForceRareAsteroidSystem;
        /* 0x2800 */ public bool ForceScanEventsToGoPrime;
        /* 0x2801 */ public bool ForceScreenFilter;
        /* 0x2802 */ public bool ForceSmallLobby;
        /* 0x2803 */ public bool ForceSpaceSkyColourRare;
        /* 0x2804 */ public bool ForceStarType;
        /* 0x2805 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x2806 */ public bool ForceTernaryStar;
        /* 0x2807 */ public bool ForceTerrainType;
        /* 0x2808 */ public bool ForceTinyLobby;
        /* 0x2809 */ public bool ForceTranslateAllAlienText;
        /* 0x280A */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x280B */ public bool GodMode;
        /* 0x280C */ public bool GraphCommandBuffer;
        /* 0x280D */ public bool GraphFPS;
        /* 0x280E */ public bool GraphGeneration;
        /* 0x280F */ public bool GraphTexStreaming;
        /* 0x2810 */ public bool HangOnCrash;
        /* 0x2811 */ public bool HmdFrameShiftEnabled;
        /* 0x2812 */ public bool HmdUseSolidGuiPointer;
        /* 0x2813 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x2814 */ public bool IgnoreMissionRank;
        /* 0x2815 */ public bool IgnoreSteamDev;
        /* 0x2816 */ public bool IgnoreTransactionTimeouts;
        /* 0x2817 */ public bool InfiniteInteractions;
        /* 0x2818 */ public bool InfiniteStamina;
        /* 0x2819 */ public bool InstanceCollision;
        /* 0x281A */ public bool InteractionsAllwaysGivesTech;
        /* 0x281B */ public bool LimitGlobalBodies;
        /* 0x281C */ public bool LimitGlobalInstances;
        /* 0x281D */ public bool LimitPerRegionBodies;
        /* 0x281E */ public bool LimitPerRegionInstances;
        /* 0x281F */ public bool LoadMissions;
        /* 0x2820 */ public bool LoadShaderSourceIfRenderdocEnabled;
        /* 0x2821 */ public bool LockAllTitles;
        /* 0x2822 */ public bool LogMissingLocalisedText;
        /* 0x2823 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x2824 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x2825 */ public bool MaximumFreighterSpawns;
        /* 0x2826 */ public bool MemCsv;
        /* 0x2827 */ public bool MissionMessageLoggingEnabled;
        /* 0x2828 */ public bool MissionNGUIShowsConditionResults;
        /* 0x2829 */ public bool MissionSurveyEnabled;
        /* 0x282A */ public bool ModifyPlanetsInInitialSystems;
        /* 0x282B */ public bool MouseLookEnabled;
        /* 0x282C */ public bool MPMissions;
        /* 0x282D */ public bool MPMissionsAlwaysEPIC;
        /* 0x282E */ public bool MultiplePlayerFreightersInASystem;
        /* 0x282F */ public bool NeverUseBanks;
        /* 0x2830 */ public bool OctahedralImpostersDisable;
        /* 0x2831 */ public bool OctahedralImpostersEnable;
        /* 0x2832 */ public bool OctahedralImpostersViewFromSpace;
        /* 0x2833 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x2834 */ public bool PreloadToolbox;
        /* 0x2835 */ public bool PrintAvgFrameTimes;
        /* 0x2836 */ public bool ProceduralModelsDeterministicSequence;
        /* 0x2837 */ public bool Proto2DevKit;
        /* 0x2838 */ public bool RecordNetworkStatsOnBoot;
        /* 0x2839 */ public bool RenderCreatureDetails;
        /* 0x283A */ public bool RenderHud;
        /* 0x283B */ public bool RenderLowFramerate;
        /* 0x283C */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x283D */ public bool ResetToSupportedResolution;
        /* 0x283E */ public bool RevealAllTitles;
        /* 0x283F */ public bool ScreenshotMode;
        /* 0x2840 */ public bool ShaderCaching;
        /* 0x2841 */ public bool ShaderPreloadListExport;
        /* 0x2842 */ public bool ShaderPreloadListImport;
        /* 0x2843 */ public bool ShipSalvageGivesAllParts;
        /* 0x2844 */ public bool ShowDebugMessages;
        /* 0x2845 */ public bool ShowDynamicResScale;
        /* 0x2846 */ public bool ShowEditorPlacementPreview;
        /* 0x2847 */ public bool ShowFireteamMembersUA;
        /* 0x2848 */ public bool ShowFramerate;
        /* 0x2849 */ public bool ShowGPUMemory;
        /* 0x284A */ public bool ShowGPURenderTime;
        /* 0x284B */ public bool ShowGraphs;
        /* 0x284C */ public bool ShowHmdHandControllers;
        /* 0x284D */ public bool ShowLongestStrings;
        /* 0x284E */ public bool ShowMempoolOverlay;
        /* 0x284F */ public bool ShowMissionIdInTitle;
        /* 0x2850 */ public bool ShowMouseSmoothing;
        /* 0x2851 */ public bool ShowPositionDebug;
        /* 0x2852 */ public bool ShowTeleportEffectLocally;
        /* 0x2853 */ public bool SimulateNoNetworkConnection;
        /* 0x2854 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x2855 */ public bool SkipIntro;
        /* 0x2856 */ public bool SkipLogos;
        /* 0x2857 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x2858 */ public bool SkipTutorial;
        /* 0x2859 */ public bool SkipUITimers;
        /* 0x285A */ public bool SmokeTestCameraFly;
        /* 0x285B */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x285C */ public bool SmokeTestDumpStatsMode;
        /* 0x285D */ public bool SmokeTestFastExit;
        /* 0x285E */ public bool SmokeTestLegacyOutput;
        /* 0x285F */ public bool SmokeTestOutputOnly;
        /* 0x2860 */ public bool SmokeTestPostBandwidthStats;
        /* 0x2861 */ public bool SmokeTestPureFlight;
        /* 0x2862 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x2863 */ public bool SpawnPirates;
        /* 0x2864 */ public bool SpawnPulseEncounters;
        /* 0x2865 */ public bool SpawnRobots;
        /* 0x2866 */ public bool SpawnShips;
        /* 0x2867 */ public bool SpecialsShop;
        /* 0x2868 */ public bool StartPaused;
        /* 0x2869 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x286A */ public bool StressTestLongNameDisplay;
        /* 0x286B */ public bool SuperKillGuns;
        /* 0x286C */ public bool TakeNoDamage;
        /* 0x286D */ public bool ThirdPersonIsDefaultCameraForPlayer;
        /* 0x286E */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        /* 0x286F */ public bool UnlockAllPlatformRewards;
        /* 0x2870 */ public bool UnlockAllSeasonRewards;
        /* 0x2871 */ public bool UnlockAllStories;
        /* 0x2872 */ public bool UnlockAllTitles;
        /* 0x2873 */ public bool UnlockAllTwitchRewards;
        /* 0x2874 */ public bool UnlockAllWords;
        /* 0x2875 */ public bool UseBuildings;
        /* 0x2876 */ public bool UseClouds;
        /* 0x2877 */ public bool UseCreatures;
        /* 0x2878 */ public bool UseElevation;
        /* 0x2879 */ public bool UseGunImpactEffect;
        /* 0x287A */ public bool UseHighlightedOptionStyle;
        /* 0x287B */ public bool UseInstances;
        /* 0x287C */ public bool UseLegacyBuildingTable;
        /* 0x287D */ public bool UseLegacyFreighters;
        /* 0x287E */ public bool UseObjects;
        /* 0x287F */ public bool UsePadOnUnfocusedWindow;
        /* 0x2880 */ public bool UseParticles;
        /* 0x2881 */ public bool UseProcTextureDebugger;
        /* 0x2882 */ public bool UseScreenEffects;
        /* 0x2883 */ public bool UseSeasonTransferInventoryConfigOverride;
        /* 0x2884 */ public bool UseTerrain;
        /* 0x2885 */ public bool UseVolumetrics;
        /* 0x2886 */ public bool VideoCaptureMode;
    }
}

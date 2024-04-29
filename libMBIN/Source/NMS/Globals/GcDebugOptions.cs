using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x70B6CDE7AB195C33, NameHash = 0x13FED27DF728C38)]
    public class GcDebugOptions : NMSTemplate
    {
        [NMS(Index = 411)]
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        [NMS(Index = 408)]
        /* 0x0030 */ public NMSString0x10 CreateSeasonContextMaskIdOverride;
        [NMS(Index = 333)]
        /* 0x0040 */ public NMSString0x10 DefaultAirCreatureTable;
        [NMS(Index = 335)]
        /* 0x0050 */ public NMSString0x10 DefaultCaveCreatureTable;
        [NMS(Index = 332)]
        /* 0x0060 */ public NMSString0x10 DefaultGroundCreatureTable;
        [NMS(Index = 334)]
        /* 0x0070 */ public NMSString0x10 DefaultWaterCreatureTable;
        [NMS(Index = 68)]
        /* 0x0080 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        [NMS(Index = 173)]
        /* 0x0090 */ public List<NMSString0x20> LocTableList;
        [NMS(Index = 409)]
        /* 0x00A0 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        [NMS(Index = 195)]
        /* 0x00B0 */ public ulong ForceTimeToEpoch;
        [NMS(Index = 4)]
        /* 0x00B8 */ public ulong OverrideAbandonedFreighterSeed;
        [NMS(Index = 392)]
        /* 0x00C0 */ public TkGlobals ToolkitGlobals;
        [NMS(Index = 182)]
        /* 0x0350 */ public float _3dTextDistance;
        [NMS(Index = 183)]
        /* 0x0354 */ public float _3dTextMinScale;
        [NMS(Index = 382)]
        /* 0x0358 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        [NMS(Index = 377)]
        /* 0x035C */ public float BaseDownloadTimeout;
        [NMS(Index = 389)]
        /* 0x0360 */ public uint BasePayloadMultiplier;
        [NMS(Index = 11)]
        /* 0x0364 */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        [NMS(Index = 110)]
        /* 0x0368 */ public BootLoadDelayEnum BootLoadDelay;
        [NMS(Index = 177)]
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
        [NMS(Index = 100)]
        /* 0x0370 */ public BootModeEnum BootMode;
        [NMS(Index = 163)]
        /* 0x0374 */ public TkLanguages DebugLanguage;
        [NMS(Index = 292)]
        /* 0x0378 */ public int DebugTextureSize;
        [NMS(Index = 268)]
        /* 0x037C */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Index = 344)]
        /* 0x0380 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        [NMS(Index = 358)]
        /* 0x0384 */ public int ForceAsteroidSystemIndex;
        [NMS(Index = 325)]
        /* 0x0388 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        [NMS(Index = 322)]
        /* 0x038C */ public GcBiomeType ForceBiomeTo;
        [NMS(Index = 327)]
        /* 0x0390 */ public GcAlienRace ForceBuildingRaceTo;
        [NMS(Index = 336)]
        /* 0x0394 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        [NMS(Index = 351)]
        /* 0x0398 */ public int ForceGrassColourIndex;
        [NMS(Index = 113)]
        /* 0x039C */ public float ForceInitialTimeOfDay;
        [NMS(Index = 158)]
        /* 0x03A0 */ public int ForceInteractionIndex;
        [NMS(Index = 166)]
        /* 0x03A4 */ public GcAlienRace ForceInteractionRaceTo;
        [NMS(Index = 329)]
        /* 0x03A8 */ public GcPlanetLife ForceLifeLevelTo;
        [NMS(Index = 159)]
        /* 0x03AC */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        [NMS(Index = 324)]
        /* 0x03B0 */ public GcScreenFilters ForceScreenFilterTo;
        [NMS(Index = 347)]
        /* 0x03B4 */ public int ForceSkyColourIndex;
        [NMS(Index = 40)]
        /* 0x03B8 */ public int ForceSpaceBattleLevel;
        [NMS(Index = 348)]
        /* 0x03BC */ public int ForceSpaceSkyColourIndex;
        [NMS(Index = 320)]
        /* 0x03C0 */ public GcGalaxyStarTypes ForceStarTypeTo;
        [NMS(Index = 115)]
        /* 0x03C4 */ public float ForceSunAngle;
        [NMS(Index = 337)]
        /* 0x03C8 */ public GcPlanetLife ForceTerrainSettings;
        [NMS(Index = 339)]
        /* 0x03CC */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        [NMS(Index = 112)]
        /* 0x03D0 */ public float ForceTimeOfDay;
        [NMS(Index = 350)]
        /* 0x03D4 */ public int ForceWaterColourIndex;
        [NMS(Index = 346)]
        /* 0x03D8 */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        [NMS(Index = 99)]
        /* 0x03DC */ public GameStateModeEnum GameStateMode;
        [NMS(Index = 367)]
        /* 0x03E0 */ public float GenerateCostAngle;
        [NMS(Index = 366)]
        /* 0x03E4 */ public float GenerateCostDistance;
        [NMS(Index = 368)]
        /* 0x03E8 */ public float GenerateCostLOD;
        [NMS(Index = 369)]
        /* 0x03EC */ public float GenerateCostWait;
        [NMS(Index = 364)]
        /* 0x03F0 */ public int GenerateFarLodBuildingDist;
        [NMS(Index = 290)]
        /* 0x03F4 */ public int MaxNumDebugMessages;
        [NMS(Index = 380)]
        /* 0x03F8 */ public int MoveBaseIndex;
        [NMS(Index = 404)]
        /* 0x03FC */ public int MultipleFingersSamePressFrameDelta;
        [NMS(Index = 13)]
        /* 0x0400 */ public GcGameMode NewSaveGameMode;
        [NMS(Index = 91)]
        /* 0x0404 */ public int OctahedralImpostersViewCount;
        [NMS(Index = 275)]
        /* 0x0408 */ public int OverrideMatchmakingVersion;
        [NMS(Index = 285)]
        /* 0x040C */ public int OverrideServerSeasonEndTime;
        [NMS(Index = 284)]
        /* 0x0410 */ public int OverrideServerSeasonNumber;
        [NMS(Index = 407)]
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
        [NMS(Index = 101)]
        /* 0x0418 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Index = 295)]
        /* 0x041C */ public int ProceduralModelBatchSize;
        [NMS(Index = 296)]
        /* 0x0420 */ public int ProceduralModelFilterMatchretryCount;
        [NMS(Index = 294)]
        /* 0x0424 */ public int ProceduralModelsShown;
        [NMS(Index = 298)]
        /* 0x0428 */ public int ProceduralModelsThumbnailSize;
        [NMS(Index = 384)]
        /* 0x042C */ public int ProfilerPartIndexPhase;
        [NMS(Index = 385)]
        /* 0x0430 */ public int ProfilerPartIndexStride;
        [NMS(Index = 386)]
        /* 0x0434 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        [NMS(Index = 262)]
        /* 0x0438 */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        [NMS(Index = 167)]
        /* 0x043C */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        [NMS(Index = 184)]
        /* 0x0440 */ public RecordSettingEnum RecordSetting;
        [NMS(Index = 194)]
        /* 0x0444 */ public int RecurrenceTimeOffset;
        [NMS(Index = 403)]
        /* 0x0448 */ public int ScreenshotForUploadHeight;
        [NMS(Index = 402)]
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
        [NMS(Index = 264)]
        /* 0x0450 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        [NMS(Index = 106)]
        /* 0x0454 */ public ShaderPreloadEnum ShaderPreload;
        [NMS(Index = 211)]
        /* 0x0458 */ public int ShowSpecificGraph;
        [NMS(Index = 227)]
        /* 0x045C */ public int SmokeTestConfigCaptureCycles;
        [NMS(Index = 228)]
        /* 0x0460 */ public float SmokeTestConfigCaptureDurationInSeconds;
        [NMS(Index = 229)]
        /* 0x0464 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        [NMS(Index = 220)]
        /* 0x0468 */ public int SmokeTestConfigPlanetPositionCount;
        [NMS(Index = 222)]
        /* 0x046C */ public float SmokeTestConfigScenarioLength;
        [NMS(Index = 221)]
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
        [NMS(Index = 217)]
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
        [NMS(Index = 218)]
        /* 0x0478 */ public SmokeTestScenarioEnum SmokeTestScenario;
        [NMS(Index = 232)]
        /* 0x047C */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        [NMS(Index = 105)]
        /* 0x0480 */ public SolarSystemBootEnum SolarSystemBoot;
        [NMS(Index = 405)]
        /* 0x0484 */ public int SwipeDetectionMaxFrames;
        [NMS(Index = 406)]
        /* 0x0488 */ public float SwipeDetectionNormalizedTravelThreshold;
        [NMS(Index = 288)]
        /* 0x048C */ public int SynergyPort;
        [NMS(Index = 179)]
        /* 0x0490 */ public float WeaponScale3P;
        [NMS(Index = 172)]
        /* 0x0494 */ public ushort RealityGenerationIteration;
        [NMS(Index = 271)]
        /* 0x0496 */ public NMSString0x800 AutoJoinUserNames;
        [NMS(Index = 83)]
        /* 0x0C96 */ public NMSString0x400 DebugTwitchRewards;
        [NMS(Index = 276)]
        /* 0x1096 */ public NMSString0x200 LoadToBase;
        [NMS(Index = 79)]
        /* 0x1296 */ public NMSString0x200 SeasonalDataOverrideFile;
        [NMS(Index = 96)]
        /* 0x1496 */ public NMSString0x100 ForcePlayerPosition;
        [NMS(Index = 95)]
        /* 0x1596 */ public NMSString0x100 ForceUniverseAddress;
        [NMS(Index = 279)]
        /* 0x1696 */ public NMSString0x100 GOGLogin;
        [NMS(Index = 209)]
        /* 0x1796 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        [NMS(Index = 103)]
        /* 0x1896 */ public NMSString0x100 WorkingDirectory;
        [NMS(Index = 265)]
        /* 0x1996 */ public NMSString0x80 AuthBaseUrl;
        [NMS(Index = 196)]
        /* 0x1A16 */ public NMSString0x80 CrashDumpPath;
        [NMS(Index = 301)]
        /* 0x1A96 */ public NMSString0x80 CursorTexture;
        [NMS(Index = 299)]
        /* 0x1B16 */ public NMSString0x80 DebugFont;
        [NMS(Index = 300)]
        /* 0x1B96 */ public NMSString0x80 DebugFontTexture;
        [NMS(Index = 104)]
        /* 0x1C16 */ public NMSString0x80 DebugScene;
        [NMS(Index = 174)]
        /* 0x1C96 */ public NMSString0x80 DefaultSaveData;
        [NMS(Index = 302)]
        /* 0x1D16 */ public NMSString0x80 PauseTexture;
        [NMS(Index = 245)]
        /* 0x1D96 */ public NMSString0x80 PipelineFile;
        [NMS(Index = 246)]
        /* 0x1E16 */ public NMSString0x80 PipelineFileApple;
        [NMS(Index = 252)]
        /* 0x1E96 */ public NMSString0x80 PipelineFileEditor;
        [NMS(Index = 251)]
        /* 0x1F16 */ public NMSString0x80 PipelineFileFrontend;
        [NMS(Index = 247)]
        /* 0x1F96 */ public NMSString0x80 PipelineFilePS4;
        [NMS(Index = 253)]
        /* 0x2016 */ public NMSString0x80 PipelineFileSwitch;
        [NMS(Index = 254)]
        /* 0x2096 */ public NMSString0x80 PipelineFileSwitchFSR2;
        [NMS(Index = 249)]
        /* 0x2116 */ public NMSString0x80 PipelineFileVR;
        [NMS(Index = 250)]
        /* 0x2196 */ public NMSString0x80 PipelineFileVRPS4;
        [NMS(Index = 248)]
        /* 0x2216 */ public NMSString0x80 PipelineFileXboxOne;
        [NMS(Index = 303)]
        /* 0x2296 */ public NMSString0x80 PlayTexture;
        [NMS(Index = 263)]
        /* 0x2316 */ public NMSString0x80 ProxyURI;
        [NMS(Index = 171)]
        /* 0x2396 */ public NMSString0x80 RealityPresetFile;
        [NMS(Index = 305)]
        /* 0x2416 */ public NMSString0x80 RenderToTexture;
        [NMS(Index = 102)]
        /* 0x2496 */ public NMSString0x80 SceneSettings;
        [NMS(Index = 304)]
        /* 0x2516 */ public NMSString0x80 StepTexture;
        [NMS(Index = 395)]
        /* 0x2596 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        [NMS(Index = 394)]
        /* 0x25D6 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        [NMS(Index = 401)]
        /* 0x2616 */ public NMSString0x40 ScreenshotForUploadName;
        [NMS(Index = 164)]
        /* 0x2656 */ public NMSString0x20 AllowedLanguagesFile;
        [NMS(Index = 381)]
        /* 0x2676 */ public NMSString0x20 AutomaticPartSpawnID;
        [NMS(Index = 388)]
        /* 0x2696 */ public NMSString0x20 BaseServerPlatform;
        [NMS(Index = 197)]
        /* 0x26B6 */ public NMSString0x20 CrashDumpIdentifier;
        [NMS(Index = 267)]
        /* 0x26D6 */ public NMSString0x20 OverrideUsernameForDev;
        [NMS(Index = 188)]
        /* 0x26F6 */ public NMSString0x20 SaveTestingCommand;
        [NMS(Index = 234)]
        /* 0x2716 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        [NMS(Index = 235)]
        /* 0x2736 */ public NMSString0x20 SmokeTestRunFolder;
        [NMS(Index = 287)]
        /* 0x2756 */ public NMSString0x20 SynergyServer;
        [NMS(Index = 118)]
        /* 0x2776 */ public bool AllowGalaxyMapRequests;
        [NMS(Index = 376)]
        /* 0x2777 */ public bool AllowGlobalPartSnapping;
        [NMS(Index = 314)]
        /* 0x2778 */ public bool AllowNGuiVR;
        [NMS(Index = 393)]
        /* 0x2779 */ public bool AllowOverrideSettlementOwnership;
        [NMS(Index = 84)]
        /* 0x277A */ public bool AllowPause;
        [NMS(Index = 2)]
        /* 0x277B */ public bool AllowSavingOnAbandonedFreighters;
        [NMS(Index = 145)]
        /* 0x277C */ public bool AllSeasonMilestonesShowComplete;
        [NMS(Index = 85)]
        /* 0x277D */ public bool AllSettlementsAreCompleted;
        [NMS(Index = 69)]
        /* 0x277E */ public bool AlternateControls;
        [NMS(Index = 78)]
        /* 0x277F */ public bool AlwaysAllowFreighterInventoryAccess;
        [NMS(Index = 76)]
        /* 0x2780 */ public bool AlwaysAllowShipOperations;
        [NMS(Index = 77)]
        /* 0x2781 */ public bool AlwaysAllowVehicleOperations;
        [NMS(Index = 19)]
        /* 0x2782 */ public bool AlwaysHaveFocus;
        [NMS(Index = 260)]
        /* 0x2783 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        [NMS(Index = 272)]
        /* 0x2784 */ public bool AlwaysSaveGameAsClient;
        [NMS(Index = 70)]
        /* 0x2785 */ public bool AlwaysShowURI;
        [NMS(Index = 39)]
        /* 0x2786 */ public bool AlwaysSpaceBattle;
        [NMS(Index = 278)]
        /* 0x2787 */ public bool AutoJoinRandomGames;
        [NMS(Index = 270)]
        /* 0x2788 */ public bool AutoJoinUserEnabled;
        [NMS(Index = 383)]
        /* 0x2789 */ public bool AutomaticPartSpawnInactive;
        [NMS(Index = 387)]
        /* 0x278A */ public bool BaseAdmin;
        [NMS(Index = 93)]
        /* 0x278B */ public bool BlockCommunicatorSignals;
        [NMS(Index = 396)]
        /* 0x278C */ public bool BlockSettlementsNetwork;
        [NMS(Index = 308)]
        /* 0x278D */ public bool BodyTurning;
        [NMS(Index = 12)]
        /* 0x278E */ public bool BootDirectlyIntoLastSave;
        [NMS(Index = 178)]
        /* 0x278F */ public bool BootMusic;
        [NMS(Index = 30)]
        /* 0x2790 */ public bool CanLeaveDialogs;
        [NMS(Index = 266)]
        /* 0x2791 */ public bool CertificateSecurityBypass;
        [NMS(Index = 55)]
        /* 0x2792 */ public bool ClothForceAsyncSimulationOff;
        [NMS(Index = 56)]
        /* 0x2793 */ public bool ClothForceAsyncSimulationOn;
        [NMS(Index = 54)]
        /* 0x2794 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        [NMS(Index = 51)]
        /* 0x2795 */ public bool ClothForcePositionExtrapolationBackOn;
        [NMS(Index = 49)]
        /* 0x2796 */ public bool ClothForcePositionExtrapolationOff;
        [NMS(Index = 50)]
        /* 0x2797 */ public bool ClothForcePositionExtrapolationOn;
        [NMS(Index = 53)]
        /* 0x2798 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        [NMS(Index = 52)]
        /* 0x2799 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        [NMS(Index = 240)]
        /* 0x279A */ public bool CompressTextures;
        [NMS(Index = 236)]
        /* 0x279B */ public bool CreatureChatter;
        [NMS(Index = 238)]
        /* 0x279C */ public bool CreatureDrawVocals;
        [NMS(Index = 237)]
        /* 0x279D */ public bool CreatureErrors;
        [NMS(Index = 390)]
        /* 0x279E */ public bool CrossPlatformFeaturedBases;
        [NMS(Index = 370)]
        /* 0x279F */ public bool DChecksEnabled;
        [NMS(Index = 372)]
        /* 0x27A0 */ public bool DChecksOutputBinary;
        [NMS(Index = 373)]
        /* 0x27A1 */ public bool DChecksOutputFileLine;
        [NMS(Index = 371)]
        /* 0x27A2 */ public bool DChecksOutputJson;
        [NMS(Index = 185)]
        /* 0x27A3 */ public bool DebugBuildingSpawns;
        [NMS(Index = 156)]
        /* 0x27A4 */ public bool DebugDrawPlayerInteract;
        [NMS(Index = 21)]
        /* 0x27A5 */ public bool DebugGalaxyMapInQuickMenu;
        [NMS(Index = 241)]
        /* 0x27A6 */ public bool DebugIBL;
        [NMS(Index = 168)]
        /* 0x27A7 */ public bool DebugPersistentInteractions;
        [NMS(Index = 242)]
        /* 0x27A8 */ public bool DebugSpotlights;
        [NMS(Index = 243)]
        /* 0x27A9 */ public bool DebugTerrainTextures;
        [NMS(Index = 198)]
        /* 0x27AA */ public bool DebugThreatLevels;
        [NMS(Index = 365)]
        /* 0x27AB */ public bool DeferRegionBodies;
        [NMS(Index = 3)]
        /* 0x27AC */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Index = 374)]
        /* 0x27AD */ public bool DisableBaseBuilding;
        [NMS(Index = 375)]
        /* 0x27AE */ public bool DisableBaseBuildingLimits;
        [NMS(Index = 378)]
        /* 0x27AF */ public bool DisableBasePowerRequirements;
        [NMS(Index = 44)]
        /* 0x27B0 */ public bool DisableContinuousSaving;
        [NMS(Index = 151)]
        /* 0x27B1 */ public bool DisableDebugControls;
        [NMS(Index = 155)]
        /* 0x27B2 */ public bool DisableDiscoveryNaming;
        [NMS(Index = 192)]
        /* 0x27B3 */ public bool DisableFileWatcher;
        [NMS(Index = 28)]
        /* 0x27B4 */ public bool DisableHazards;
        [NMS(Index = 312)]
        /* 0x27B5 */ public bool DisableHeadConstraints;
        [NMS(Index = 45)]
        /* 0x27B6 */ public bool DisableInvalidSaveVersion;
        [NMS(Index = 311)]
        /* 0x27B7 */ public bool DisableLeftHand;
        [NMS(Index = 359)]
        /* 0x27B8 */ public bool DisableLimits;
        [NMS(Index = 170)]
        /* 0x27B9 */ public bool DisableMissionShop;
        [NMS(Index = 273)]
        /* 0x27BA */ public bool DisableMonumentDownloads;
        [NMS(Index = 65)]
        /* 0x27BB */ public bool DisableNPCHiddenUntilScanned;
        [NMS(Index = 64)]
        /* 0x27BC */ public bool DisableNPCs;
        [NMS(Index = 31)]
        /* 0x27BD */ public bool DisableOldMissions;
        [NMS(Index = 398)]
        /* 0x27BE */ public bool DisablePartialStories;
        [NMS(Index = 191)]
        /* 0x27BF */ public bool DisableProfanityFilter;
        [NMS(Index = 42)]
        /* 0x27C0 */ public bool DisableSaveSlotSorting;
        [NMS(Index = 43)]
        /* 0x27C1 */ public bool DisableSaving;
        [NMS(Index = 86)]
        /* 0x27C2 */ public bool DisableSettlements;
        [NMS(Index = 193)]
        /* 0x27C3 */ public bool DisableShaderReload;
        [NMS(Index = 244)]
        /* 0x27C4 */ public bool DisableShadowSwitching;
        [NMS(Index = 269)]
        /* 0x27C5 */ public bool DisableSpaceStationSpawnOnJoin;
        [NMS(Index = 46)]
        /* 0x27C6 */ public bool DisableStorms;
        [NMS(Index = 20)]
        /* 0x27C7 */ public bool DisableVibration;
        [NMS(Index = 165)]
        /* 0x27C8 */ public bool DoAlienLanguage;
        [NMS(Index = 239)]
        /* 0x27C9 */ public bool DrawCreaturesInRoutines;
        [NMS(Index = 199)]
        /* 0x27CA */ public bool DumpManifestContents;
        [NMS(Index = 397)]
        /* 0x27CB */ public bool EnableAccessibleUI;
        [NMS(Index = 148)]
        /* 0x27CC */ public bool EnableBaseBuildingExpandables;
        [NMS(Index = 379)]
        /* 0x27CD */ public bool EnableBaseMovingOption;
        [NMS(Index = 124)]
        /* 0x27CE */ public bool EnableCloudAnimation;
        [NMS(Index = 256)]
        /* 0x27CF */ public bool EnableComputePost;
        [NMS(Index = 133)]
        /* 0x27D0 */ public bool EnableDayNightCycle;
        [NMS(Index = 257)]
        /* 0x27D1 */ public bool EnableEvenOddRender;
        [NMS(Index = 117)]
        /* 0x27D2 */ public bool EnableFrontendPreload;
        [NMS(Index = 146)]
        /* 0x27D3 */ public bool EnableGalaxyRecolouring;
        [NMS(Index = 92)]
        /* 0x27D4 */ public bool EnableMemoryPoolAllocPrint;
        [NMS(Index = 313)]
        /* 0x27D5 */ public bool EnablePhotomodeVR;
        [NMS(Index = 286)]
        /* 0x27D6 */ public bool EnableSynergy;
        [NMS(Index = 24)]
        /* 0x27D7 */ public bool EverythingIsFree;
        [NMS(Index = 25)]
        /* 0x27D8 */ public bool EverythingIsKnown;
        [NMS(Index = 26)]
        /* 0x27D9 */ public bool EverythingIsStar;
        [NMS(Index = 281)]
        /* 0x27DA */ public bool FakeHandsInMultiplayer;
        [NMS(Index = 41)]
        /* 0x27DB */ public bool FastAndFrequentFleetInterventions;
        [NMS(Index = 10)]
        /* 0x27DC */ public bool FastLoad;
        [NMS(Index = 152)]
        /* 0x27DD */ public bool FixedFramerate;
        [NMS(Index = 181)]
        /* 0x27DE */ public bool FleetDirectorAutoMode;
        [NMS(Index = 176)]
        /* 0x27DF */ public bool ForceBasicLoadScreen;
        [NMS(Index = 342)]
        /* 0x27E0 */ public bool ForceBinaryStar;
        [NMS(Index = 321)]
        /* 0x27E1 */ public bool ForceBiome;
        [NMS(Index = 67)]
        /* 0x27E2 */ public bool ForceBuildersAlwaysKnown;
        [NMS(Index = 326)]
        /* 0x27E3 */ public bool ForceBuildingRace;
        [NMS(Index = 317)]
        /* 0x27E4 */ public bool ForceCorruptSentinels;
        [NMS(Index = 330)]
        /* 0x27E5 */ public bool ForceCreatureLifeLevel;
        [NMS(Index = 331)]
        /* 0x27E6 */ public bool ForceDefaultCreatureFile;
        [NMS(Index = 48)]
        /* 0x27E7 */ public bool ForceDisableClothComponent;
        [NMS(Index = 61)]
        /* 0x27E8 */ public bool ForceDisableNonPlayerRagdollComponents;
        [NMS(Index = 60)]
        /* 0x27E9 */ public bool ForceDisableRagdollComponent;
        [NMS(Index = 63)]
        /* 0x27EA */ public bool ForceDisableSplitIkOptimisation;
        [NMS(Index = 58)]
        /* 0x27EB */ public bool ForceDisableSpringAttachmentComponent;
        [NMS(Index = 47)]
        /* 0x27EC */ public bool ForceEnableClothComponent;
        [NMS(Index = 59)]
        /* 0x27ED */ public bool ForceEnableRagdollComponent;
        [NMS(Index = 62)]
        /* 0x27EE */ public bool ForceEnableSplitIkOptimisation;
        [NMS(Index = 57)]
        /* 0x27EF */ public bool ForceEnableSpringAttachmentComponent;
        [NMS(Index = 316)]
        /* 0x27F0 */ public bool ForceExtremeSentinels;
        [NMS(Index = 315)]
        /* 0x27F1 */ public bool ForceExtremeWeather;
        [NMS(Index = 97)]
        /* 0x27F2 */ public bool ForceInitialShip;
        [NMS(Index = 98)]
        /* 0x27F3 */ public bool ForceInitialWeapon;
        [NMS(Index = 157)]
        /* 0x27F4 */ public bool ForceInteractionToSettings;
        [NMS(Index = 328)]
        /* 0x27F5 */ public bool ForceLifeLevel;
        [NMS(Index = 319)]
        /* 0x27F6 */ public bool ForceLoadAllWeather;
        [NMS(Index = 143)]
        /* 0x27F7 */ public bool ForceNexusInQuickMenu;
        [NMS(Index = 340)]
        /* 0x27F8 */ public bool ForcePirateSystem;
        [NMS(Index = 354)]
        /* 0x27F9 */ public bool ForcePlanetsToHaveNoCaves;
        [NMS(Index = 355)]
        /* 0x27FA */ public bool ForcePlanetsToHaveNoNoiseLayers;
        [NMS(Index = 356)]
        /* 0x27FB */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        [NMS(Index = 353)]
        /* 0x27FC */ public bool ForcePlanetsToHaveNoWater;
        [NMS(Index = 345)]
        /* 0x27FD */ public bool ForcePlanetsToHaveWater;
        [NMS(Index = 341)]
        /* 0x27FE */ public bool ForcePrimeTerrain;
        [NMS(Index = 357)]
        /* 0x27FF */ public bool ForceRareAsteroidSystem;
        [NMS(Index = 0)]
        /* 0x2800 */ public bool ForceScanEventsToGoPrime;
        [NMS(Index = 323)]
        /* 0x2801 */ public bool ForceScreenFilter;
        [NMS(Index = 282)]
        /* 0x2802 */ public bool ForceSmallLobby;
        [NMS(Index = 349)]
        /* 0x2803 */ public bool ForceSpaceSkyColourRare;
        [NMS(Index = 318)]
        /* 0x2804 */ public bool ForceStarType;
        [NMS(Index = 114)]
        /* 0x2805 */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Index = 343)]
        /* 0x2806 */ public bool ForceTernaryStar;
        [NMS(Index = 338)]
        /* 0x2807 */ public bool ForceTerrainType;
        [NMS(Index = 283)]
        /* 0x2808 */ public bool ForceTinyLobby;
        [NMS(Index = 36)]
        /* 0x2809 */ public bool ForceTranslateAllAlienText;
        [NMS(Index = 175)]
        /* 0x280A */ public bool FormatDownloadStorageAreaOnBoot;
        [NMS(Index = 16)]
        /* 0x280B */ public bool GodMode;
        [NMS(Index = 212)]
        /* 0x280C */ public bool GraphCommandBuffer;
        [NMS(Index = 214)]
        /* 0x280D */ public bool GraphFPS;
        [NMS(Index = 213)]
        /* 0x280E */ public bool GraphGeneration;
        [NMS(Index = 215)]
        /* 0x280F */ public bool GraphTexStreaming;
        [NMS(Index = 190)]
        /* 0x2810 */ public bool HangOnCrash;
        [NMS(Index = 306)]
        /* 0x2811 */ public bool HmdFrameShiftEnabled;
        [NMS(Index = 307)]
        /* 0x2812 */ public bool HmdUseSolidGuiPointer;
        [NMS(Index = 37)]
        /* 0x2813 */ public bool IgnoreFreighterSpawnWarpRequirement;
        [NMS(Index = 29)]
        /* 0x2814 */ public bool IgnoreMissionRank;
        [NMS(Index = 147)]
        /* 0x2815 */ public bool IgnoreSteamDev;
        [NMS(Index = 277)]
        /* 0x2816 */ public bool IgnoreTransactionTimeouts;
        [NMS(Index = 161)]
        /* 0x2817 */ public bool InfiniteInteractions;
        [NMS(Index = 27)]
        /* 0x2818 */ public bool InfiniteStamina;
        [NMS(Index = 138)]
        /* 0x2819 */ public bool InstanceCollision;
        [NMS(Index = 160)]
        /* 0x281A */ public bool InteractionsAllwaysGivesTech;
        [NMS(Index = 363)]
        /* 0x281B */ public bool LimitGlobalBodies;
        [NMS(Index = 362)]
        /* 0x281C */ public bool LimitGlobalInstances;
        [NMS(Index = 361)]
        /* 0x281D */ public bool LimitPerRegionBodies;
        [NMS(Index = 360)]
        /* 0x281E */ public bool LimitPerRegionInstances;
        [NMS(Index = 139)]
        /* 0x281F */ public bool LoadMissions;
        [NMS(Index = 259)]
        /* 0x2820 */ public bool LoadShaderSourceIfRenderdocEnabled;
        [NMS(Index = 75)]
        /* 0x2821 */ public bool LockAllTitles;
        [NMS(Index = 180)]
        /* 0x2822 */ public bool LogMissingLocalisedText;
        [NMS(Index = 23)]
        /* 0x2823 */ public bool MapWarpCheckIgnoreDrive;
        [NMS(Index = 22)]
        /* 0x2824 */ public bool MapWarpCheckIgnoreFuel;
        [NMS(Index = 38)]
        /* 0x2825 */ public bool MaximumFreighterSpawns;
        [NMS(Index = 111)]
        /* 0x2826 */ public bool MemCsv;
        [NMS(Index = 119)]
        /* 0x2827 */ public bool MissionMessageLoggingEnabled;
        [NMS(Index = 120)]
        /* 0x2828 */ public bool MissionNGUIShowsConditionResults;
        [NMS(Index = 144)]
        /* 0x2829 */ public bool MissionSurveyEnabled;
        [NMS(Index = 352)]
        /* 0x282A */ public bool ModifyPlanetsInInitialSystems;
        [NMS(Index = 149)]
        /* 0x282B */ public bool MouseLookEnabled;
        [NMS(Index = 140)]
        /* 0x282C */ public bool MPMissions;
        [NMS(Index = 71)]
        /* 0x282D */ public bool MPMissionsAlwaysEPIC;
        [NMS(Index = 142)]
        /* 0x282E */ public bool MultiplePlayerFreightersInASystem;
        [NMS(Index = 189)]
        /* 0x282F */ public bool NeverUseBanks;
        [NMS(Index = 89)]
        /* 0x2830 */ public bool OctahedralImpostersDisable;
        [NMS(Index = 88)]
        /* 0x2831 */ public bool OctahedralImpostersEnable;
        [NMS(Index = 90)]
        /* 0x2832 */ public bool OctahedralImpostersViewFromSpace;
        [NMS(Index = 87)]
        /* 0x2833 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        [NMS(Index = 291)]
        /* 0x2834 */ public bool PreloadToolbox;
        [NMS(Index = 204)]
        /* 0x2835 */ public bool PrintAvgFrameTimes;
        [NMS(Index = 297)]
        /* 0x2836 */ public bool ProceduralModelsDeterministicSequence;
        [NMS(Index = 258)]
        /* 0x2837 */ public bool Proto2DevKit;
        [NMS(Index = 280)]
        /* 0x2838 */ public bool RecordNetworkStatsOnBoot;
        [NMS(Index = 34)]
        /* 0x2839 */ public bool RenderCreatureDetails;
        [NMS(Index = 154)]
        /* 0x283A */ public bool RenderHud;
        [NMS(Index = 255)]
        /* 0x283B */ public bool RenderLowFramerate;
        [NMS(Index = 116)]
        /* 0x283C */ public bool ResetForcedSaveSlotOnLoad;
        [NMS(Index = 94)]
        /* 0x283D */ public bool ResetToSupportedResolution;
        [NMS(Index = 73)]
        /* 0x283E */ public bool RevealAllTitles;
        [NMS(Index = 153)]
        /* 0x283F */ public bool ScreenshotMode;
        [NMS(Index = 109)]
        /* 0x2840 */ public bool ShaderCaching;
        [NMS(Index = 107)]
        /* 0x2841 */ public bool ShaderPreloadListExport;
        [NMS(Index = 108)]
        /* 0x2842 */ public bool ShaderPreloadListImport;
        [NMS(Index = 66)]
        /* 0x2843 */ public bool ShipSalvageGivesAllParts;
        [NMS(Index = 200)]
        /* 0x2844 */ public bool ShowDebugMessages;
        [NMS(Index = 203)]
        /* 0x2845 */ public bool ShowDynamicResScale;
        [NMS(Index = 289)]
        /* 0x2846 */ public bool ShowEditorPlacementPreview;
        [NMS(Index = 72)]
        /* 0x2847 */ public bool ShowFireteamMembersUA;
        [NMS(Index = 201)]
        /* 0x2848 */ public bool ShowFramerate;
        [NMS(Index = 206)]
        /* 0x2849 */ public bool ShowGPUMemory;
        [NMS(Index = 202)]
        /* 0x284A */ public bool ShowGPURenderTime;
        [NMS(Index = 210)]
        /* 0x284B */ public bool ShowGraphs;
        [NMS(Index = 309)]
        /* 0x284C */ public bool ShowHmdHandControllers;
        [NMS(Index = 187)]
        /* 0x284D */ public bool ShowLongestStrings;
        [NMS(Index = 207)]
        /* 0x284E */ public bool ShowMempoolOverlay;
        [NMS(Index = 391)]
        /* 0x284F */ public bool ShowMissionIdInTitle;
        [NMS(Index = 208)]
        /* 0x2850 */ public bool ShowMouseSmoothing;
        [NMS(Index = 205)]
        /* 0x2851 */ public bool ShowPositionDebug;
        [NMS(Index = 310)]
        /* 0x2852 */ public bool ShowTeleportEffectLocally;
        [NMS(Index = 261)]
        /* 0x2853 */ public bool SimulateNoNetworkConnection;
        [NMS(Index = 1)]
        /* 0x2854 */ public bool SkipAbandonedFreighterUnlocking;
        [NMS(Index = 7)]
        /* 0x2855 */ public bool SkipIntro;
        [NMS(Index = 8)]
        /* 0x2856 */ public bool SkipLogos;
        [NMS(Index = 14)]
        /* 0x2857 */ public bool SkipPlanetDiscoverOnBoot;
        [NMS(Index = 35)]
        /* 0x2858 */ public bool SkipTutorial;
        [NMS(Index = 9)]
        /* 0x2859 */ public bool SkipUITimers;
        [NMS(Index = 224)]
        /* 0x285A */ public bool SmokeTestCameraFly;
        [NMS(Index = 230)]
        /* 0x285B */ public bool SmokeTestConfigRandomizePlanetSeed;
        [NMS(Index = 216)]
        /* 0x285C */ public bool SmokeTestDumpStatsMode;
        [NMS(Index = 223)]
        /* 0x285D */ public bool SmokeTestFastExit;
        [NMS(Index = 219)]
        /* 0x285E */ public bool SmokeTestLegacyOutput;
        [NMS(Index = 225)]
        /* 0x285F */ public bool SmokeTestOutputOnly;
        [NMS(Index = 233)]
        /* 0x2860 */ public bool SmokeTestPostBandwidthStats;
        [NMS(Index = 226)]
        /* 0x2861 */ public bool SmokeTestPureFlight;
        [NMS(Index = 231)]
        /* 0x2862 */ public bool SmokeTestSmokeBotEnabled;
        [NMS(Index = 134)]
        /* 0x2863 */ public bool SpawnPirates;
        [NMS(Index = 137)]
        /* 0x2864 */ public bool SpawnPulseEncounters;
        [NMS(Index = 135)]
        /* 0x2865 */ public bool SpawnRobots;
        [NMS(Index = 136)]
        /* 0x2866 */ public bool SpawnShips;
        [NMS(Index = 141)]
        /* 0x2867 */ public bool SpecialsShop;
        [NMS(Index = 150)]
        /* 0x2868 */ public bool StartPaused;
        [NMS(Index = 162)]
        /* 0x2869 */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Index = 186)]
        /* 0x286A */ public bool StressTestLongNameDisplay;
        [NMS(Index = 18)]
        /* 0x286B */ public bool SuperKillGuns;
        [NMS(Index = 17)]
        /* 0x286C */ public bool TakeNoDamage;
        [NMS(Index = 5)]
        /* 0x286D */ public bool ThirdPersonIsDefaultCameraForPlayer;
        [NMS(Index = 6)]
        /* 0x286E */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        [NMS(Index = 82)]
        /* 0x286F */ public bool UnlockAllPlatformRewards;
        [NMS(Index = 80)]
        /* 0x2870 */ public bool UnlockAllSeasonRewards;
        [NMS(Index = 399)]
        /* 0x2871 */ public bool UnlockAllStories;
        [NMS(Index = 74)]
        /* 0x2872 */ public bool UnlockAllTitles;
        [NMS(Index = 81)]
        /* 0x2873 */ public bool UnlockAllTwitchRewards;
        [NMS(Index = 400)]
        /* 0x2874 */ public bool UnlockAllWords;
        [NMS(Index = 128)]
        /* 0x2875 */ public bool UseBuildings;
        [NMS(Index = 123)]
        /* 0x2876 */ public bool UseClouds;
        [NMS(Index = 129)]
        /* 0x2877 */ public bool UseCreatures;
        [NMS(Index = 130)]
        /* 0x2878 */ public bool UseElevation;
        [NMS(Index = 33)]
        /* 0x2879 */ public bool UseGunImpactEffect;
        [NMS(Index = 169)]
        /* 0x287A */ public bool UseHighlightedOptionStyle;
        [NMS(Index = 126)]
        /* 0x287B */ public bool UseInstances;
        [NMS(Index = 132)]
        /* 0x287C */ public bool UseLegacyBuildingTable;
        [NMS(Index = 131)]
        /* 0x287D */ public bool UseLegacyFreighters;
        [NMS(Index = 127)]
        /* 0x287E */ public bool UseObjects;
        [NMS(Index = 274)]
        /* 0x287F */ public bool UsePadOnUnfocusedWindow;
        [NMS(Index = 121)]
        /* 0x2880 */ public bool UseParticles;
        [NMS(Index = 293)]
        /* 0x2881 */ public bool UseProcTextureDebugger;
        [NMS(Index = 32)]
        /* 0x2882 */ public bool UseScreenEffects;
        [NMS(Index = 410)]
        /* 0x2883 */ public bool UseSeasonTransferInventoryConfigOverride;
        [NMS(Index = 125)]
        /* 0x2884 */ public bool UseTerrain;
        [NMS(Index = 122)]
        /* 0x2885 */ public bool UseVolumetrics;
        [NMS(Index = 15)]
        /* 0x2886 */ public bool VideoCaptureMode;
    }
}

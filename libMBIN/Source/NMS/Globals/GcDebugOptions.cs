using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x885C833DC6B937AA, NameHash = 0xAA861200)]
    public class GcDebugOptions : NMSTemplate
    {
        [NMS(Index = 459)]
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        [NMS(Index = 221)]
        /* 0x0030 */ public GcFilename CrashDumpPath;
        [NMS(Index = 456)]
        /* 0x0040 */ public NMSString0x10 CreateSeasonContextMaskIdOverride;
        [NMS(Index = 339)]
        /* 0x0050 */ public GcFilename CursorTexture;
        [NMS(Index = 114)]
        /* 0x0060 */ public GcFilename CutScene;
        [NMS(Index = 337)]
        /* 0x0070 */ public GcFilename DebugFont;
        [NMS(Index = 338)]
        /* 0x0080 */ public GcFilename DebugFontTexture;
        [NMS(Index = 115)]
        /* 0x0090 */ public GcFilename DebugScene;
        [NMS(Index = 375)]
        /* 0x00A0 */ public NMSString0x10 DefaultAirCreatureTable;
        [NMS(Index = 377)]
        /* 0x00B0 */ public NMSString0x10 DefaultCaveCreatureTable;
        [NMS(Index = 374)]
        /* 0x00C0 */ public NMSString0x10 DefaultGroundCreatureTable;
        [NMS(Index = 192)]
        /* 0x00D0 */ public GcFilename DefaultSaveData;
        [NMS(Index = 376)]
        /* 0x00E0 */ public NMSString0x10 DefaultWaterCreatureTable;
        [NMS(Index = 465)]
        /* 0x00F0 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        [NMS(Index = 191)]
        /* 0x0100 */ public List<NMSString0x20> LocTableList;
        [NMS(Index = 340)]
        /* 0x0110 */ public GcFilename PauseTexture;
        [NMS(Index = 278)]
        /* 0x0120 */ public GcFilename PipelineFile;
        [NMS(Index = 280)]
        /* 0x0130 */ public GcFilename PipelineFileEditor;
        [NMS(Index = 279)]
        /* 0x0140 */ public GcFilename PipelineFileFrontend;
        [NMS(Index = 341)]
        /* 0x0150 */ public GcFilename PlayTexture;
        [NMS(Index = 189)]
        /* 0x0160 */ public GcFilename RealityPresetFile;
        [NMS(Index = 343)]
        /* 0x0170 */ public GcFilename RenderToTexture;
        [NMS(Index = 112)]
        /* 0x0180 */ public GcFilename SceneSettings;
        [NMS(Index = 342)]
        /* 0x0190 */ public GcFilename StepTexture;
        [NMS(Index = 457)]
        /* 0x01A0 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        [NMS(Index = 219)]
        /* 0x01B0 */ public ulong ForceTimeToEpoch;
        [NMS(Index = 105)]
        /* 0x01B8 */ public ulong ForceUniverseAddressFromSeed;
        [NMS(Index = 3)]
        /* 0x01C0 */ public ulong OverrideAbandonedFreighterSeed;
        [NMS(Index = 308)]
        /* 0x01C8 */ public ulong OverrideMatchmakingVersion;
        [NMS(Index = 440)]
        /* 0x01D0 */ public TkGlobals ToolkitGlobals;
        [NMS(Index = 203, MxmlName = "3dTextDistance")]
        /* 0x06F0 */ public float _3dTextDistance;
        [NMS(Index = 204, MxmlName = "3dTextMinScale")]
        /* 0x06F4 */ public float _3dTextMinScale;
        [NMS(Index = 431)]
        /* 0x06F8 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        [NMS(Index = 426)]
        /* 0x06FC */ public float BaseDownloadTimeout;
        [NMS(Index = 438)]
        /* 0x0700 */ public uint BasePayloadMultiplier;
        [NMS(Index = 10)]
        /* 0x0704 */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        [NMS(Index = 122)]
        /* 0x0708 */ public BootLoadDelayEnum BootLoadDelay;
        [NMS(Index = 198)]
        /* 0x070C */ public float BootLogoFadeRate;
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
        [NMS(Index = 110)]
        /* 0x0710 */ public BootModeEnum BootMode;
        [NMS(Index = 182)]
        /* 0x0714 */ public TkLanguages DebugLanguage;
        [NMS(Index = 229)]
        /* 0x0718 */ public float DebugMenuAlpha;
        [NMS(Index = 231)]
        /* 0x071C */ public float DebugTextLineHeight;
        [NMS(Index = 230)]
        /* 0x0720 */ public float DebugTextSize;
        [NMS(Index = 330)]
        /* 0x0724 */ public int DebugTextureSize;
        [NMS(Index = 301)]
        /* 0x0728 */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Index = 388)]
        /* 0x072C */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        [NMS(Index = 406)]
        /* 0x0730 */ public int ForceAsteroidSystemIndex;
        [NMS(Index = 364)]
        /* 0x0734 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        [NMS(Index = 363)]
        /* 0x0738 */ public GcBiomeType ForceBiomeTo;
        [NMS(Index = 369)]
        /* 0x073C */ public GcAlienRace ForceBuildingRaceTo;
        [NMS(Index = 378)]
        /* 0x0740 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        [NMS(Index = 399)]
        /* 0x0744 */ public int ForceGrassColourIndex;
        [NMS(Index = 126)]
        /* 0x0748 */ public float ForceInitialTimeOfDay;
        [NMS(Index = 177)]
        /* 0x074C */ public int ForceInteractionIndex;
        [NMS(Index = 185)]
        /* 0x0750 */ public GcAlienRace ForceInteractionRaceTo;
        [NMS(Index = 371)]
        /* 0x0754 */ public GcPlanetLife ForceLifeLevelTo;
        [NMS(Index = 178)]
        /* 0x0758 */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        [NMS(Index = 367)]
        /* 0x075C */ public GcScreenFilters ForceScreenFilterTo;
        [NMS(Index = 391)]
        /* 0x0760 */ public float ForceSeaLevel;
        [NMS(Index = 394)]
        /* 0x0764 */ public int ForceSkyColourIndex;
        [NMS(Index = 397)]
        /* 0x0768 */ public uint ForceSkyColourSeed;
        [NMS(Index = 38)]
        /* 0x076C */ public GcSpaceBattleType ForceSpaceBattleType;
        [NMS(Index = 395)]
        /* 0x0770 */ public int ForceSpaceSkyColourIndex;
        [NMS(Index = 361)]
        /* 0x0774 */ public GcGalaxyStarTypes ForceStarTypeTo;
        [NMS(Index = 128)]
        /* 0x0778 */ public float ForceSunAngle;
        [NMS(Index = 379)]
        /* 0x077C */ public GcPlanetLife ForceTerrainSettings;
        [NMS(Index = 381)]
        /* 0x0780 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        [NMS(Index = 125)]
        /* 0x0784 */ public float ForceTimeOfDay;
        [NMS(Index = 398)]
        /* 0x0788 */ public int ForceWaterColourIndex;
        [NMS(Index = 393)]
        /* 0x078C */ public TkWaterCondition ForceWaterConditionTo;
        [NMS(Index = 390)]
        /* 0x0790 */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        [NMS(Index = 109)]
        /* 0x0794 */ public GameStateModeEnum GameStateMode;
        [NMS(Index = 415)]
        /* 0x0798 */ public float GenerateCostAngle;
        [NMS(Index = 414)]
        /* 0x079C */ public float GenerateCostDistance;
        [NMS(Index = 416)]
        /* 0x07A0 */ public float GenerateCostLOD;
        [NMS(Index = 417)]
        /* 0x07A4 */ public float GenerateCostWait;
        [NMS(Index = 412)]
        /* 0x07A8 */ public int GenerateFarLodBuildingDist;
        [NMS(Index = 328)]
        /* 0x07AC */ public int MaxNumDebugMessages;
        [NMS(Index = 429)]
        /* 0x07B0 */ public int MoveBaseIndex;
        [NMS(Index = 452)]
        /* 0x07B4 */ public int MultipleFingersSamePressFrameDelta;
        [NMS(Index = 12)]
        /* 0x07B8 */ public GcGameMode NewSaveGameMode;
        [NMS(Index = 322)]
        /* 0x07BC */ public int OverrideCommunityMissionNumber;
        [NMS(Index = 318)]
        /* 0x07C0 */ public int OverrideServerSeasonEndTime;
        [NMS(Index = 317)]
        /* 0x07C4 */ public int OverrideServerSeasonNumber;
        [NMS(Index = 455)]
        /* 0x07C8 */ public float PanDeadzone;
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
        [NMS(Index = 111)]
        /* 0x07CC */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Index = 333)]
        /* 0x07D0 */ public int ProceduralModelBatchSize;
        [NMS(Index = 334)]
        /* 0x07D4 */ public int ProceduralModelFilterMatchretryCount;
        [NMS(Index = 332)]
        /* 0x07D8 */ public int ProceduralModelsShown;
        [NMS(Index = 336)]
        /* 0x07DC */ public int ProceduralModelsThumbnailSize;
        [NMS(Index = 433)]
        /* 0x07E0 */ public int ProfilerPartIndexPhase;
        [NMS(Index = 434)]
        /* 0x07E4 */ public int ProfilerPartIndexStride;
        [NMS(Index = 435)]
        /* 0x07E8 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        [NMS(Index = 296)]
        /* 0x07EC */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        [NMS(Index = 186)]
        /* 0x07F0 */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        [NMS(Index = 205)]
        /* 0x07F4 */ public RecordSettingEnum RecordSetting;
        [NMS(Index = 218)]
        /* 0x07F8 */ public int RecurrenceTimeOffset;
        [NMS(Index = 451)]
        /* 0x07FC */ public int ScreenshotForUploadHeight;
        [NMS(Index = 450)]
        /* 0x0800 */ public int ScreenshotForUploadWidth;
        // size: 0x9
        public enum ServerEnvEnum : uint {
            Default,
            dev,
            qa,
            prodqa,
            prod,
            custom,
            pentest,
            merged,
            local,
        }
        [NMS(Index = 298)]
        /* 0x0804 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        [NMS(Index = 118)]
        /* 0x0808 */ public ShaderPreloadEnum ShaderPreload;
        [NMS(Index = 241)]
        /* 0x080C */ public int ShowSpecificGraph;
        [NMS(Index = 257)]
        /* 0x0810 */ public int SmokeTestConfigCaptureCycles;
        [NMS(Index = 258)]
        /* 0x0814 */ public float SmokeTestConfigCaptureDurationInSeconds;
        [NMS(Index = 259)]
        /* 0x0818 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        [NMS(Index = 250)]
        /* 0x081C */ public int SmokeTestConfigPlanetPositionCount;
        [NMS(Index = 252)]
        /* 0x0820 */ public float SmokeTestConfigScenarioLength;
        [NMS(Index = 251)]
        /* 0x0824 */ public float SmokeTestConfigScenarioPreambleLength;
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
        [NMS(Index = 247)]
        /* 0x0828 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0xB
        public enum SmokeTestScenarioEnum : uint {
            None,
            TerrainSnapShotFromAltitude,
            BelowCloudLayerSnapShot,
            Flying,
            UltraBiomeSnapShot,
            Walking,
            LeakDetector,
            WalkingSnapshot,
            ModelLoading,
            SettlementSnapshot,
            BasePartShaderPreloadList,
        }
        [NMS(Index = 248)]
        /* 0x082C */ public SmokeTestScenarioEnum SmokeTestScenario;
        [NMS(Index = 263)]
        /* 0x0830 */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        [NMS(Index = 117)]
        /* 0x0834 */ public SolarSystemBootEnum SolarSystemBoot;
        [NMS(Index = 101)]
        /* 0x0838 */ public float SprintMultiplier;
        [NMS(Index = 283)]
        /* 0x083C */ public float SunLightScaleGgx;
        [NMS(Index = 453)]
        /* 0x0840 */ public int SwipeDetectionMaxFrames;
        [NMS(Index = 454)]
        /* 0x0844 */ public float SwipeDetectionNormalizedTravelThreshold;
        [NMS(Index = 326)]
        /* 0x0848 */ public int SynergyPort;
        // size: 0x3
        public enum UseBanksEnum : uint {
            False,
            True,
            Default,
        }
        [NMS(Index = 212)]
        /* 0x084C */ public UseBanksEnum UseBanks;
        [NMS(Index = 200)]
        /* 0x0850 */ public float WeaponScale3P;
        [NMS(Index = 190)]
        /* 0x0854 */ public ushort RealityGenerationIteration;
        [NMS(Index = 304)]
        /* 0x0856 */ public NMSString0x800 AutoJoinUserNames;
        [NMS(Index = 80)]
        /* 0x1056 */ public NMSString0x400 DebugTwitchRewards;
        [NMS(Index = 309)]
        /* 0x1456 */ public NMSString0x200 LoadToBase;
        [NMS(Index = 76)]
        /* 0x1656 */ public NMSString0x200 SeasonalDataOverrideFile;
        [NMS(Index = 319)]
        /* 0x1856 */ public NMSString0x100 ForceHgAccount;
        [NMS(Index = 106)]
        /* 0x1956 */ public NMSString0x100 ForcePlayerPosition;
        [NMS(Index = 103)]
        /* 0x1A56 */ public NMSString0x100 ForceUniverseAddress;
        [NMS(Index = 312)]
        /* 0x1B56 */ public NMSString0x100 GOGLogin;
        [NMS(Index = 237)]
        /* 0x1C56 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        [NMS(Index = 113)]
        /* 0x1D56 */ public NMSString0x100 WorkingDirectory;
        [NMS(Index = 299)]
        /* 0x1E56 */ public NMSString0x80 AuthBaseUrl;
        [NMS(Index = 297)]
        /* 0x1ED6 */ public NMSString0x80 ProxyURI;
        [NMS(Index = 320)]
        /* 0x1F56 */ public NMSString0x40 ForceBaseDownloadUser;
        [NMS(Index = 443)]
        /* 0x1F96 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        [NMS(Index = 442)]
        /* 0x1FD6 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        [NMS(Index = 449)]
        /* 0x2016 */ public NMSString0x40 ScreenshotForUploadName;
        [NMS(Index = 183)]
        /* 0x2056 */ public NMSString0x20 AllowedLanguagesFile;
        [NMS(Index = 430)]
        /* 0x2076 */ public NMSString0x20 AutomaticPartSpawnID;
        [NMS(Index = 222)]
        /* 0x2096 */ public NMSString0x20 CrashDumpIdentifier;
        [NMS(Index = 211)]
        /* 0x20B6 */ public NMSString0x20 SaveTestingCommand;
        [NMS(Index = 265)]
        /* 0x20D6 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        [NMS(Index = 266)]
        /* 0x20F6 */ public NMSString0x20 SmokeTestRunFolder;
        [NMS(Index = 325)]
        /* 0x2116 */ public NMSString0x20 SynergyServer;
        [NMS(Index = 462)]
        /* 0x2136 */ public bool ActiveMissionsIgnoreStartCancelConditions;
        [NMS(Index = 132)]
        /* 0x2137 */ public bool AllowGalaxyMapRequests;
        [NMS(Index = 425)]
        /* 0x2138 */ public bool AllowGlobalPartSnapping;
        [NMS(Index = 354)]
        /* 0x2139 */ public bool AllowNGuiVR;
        [NMS(Index = 441)]
        /* 0x213A */ public bool AllowOverrideSettlementOwnership;
        [NMS(Index = 81)]
        /* 0x213B */ public bool AllowPause;
        [NMS(Index = 97)]
        /* 0x213C */ public bool AllowPetBattlerPvEOnPvPTable;
        [NMS(Index = 153)]
        /* 0x213D */ public bool AllowRobotBehaviors;
        [NMS(Index = 1)]
        /* 0x213E */ public bool AllowSavingOnAbandonedFreighters;
        [NMS(Index = 160)]
        /* 0x213F */ public bool AllSeasonMilestonesShowComplete;
        [NMS(Index = 82)]
        /* 0x2140 */ public bool AllSettlementsAreCompleted;
        [NMS(Index = 67)]
        /* 0x2141 */ public bool AlternateControls;
        [NMS(Index = 75)]
        /* 0x2142 */ public bool AlwaysAllowFreighterInventoryAccess;
        [NMS(Index = 73)]
        /* 0x2143 */ public bool AlwaysAllowShipOperations;
        [NMS(Index = 150)]
        /* 0x2144 */ public bool AlwaysAllowSpookFiends;
        [NMS(Index = 74)]
        /* 0x2145 */ public bool AlwaysAllowVehicleOperations;
        [NMS(Index = 18)]
        /* 0x2146 */ public bool AlwaysHaveFocus;
        [NMS(Index = 293)]
        /* 0x2147 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        [NMS(Index = 305)]
        /* 0x2148 */ public bool AlwaysSaveGameAsClient;
        [NMS(Index = 239)]
        /* 0x2149 */ public bool AlwaysShowSaveIds;
        [NMS(Index = 68)]
        /* 0x214A */ public bool AlwaysShowURI;
        [NMS(Index = 37)]
        /* 0x214B */ public bool AlwaysSpaceBattle;
        [NMS(Index = 463)]
        /* 0x214C */ public bool AssertIfDiploFound;
        [NMS(Index = 311)]
        /* 0x214D */ public bool AutoJoinRandomGames;
        [NMS(Index = 303)]
        /* 0x214E */ public bool AutoJoinUserEnabled;
        [NMS(Index = 432)]
        /* 0x214F */ public bool AutomaticPartSpawnInactive;
        [NMS(Index = 437)]
        /* 0x2150 */ public bool BaseAdmin;
        [NMS(Index = 86)]
        /* 0x2151 */ public bool BlockCommunicatorSignals;
        [NMS(Index = 444)]
        /* 0x2152 */ public bool BlockSettlementsNetwork;
        [NMS(Index = 39)]
        /* 0x2153 */ public bool BlockSpaceBattle;
        [NMS(Index = 348)]
        /* 0x2154 */ public bool BodyTurning;
        [NMS(Index = 11)]
        /* 0x2155 */ public bool BootDirectlyIntoLastSave;
        [NMS(Index = 199)]
        /* 0x2156 */ public bool BootMusic;
        [NMS(Index = 29)]
        /* 0x2157 */ public bool CanLeaveDialogs;
        [NMS(Index = 300)]
        /* 0x2158 */ public bool CertificateSecurityBypass;
        [NMS(Index = 209)]
        /* 0x2159 */ public bool CheckForMissingLocStrings;
        [NMS(Index = 54)]
        /* 0x215A */ public bool ClothForceAsyncSimulationOff;
        [NMS(Index = 55)]
        /* 0x215B */ public bool ClothForceAsyncSimulationOn;
        [NMS(Index = 53)]
        /* 0x215C */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        [NMS(Index = 50)]
        /* 0x215D */ public bool ClothForcePositionExtrapolationBackOn;
        [NMS(Index = 48)]
        /* 0x215E */ public bool ClothForcePositionExtrapolationOff;
        [NMS(Index = 49)]
        /* 0x215F */ public bool ClothForcePositionExtrapolationOn;
        [NMS(Index = 52)]
        /* 0x2160 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        [NMS(Index = 51)]
        /* 0x2161 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        [NMS(Index = 271)]
        /* 0x2162 */ public bool CompressTextures;
        [NMS(Index = 220)]
        /* 0x2163 */ public bool CrashDumpFull;
        [NMS(Index = 92)]
        /* 0x2164 */ public bool CrashOnF10;
        [NMS(Index = 267)]
        /* 0x2165 */ public bool CreatureChatter;
        [NMS(Index = 269)]
        /* 0x2166 */ public bool CreatureDrawVocals;
        [NMS(Index = 268)]
        /* 0x2167 */ public bool CreatureErrors;
        [NMS(Index = 439)]
        /* 0x2168 */ public bool CrossPlatformFeaturedBases;
        [NMS(Index = 419)]
        /* 0x2169 */ public bool DChecksEnabled;
        [NMS(Index = 421)]
        /* 0x216A */ public bool DChecksOutputBinary;
        [NMS(Index = 422)]
        /* 0x216B */ public bool DChecksOutputFileLine;
        [NMS(Index = 420)]
        /* 0x216C */ public bool DChecksOutputJson;
        [NMS(Index = 206)]
        /* 0x216D */ public bool DebugBuildingSpawns;
        [NMS(Index = 276)]
        /* 0x216E */ public bool DebugDepthReprojection;
        [NMS(Index = 175)]
        /* 0x216F */ public bool DebugDrawPlayerInteract;
        [NMS(Index = 20)]
        /* 0x2170 */ public bool DebugGalaxyMapInQuickMenu;
        [NMS(Index = 272)]
        /* 0x2171 */ public bool DebugIBL;
        [NMS(Index = 210)]
        /* 0x2172 */ public bool DebugNetworkLocks;
        [NMS(Index = 187)]
        /* 0x2173 */ public bool DebugPersistentInteractions;
        [NMS(Index = 275)]
        /* 0x2174 */ public bool DebugRenderSpaceOffset;
        [NMS(Index = 273)]
        /* 0x2175 */ public bool DebugSpotlights;
        [NMS(Index = 274)]
        /* 0x2176 */ public bool DebugTerrainTextures;
        [NMS(Index = 223)]
        /* 0x2177 */ public bool DebugThreatLevels;
        [NMS(Index = 413)]
        /* 0x2178 */ public bool DeferRegionBodies;
        [NMS(Index = 2)]
        /* 0x2179 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Index = 423)]
        /* 0x217A */ public bool DisableBaseBuilding;
        [NMS(Index = 424)]
        /* 0x217B */ public bool DisableBaseBuildingLimits;
        [NMS(Index = 427)]
        /* 0x217C */ public bool DisableBasePowerRequirements;
        [NMS(Index = 288)]
        /* 0x217D */ public bool DisableClouds;
        [NMS(Index = 43)]
        /* 0x217E */ public bool DisableContinuousSaving;
        [NMS(Index = 436)]
        /* 0x217F */ public bool DisableCorvetteSwapParts;
        [NMS(Index = 93)]
        /* 0x2180 */ public bool DisableCorvetteValidation;
        [NMS(Index = 170)]
        /* 0x2181 */ public bool DisableDebugControls;
        [NMS(Index = 174)]
        /* 0x2182 */ public bool DisableDiscoveryNaming;
        [NMS(Index = 217)]
        /* 0x2183 */ public bool DisableFileWatcher;
        [NMS(Index = 28)]
        /* 0x2184 */ public bool DisableHazards;
        [NMS(Index = 352)]
        /* 0x2185 */ public bool DisableHeadConstraints;
        [NMS(Index = 44)]
        /* 0x2186 */ public bool DisableInvalidSaveVersion;
        [NMS(Index = 351)]
        /* 0x2187 */ public bool DisableLeftHand;
        [NMS(Index = 407)]
        /* 0x2188 */ public bool DisableLimits;
        [NMS(Index = 464)]
        /* 0x2189 */ public bool DisableMissionShop;
        [NMS(Index = 306)]
        /* 0x218A */ public bool DisableMonumentDownloads;
        [NMS(Index = 64, MxmlName = "DisableNPCHiddenUntilScanned ")]
        /* 0x218B */ public bool DisableNPCHiddenUntilScanned;
        [NMS(Index = 63)]
        /* 0x218C */ public bool DisableNPCs;
        [NMS(Index = 446)]
        /* 0x218D */ public bool DisablePartialStories;
        [NMS(Index = 99)]
        /* 0x218E */ public bool DisablePetBattlerSpectatorWelcomeMessageForSwitch2;
        [NMS(Index = 216)]
        /* 0x218F */ public bool DisableProfanityFilter;
        [NMS(Index = 41)]
        /* 0x2190 */ public bool DisableSaveSlotSorting;
        [NMS(Index = 321)]
        /* 0x2191 */ public bool DisableSaveUploadRateLimits;
        [NMS(Index = 42)]
        /* 0x2192 */ public bool DisableSaving;
        [NMS(Index = 83)]
        /* 0x2193 */ public bool DisableSettlements;
        [NMS(Index = 277)]
        /* 0x2194 */ public bool DisableShadowSwitching;
        [NMS(Index = 194)]
        /* 0x2195 */ public bool DisableShipSaveDataRecovery;
        [NMS(Index = 302)]
        /* 0x2196 */ public bool DisableSpaceStationSpawnOnJoin;
        [NMS(Index = 45)]
        /* 0x2197 */ public bool DisableStorms;
        [NMS(Index = 19)]
        /* 0x2198 */ public bool DisableVibration;
        [NMS(Index = 184)]
        /* 0x2199 */ public bool DoAlienLanguage;
        [NMS(Index = 270)]
        /* 0x219A */ public bool DrawCreaturesInRoutines;
        [NMS(Index = 224)]
        /* 0x219B */ public bool DumpManifestContents;
        [NMS(Index = 445)]
        /* 0x219C */ public bool EnableAccessibleUI;
        [NMS(Index = 163)]
        /* 0x219D */ public bool EnableBaseBuildingExpandables;
        [NMS(Index = 428)]
        /* 0x219E */ public bool EnableBaseMovingOption;
        [NMS(Index = 139)]
        /* 0x219F */ public bool EnableCloudAnimation;
        [NMS(Index = 284)]
        /* 0x21A0 */ public bool EnableComputePost;
        [NMS(Index = 168)]
        /* 0x21A1 */ public bool EnableCustomSolarSystemMapMaterials;
        [NMS(Index = 149)]
        /* 0x21A2 */ public bool EnableDayNightCycle;
        [NMS(Index = 116)]
        /* 0x21A3 */ public bool EnableDebugSceneAutoSave;
        [NMS(Index = 130)]
        /* 0x21A4 */ public bool EnableFrontendPreload;
        [NMS(Index = 161)]
        /* 0x21A5 */ public bool EnableGalaxyRecolouring;
        [NMS(Index = 164)]
        /* 0x21A6 */ public bool EnableGameTables;
        [NMS(Index = 282)]
        /* 0x21A7 */ public bool EnableGgx;
        [NMS(Index = 85)]
        /* 0x21A8 */ public bool EnableMemoryPoolAllocPrint;
        [NMS(Index = 95)]
        /* 0x21A9 */ public bool EnablePetBattlerRandomPets;
        [NMS(Index = 96)]
        /* 0x21AA */ public bool EnablePetBattlerTurnTimeoutInPvE;
        [NMS(Index = 353)]
        /* 0x21AB */ public bool EnablePhotomodeVR;
        [NMS(Index = 166)]
        /* 0x21AC */ public bool EnableSolarSystemMap;
        [NMS(Index = 324)]
        /* 0x21AD */ public bool EnableSynergy;
        [NMS(Index = 88)]
        /* 0x21AE */ public bool EnableTouchScreenDebugging;
        [NMS(Index = 94)]
        /* 0x21AF */ public bool EnforceCorvetteComplexityLimit;
        [NMS(Index = 24)]
        /* 0x21B0 */ public bool EverythingIsFree;
        [NMS(Index = 25)]
        /* 0x21B1 */ public bool EverythingIsKnown;
        [NMS(Index = 26)]
        /* 0x21B2 */ public bool EverythingIsStar;
        [NMS(Index = 314)]
        /* 0x21B3 */ public bool FakeHandsInMultiplayer;
        [NMS(Index = 40)]
        /* 0x21B4 */ public bool FastAndFrequentFleetInterventions;
        [NMS(Index = 9)]
        /* 0x21B5 */ public bool FastLoad;
        [NMS(Index = 171)]
        /* 0x21B6 */ public bool FixedFramerate;
        [NMS(Index = 202)]
        /* 0x21B7 */ public bool FleetDirectorAutoMode;
        [NMS(Index = 461)]
        /* 0x21B8 */ public bool ForceAllExhibitsToBeEditable;
        [NMS(Index = 197)]
        /* 0x21B9 */ public bool ForceBasicLoadScreen;
        [NMS(Index = 386)]
        /* 0x21BA */ public bool ForceBinaryStar;
        [NMS(Index = 362)]
        /* 0x21BB */ public bool ForceBiome;
        [NMS(Index = 365)]
        /* 0x21BC */ public bool ForceBiomeMaintainsTerrain;
        [NMS(Index = 66)]
        /* 0x21BD */ public bool ForceBuildersAlwaysKnown;
        [NMS(Index = 368)]
        /* 0x21BE */ public bool ForceBuildingRace;
        [NMS(Index = 358)]
        /* 0x21BF */ public bool ForceCorruptSentinels;
        [NMS(Index = 372)]
        /* 0x21C0 */ public bool ForceCreatureLifeLevel;
        [NMS(Index = 373)]
        /* 0x21C1 */ public bool ForceDefaultCreatureFile;
        [NMS(Index = 47)]
        /* 0x21C2 */ public bool ForceDisableClothComponent;
        [NMS(Index = 60)]
        /* 0x21C3 */ public bool ForceDisableNonPlayerRagdollComponents;
        [NMS(Index = 59)]
        /* 0x21C4 */ public bool ForceDisableRagdollComponent;
        [NMS(Index = 62)]
        /* 0x21C5 */ public bool ForceDisableSeparatePhysicsWorlds;
        [NMS(Index = 61)]
        /* 0x21C6 */ public bool ForceDisableSplitIkOptimisation;
        [NMS(Index = 57)]
        /* 0x21C7 */ public bool ForceDisableSpringComponent;
        [NMS(Index = 98)]
        /* 0x21C8 */ public bool ForceDiscoverAllSpacePoi;
        [NMS(Index = 46)]
        /* 0x21C9 */ public bool ForceEnableClothComponent;
        [NMS(Index = 58)]
        /* 0x21CA */ public bool ForceEnableRagdollComponent;
        [NMS(Index = 56)]
        /* 0x21CB */ public bool ForceEnableSpringComponent;
        [NMS(Index = 357)]
        /* 0x21CC */ public bool ForceExtremeSentinels;
        [NMS(Index = 356)]
        /* 0x21CD */ public bool ForceExtremeWeather;
        [NMS(Index = 124)]
        /* 0x21CE */ public bool ForceFrontendPersonalityTest;
        [NMS(Index = 91)]
        /* 0x21CF */ public bool ForceFullFeatureMode;
        [NMS(Index = 384)]
        /* 0x21D0 */ public bool ForceGasGiantSystem;
        [NMS(Index = 383)]
        /* 0x21D1 */ public bool ForceGiantSystem;
        [NMS(Index = 107)]
        /* 0x21D2 */ public bool ForceInitialShip;
        [NMS(Index = 108)]
        /* 0x21D3 */ public bool ForceInitialWeapon;
        [NMS(Index = 176)]
        /* 0x21D4 */ public bool ForceInteractionToSettings;
        [NMS(Index = 370)]
        /* 0x21D5 */ public bool ForceLifeLevel;
        [NMS(Index = 360)]
        /* 0x21D6 */ public bool ForceLoadAllWeather;
        [NMS(Index = 159)]
        /* 0x21D7 */ public bool ForceNexusInQuickMenu;
        [NMS(Index = 382)]
        /* 0x21D8 */ public bool ForcePirateSystem;
        [NMS(Index = 402)]
        /* 0x21D9 */ public bool ForcePlanetsToHaveNoCaves;
        [NMS(Index = 403)]
        /* 0x21DA */ public bool ForcePlanetsToHaveNoNoiseLayers;
        [NMS(Index = 404)]
        /* 0x21DB */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        [NMS(Index = 401)]
        /* 0x21DC */ public bool ForcePlanetsToHaveNoWater;
        [NMS(Index = 389)]
        /* 0x21DD */ public bool ForcePlanetsToHaveWater;
        [NMS(Index = 385)]
        /* 0x21DE */ public bool ForcePrimeTerrain;
        [NMS(Index = 196)]
        /* 0x21DF */ public bool ForcePurpleSystemsToAlwaysBirth;
        [NMS(Index = 195)]
        /* 0x21E0 */ public bool ForcePurpleSystemsVisibleOnLoad;
        [NMS(Index = 405)]
        /* 0x21E1 */ public bool ForceRareAsteroidSystem;
        [NMS(Index = 466)]
        /* 0x21E2 */ public bool ForceScanEventsToGoPrime;
        [NMS(Index = 467)]
        /* 0x21E3 */ public bool ForceScanEventsToSpecificGrassColour;
        [NMS(Index = 355)]
        /* 0x21E4 */ public bool ForceScrapWorlds;
        [NMS(Index = 366)]
        /* 0x21E5 */ public bool ForceScreenFilter;
        [NMS(Index = 315)]
        /* 0x21E6 */ public bool ForceSmallLobby;
        [NMS(Index = 396)]
        /* 0x21E7 */ public bool ForceSpaceSkyColourRare;
        [NMS(Index = 359)]
        /* 0x21E8 */ public bool ForceStarType;
        [NMS(Index = 127)]
        /* 0x21E9 */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Index = 387)]
        /* 0x21EA */ public bool ForceTernaryStar;
        [NMS(Index = 380)]
        /* 0x21EB */ public bool ForceTerrainType;
        [NMS(Index = 90)]
        /* 0x21EC */ public bool ForceTgaDlc;
        [NMS(Index = 316)]
        /* 0x21ED */ public bool ForceTinyLobby;
        [NMS(Index = 34)]
        /* 0x21EE */ public bool ForceTranslateAllAlienText;
        [NMS(Index = 104)]
        /* 0x21EF */ public bool ForceUniverseAddressFromChangelist;
        [NMS(Index = 21)]
        /* 0x21F0 */ public bool ForceUnlockSolarSystemMap;
        [NMS(Index = 392)]
        /* 0x21F1 */ public bool ForceWaterCondition;
        [NMS(Index = 193)]
        /* 0x21F2 */ public bool FormatDownloadStorageAreaOnBoot;
        [NMS(Index = 15)]
        /* 0x21F3 */ public bool GodMode;
        [NMS(Index = 242)]
        /* 0x21F4 */ public bool GraphCommandBuffer;
        [NMS(Index = 244)]
        /* 0x21F5 */ public bool GraphFPS;
        [NMS(Index = 243)]
        /* 0x21F6 */ public bool GraphGeneration;
        [NMS(Index = 245)]
        /* 0x21F7 */ public bool GraphTexStreaming;
        [NMS(Index = 213)]
        /* 0x21F8 */ public bool HangOnCrash;
        [NMS(Index = 344)]
        /* 0x21F9 */ public bool HmdFrameShiftEnabled;
        [NMS(Index = 347)]
        /* 0x21FA */ public bool HmdShowEyeAimTarget;
        [NMS(Index = 346)]
        /* 0x21FB */ public bool HmdShowTrackedEyePos;
        [NMS(Index = 345)]
        /* 0x21FC */ public bool HmdUseSolidGuiPointer;
        [NMS(Index = 214)]
        /* 0x21FD */ public bool HotReloadModGlobals;
        [NMS(Index = 35)]
        /* 0x21FE */ public bool IgnoreFreighterSpawnWarpRequirement;
        [NMS(Index = 468)]
        /* 0x21FF */ public bool IgnoreMissionRank;
        [NMS(Index = 162)]
        /* 0x2200 */ public bool IgnoreSteamDev;
        [NMS(Index = 310)]
        /* 0x2201 */ public bool IgnoreTransactionTimeouts;
        [NMS(Index = 180)]
        /* 0x2202 */ public bool InfiniteInteractions;
        [NMS(Index = 27)]
        /* 0x2203 */ public bool InfiniteStamina;
        [NMS(Index = 156)]
        /* 0x2204 */ public bool InstanceCollision;
        [NMS(Index = 179)]
        /* 0x2205 */ public bool InteractionsAllwaysGivesTech;
        [NMS(Index = 411)]
        /* 0x2206 */ public bool LimitGlobalBodies;
        [NMS(Index = 410)]
        /* 0x2207 */ public bool LimitGlobalInstances;
        [NMS(Index = 409)]
        /* 0x2208 */ public bool LimitPerRegionBodies;
        [NMS(Index = 408)]
        /* 0x2209 */ public bool LimitPerRegionInstances;
        [NMS(Index = 287)]
        /* 0x220A */ public bool LoadShaderSourceIfRenderdocEnabled;
        [NMS(Index = 72)]
        /* 0x220B */ public bool LockAllTitles;
        [NMS(Index = 201)]
        /* 0x220C */ public bool LogMissingLocalisedText;
        [NMS(Index = 23)]
        /* 0x220D */ public bool MapWarpCheckIgnoreDrive;
        [NMS(Index = 22)]
        /* 0x220E */ public bool MapWarpCheckIgnoreFuel;
        [NMS(Index = 36)]
        /* 0x220F */ public bool MaximumFreighterSpawns;
        [NMS(Index = 169)]
        /* 0x2210 */ public bool MeltdownsEnabled;
        [NMS(Index = 123)]
        /* 0x2211 */ public bool MemCsv;
        [NMS(Index = 469)]
        /* 0x2212 */ public bool MissionMessageLoggingEnabled;
        [NMS(Index = 470)]
        /* 0x2213 */ public bool MissionNGUIShowsConditionResults;
        [NMS(Index = 471)]
        /* 0x2214 */ public bool MissionNGUIShowsTableNames;
        [NMS(Index = 472)]
        /* 0x2215 */ public bool MissionSurveyEnabled;
        [NMS(Index = 400)]
        /* 0x2216 */ public bool ModifyPlanetsInInitialSystems;
        [NMS(Index = 473)]
        /* 0x2217 */ public bool MPMissions;
        [NMS(Index = 474)]
        /* 0x2218 */ public bool MPMissionsAlwaysEPIC;
        [NMS(Index = 158)]
        /* 0x2219 */ public bool MultiplePlayerFreightersInASystem;
        [NMS(Index = 167)]
        /* 0x221A */ public bool NexusBots;
        [NMS(Index = 84)]
        /* 0x221B */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        [NMS(Index = 329)]
        /* 0x221C */ public bool PreloadToolbox;
        [NMS(Index = 232)]
        /* 0x221D */ public bool PrintAvgFrameTimes;
        [NMS(Index = 335)]
        /* 0x221E */ public bool ProceduralModelsDeterministicSequence;
        [NMS(Index = 285)]
        /* 0x221F */ public bool Proto2DevKit;
        [NMS(Index = 313)]
        /* 0x2220 */ public bool RecordNetworkStatsOnBoot;
        [NMS(Index = 32)]
        /* 0x2221 */ public bool RenderCreatureDetails;
        [NMS(Index = 173)]
        /* 0x2222 */ public bool RenderHud;
        [NMS(Index = 281)]
        /* 0x2223 */ public bool RenderLowFramerate;
        [NMS(Index = 129)]
        /* 0x2224 */ public bool ResetForcedSaveSlotOnLoad;
        [NMS(Index = 102)]
        /* 0x2225 */ public bool ResetToSupportedResolution;
        [NMS(Index = 70)]
        /* 0x2226 */ public bool RevealAllTitles;
        [NMS(Index = 215)]
        /* 0x2227 */ public bool SaveOutModdedMetadata;
        [NMS(Index = 460)]
        /* 0x2228 */ public bool ScratchpadPlanetEnvironment;
        [NMS(Index = 172)]
        /* 0x2229 */ public bool ScreenshotMode;
        [NMS(Index = 121)]
        /* 0x222A */ public bool ShaderCaching;
        [NMS(Index = 119)]
        /* 0x222B */ public bool ShaderPreloadListExport;
        [NMS(Index = 120)]
        /* 0x222C */ public bool ShaderPreloadListImport;
        [NMS(Index = 65)]
        /* 0x222D */ public bool ShipSalvageGivesAllParts;
        [NMS(Index = 295)]
        /* 0x222E */ public bool ShowAtlasErrorOSD;
        [NMS(Index = 225)]
        /* 0x222F */ public bool ShowDebugMessages;
        [NMS(Index = 228)]
        /* 0x2230 */ public bool ShowDynamicResScale;
        [NMS(Index = 327)]
        /* 0x2231 */ public bool ShowEditorPlacementPreview;
        [NMS(Index = 69)]
        /* 0x2232 */ public bool ShowFireteamMembersUA;
        [NMS(Index = 226)]
        /* 0x2233 */ public bool ShowFramerate;
        [NMS(Index = 234)]
        /* 0x2234 */ public bool ShowGPUMemory;
        [NMS(Index = 227)]
        /* 0x2235 */ public bool ShowGPURenderTime;
        [NMS(Index = 240)]
        /* 0x2236 */ public bool ShowGraphs;
        [NMS(Index = 349)]
        /* 0x2237 */ public bool ShowHmdHandControllers;
        [NMS(Index = 208)]
        /* 0x2238 */ public bool ShowLongestStrings;
        [NMS(Index = 235)]
        /* 0x2239 */ public bool ShowMempoolOverlay;
        [NMS(Index = 475)]
        /* 0x223A */ public bool ShowMissionIdInTitle;
        [NMS(Index = 236)]
        /* 0x223B */ public bool ShowMouseSmoothing;
        [NMS(Index = 233)]
        /* 0x223C */ public bool ShowPositionDebug;
        [NMS(Index = 238)]
        /* 0x223D */ public bool ShowRenderStatsDisplay;
        [NMS(Index = 350)]
        /* 0x223E */ public bool ShowTeleportEffectLocally;
        [NMS(Index = 286)]
        /* 0x223F */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 294)]
        /* 0x2240 */ public bool SimulateNoNetworkConnection;
        [NMS(Index = 0)]
        /* 0x2241 */ public bool SkipAbandonedFreighterUnlocking;
        [NMS(Index = 6)]
        /* 0x2242 */ public bool SkipIntro;
        [NMS(Index = 7)]
        /* 0x2243 */ public bool SkipLogos;
        [NMS(Index = 13)]
        /* 0x2244 */ public bool SkipPlanetDiscoverOnBoot;
        [NMS(Index = 33)]
        /* 0x2245 */ public bool SkipTutorial;
        [NMS(Index = 8)]
        /* 0x2246 */ public bool SkipUITimers;
        [NMS(Index = 254)]
        /* 0x2247 */ public bool SmokeTestCameraFly;
        [NMS(Index = 260)]
        /* 0x2248 */ public bool SmokeTestConfigRandomizePlanetSeed;
        [NMS(Index = 246)]
        /* 0x2249 */ public bool SmokeTestDumpStatsMode;
        [NMS(Index = 253)]
        /* 0x224A */ public bool SmokeTestFastExit;
        [NMS(Index = 249)]
        /* 0x224B */ public bool SmokeTestLegacyOutput;
        [NMS(Index = 255)]
        /* 0x224C */ public bool SmokeTestOutputOnly;
        [NMS(Index = 264)]
        /* 0x224D */ public bool SmokeTestPostBandwidthStats;
        [NMS(Index = 256)]
        /* 0x224E */ public bool SmokeTestPureFlight;
        [NMS(Index = 262)]
        /* 0x224F */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 261)]
        /* 0x2250 */ public bool SmokeTestSmokeBotEnabled;
        [NMS(Index = 151)]
        /* 0x2251 */ public bool SpawnPirates;
        [NMS(Index = 155)]
        /* 0x2252 */ public bool SpawnPulseEncounters;
        [NMS(Index = 152)]
        /* 0x2253 */ public bool SpawnRobots;
        [NMS(Index = 154)]
        /* 0x2254 */ public bool SpawnShips;
        [NMS(Index = 157)]
        /* 0x2255 */ public bool SpecialsShop;
        [NMS(Index = 290)]
        /* 0x2256 */ public bool SpotlightsTiledOn;
        [NMS(Index = 289)]
        /* 0x2257 */ public bool SpotlightsTiledSettings;
        [NMS(Index = 292)]
        /* 0x2258 */ public bool SpotlightsTiledVisualise;
        [NMS(Index = 291)]
        /* 0x2259 */ public bool SpotlightsTiledZBins;
        [NMS(Index = 100)]
        /* 0x225A */ public bool StartAsOrb;
        [NMS(Index = 181)]
        /* 0x225B */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Index = 207)]
        /* 0x225C */ public bool StressTestLongNameDisplay;
        [NMS(Index = 17)]
        /* 0x225D */ public bool SuperKillGuns;
        [NMS(Index = 133)]
        /* 0x225E */ public bool SuppressSeasonalRewardReminders;
        [NMS(Index = 16)]
        /* 0x225F */ public bool TakeNoDamage;
        [NMS(Index = 4)]
        /* 0x2260 */ public bool ThirdPersonIsDefaultCameraForPlayer;
        [NMS(Index = 5)]
        /* 0x2261 */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        [NMS(Index = 79)]
        /* 0x2262 */ public bool UnlockAllPlatformRewards;
        [NMS(Index = 77)]
        /* 0x2263 */ public bool UnlockAllSeasonRewards;
        [NMS(Index = 447)]
        /* 0x2264 */ public bool UnlockAllStories;
        [NMS(Index = 71)]
        /* 0x2265 */ public bool UnlockAllTitles;
        [NMS(Index = 78)]
        /* 0x2266 */ public bool UnlockAllTwitchRewards;
        [NMS(Index = 448)]
        /* 0x2267 */ public bool UnlockAllWords;
        [NMS(Index = 165)]
        /* 0x2268 */ public bool UpdateMarkersJob;
        [NMS(Index = 136)]
        /* 0x2269 */ public bool UseBloom;
        [NMS(Index = 143)]
        /* 0x226A */ public bool UseBuildings;
        [NMS(Index = 137)]
        /* 0x226B */ public bool UseClouds;
        [NMS(Index = 144)]
        /* 0x226C */ public bool UseCreatures;
        [NMS(Index = 145)]
        /* 0x226D */ public bool UseElevation;
        [NMS(Index = 138)]
        /* 0x226E */ public bool UseGTAO;
        [NMS(Index = 31)]
        /* 0x226F */ public bool UseGunImpactEffect;
        [NMS(Index = 188)]
        /* 0x2270 */ public bool UseHighlightedOptionStyle;
        [NMS(Index = 89)]
        /* 0x2271 */ public bool UseImmediateModeFrontend;
        [NMS(Index = 141)]
        /* 0x2272 */ public bool UseInstances;
        [NMS(Index = 148)]
        /* 0x2273 */ public bool UseLegacyBuildingTable;
        [NMS(Index = 146)]
        /* 0x2274 */ public bool UseLegacyFreighters;
        [NMS(Index = 147)]
        /* 0x2275 */ public bool UseLegacySpaceStations;
        [NMS(Index = 87)]
        /* 0x2276 */ public bool UseMovementStickForRun;
        [NMS(Index = 142)]
        /* 0x2277 */ public bool UseObjects;
        [NMS(Index = 418)]
        /* 0x2278 */ public bool UseOldTerrainMeshing;
        [NMS(Index = 307)]
        /* 0x2279 */ public bool UsePadOnUnfocusedWindow;
        [NMS(Index = 134)]
        /* 0x227A */ public bool UseParticles;
        [NMS(Index = 331)]
        /* 0x227B */ public bool UseProcTextureDebugger;
        [NMS(Index = 131)]
        /* 0x227C */ public bool UseSceneInfoWindow;
        [NMS(Index = 30)]
        /* 0x227D */ public bool UseScreenEffects;
        [NMS(Index = 458)]
        /* 0x227E */ public bool UseSeasonTransferInventoryConfigOverride;
        [NMS(Index = 140)]
        /* 0x227F */ public bool UseTerrain;
        [NMS(Index = 135)]
        /* 0x2280 */ public bool UseVolumetrics;
        [NMS(Index = 14)]
        /* 0x2281 */ public bool VideoCaptureMode;
        [NMS(Index = 323)]
        /* 0x2282 */ public bool VisualiseNetReplicatedEntityOwnership;
    }
}

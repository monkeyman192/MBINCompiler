using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xBBF21DE00873C13C, NameHash = 0xAA861200)]
    public class GcDebugOptions : NMSTemplate
    {
        [NMS(Index = 458)]
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        [NMS(Index = 222)]
        /* 0x0030 */ public GcFilename CrashDumpPath;
        [NMS(Index = 455)]
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
        [NMS(Index = 374)]
        /* 0x00A0 */ public NMSString0x10 DefaultAirCreatureTable;
        [NMS(Index = 376)]
        /* 0x00B0 */ public NMSString0x10 DefaultCaveCreatureTable;
        [NMS(Index = 373)]
        /* 0x00C0 */ public NMSString0x10 DefaultGroundCreatureTable;
        [NMS(Index = 193)]
        /* 0x00D0 */ public GcFilename DefaultSaveData;
        [NMS(Index = 375)]
        /* 0x00E0 */ public NMSString0x10 DefaultWaterCreatureTable;
        [NMS(Index = 464)]
        /* 0x00F0 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        [NMS(Index = 192)]
        /* 0x0100 */ public List<NMSString0x20> LocTableList;
        [NMS(Index = 340)]
        /* 0x0110 */ public GcFilename PauseTexture;
        [NMS(Index = 279)]
        /* 0x0120 */ public GcFilename PipelineFile;
        [NMS(Index = 281)]
        /* 0x0130 */ public GcFilename PipelineFileEditor;
        [NMS(Index = 280)]
        /* 0x0140 */ public GcFilename PipelineFileFrontend;
        [NMS(Index = 341)]
        /* 0x0150 */ public GcFilename PlayTexture;
        [NMS(Index = 190)]
        /* 0x0160 */ public GcFilename RealityPresetFile;
        [NMS(Index = 343)]
        /* 0x0170 */ public GcFilename RenderToTexture;
        [NMS(Index = 112)]
        /* 0x0180 */ public GcFilename SceneSettings;
        [NMS(Index = 342)]
        /* 0x0190 */ public GcFilename StepTexture;
        [NMS(Index = 456)]
        /* 0x01A0 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        [NMS(Index = 220)]
        /* 0x01B0 */ public ulong ForceTimeToEpoch;
        [NMS(Index = 105)]
        /* 0x01B8 */ public ulong ForceUniverseAddressFromSeed;
        [NMS(Index = 3)]
        /* 0x01C0 */ public ulong OverrideAbandonedFreighterSeed;
        [NMS(Index = 309)]
        /* 0x01C8 */ public ulong OverrideMatchmakingVersion;
        [NMS(Index = 439)]
        /* 0x01D0 */ public TkGlobals ToolkitGlobals;
        [NMS(Index = 204, MxmlName = "3dTextDistance")]
        /* 0x06EC */ public float _3dTextDistance;
        [NMS(Index = 205, MxmlName = "3dTextMinScale")]
        /* 0x06F0 */ public float _3dTextMinScale;
        [NMS(Index = 430)]
        /* 0x06F4 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        [NMS(Index = 425)]
        /* 0x06F8 */ public float BaseDownloadTimeout;
        [NMS(Index = 437)]
        /* 0x06FC */ public uint BasePayloadMultiplier;
        [NMS(Index = 10)]
        /* 0x0700 */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        [NMS(Index = 122)]
        /* 0x0704 */ public BootLoadDelayEnum BootLoadDelay;
        [NMS(Index = 199)]
        /* 0x0708 */ public float BootLogoFadeRate;
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
        /* 0x070C */ public BootModeEnum BootMode;
        [NMS(Index = 183)]
        /* 0x0710 */ public TkLanguages DebugLanguage;
        [NMS(Index = 230)]
        /* 0x0714 */ public float DebugMenuAlpha;
        [NMS(Index = 232)]
        /* 0x0718 */ public float DebugTextLineHeight;
        [NMS(Index = 231)]
        /* 0x071C */ public float DebugTextSize;
        [NMS(Index = 330)]
        /* 0x0720 */ public int DebugTextureSize;
        [NMS(Index = 302)]
        /* 0x0724 */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Index = 387)]
        /* 0x0728 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        [NMS(Index = 405)]
        /* 0x072C */ public int ForceAsteroidSystemIndex;
        [NMS(Index = 363)]
        /* 0x0730 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        [NMS(Index = 362)]
        /* 0x0734 */ public GcBiomeType ForceBiomeTo;
        [NMS(Index = 368)]
        /* 0x0738 */ public GcAlienRace ForceBuildingRaceTo;
        [NMS(Index = 377)]
        /* 0x073C */ public GcPlanetLife ForceCreatureLifeLevelTo;
        [NMS(Index = 398)]
        /* 0x0740 */ public int ForceGrassColourIndex;
        [NMS(Index = 126)]
        /* 0x0744 */ public float ForceInitialTimeOfDay;
        [NMS(Index = 178)]
        /* 0x0748 */ public int ForceInteractionIndex;
        [NMS(Index = 186)]
        /* 0x074C */ public GcAlienRace ForceInteractionRaceTo;
        [NMS(Index = 370)]
        /* 0x0750 */ public GcPlanetLife ForceLifeLevelTo;
        [NMS(Index = 179)]
        /* 0x0754 */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        [NMS(Index = 366)]
        /* 0x0758 */ public GcScreenFilters ForceScreenFilterTo;
        [NMS(Index = 390)]
        /* 0x075C */ public float ForceSeaLevel;
        [NMS(Index = 393)]
        /* 0x0760 */ public int ForceSkyColourIndex;
        [NMS(Index = 396)]
        /* 0x0764 */ public uint ForceSkyColourSeed;
        [NMS(Index = 38)]
        /* 0x0768 */ public GcSpaceBattleType ForceSpaceBattleType;
        [NMS(Index = 394)]
        /* 0x076C */ public int ForceSpaceSkyColourIndex;
        [NMS(Index = 360)]
        /* 0x0770 */ public GcGalaxyStarTypes ForceStarTypeTo;
        [NMS(Index = 128)]
        /* 0x0774 */ public float ForceSunAngle;
        [NMS(Index = 378)]
        /* 0x0778 */ public GcPlanetLife ForceTerrainSettings;
        [NMS(Index = 380)]
        /* 0x077C */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        [NMS(Index = 125)]
        /* 0x0780 */ public float ForceTimeOfDay;
        [NMS(Index = 397)]
        /* 0x0784 */ public int ForceWaterColourIndex;
        [NMS(Index = 392)]
        /* 0x0788 */ public TkWaterCondition ForceWaterConditionTo;
        [NMS(Index = 389)]
        /* 0x078C */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        [NMS(Index = 109)]
        /* 0x0790 */ public GameStateModeEnum GameStateMode;
        [NMS(Index = 414)]
        /* 0x0794 */ public float GenerateCostAngle;
        [NMS(Index = 413)]
        /* 0x0798 */ public float GenerateCostDistance;
        [NMS(Index = 415)]
        /* 0x079C */ public float GenerateCostLOD;
        [NMS(Index = 416)]
        /* 0x07A0 */ public float GenerateCostWait;
        [NMS(Index = 411)]
        /* 0x07A4 */ public int GenerateFarLodBuildingDist;
        [NMS(Index = 328)]
        /* 0x07A8 */ public int MaxNumDebugMessages;
        [NMS(Index = 428)]
        /* 0x07AC */ public int MoveBaseIndex;
        [NMS(Index = 451)]
        /* 0x07B0 */ public int MultipleFingersSamePressFrameDelta;
        [NMS(Index = 12)]
        /* 0x07B4 */ public GcGameMode NewSaveGameMode;
        [NMS(Index = 323)]
        /* 0x07B8 */ public int OverrideCommunityMissionNumber;
        [NMS(Index = 319)]
        /* 0x07BC */ public int OverrideServerSeasonEndTime;
        [NMS(Index = 318)]
        /* 0x07C0 */ public int OverrideServerSeasonNumber;
        [NMS(Index = 454)]
        /* 0x07C4 */ public float PanDeadzone;
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
        /* 0x07C8 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Index = 333)]
        /* 0x07CC */ public int ProceduralModelBatchSize;
        [NMS(Index = 334)]
        /* 0x07D0 */ public int ProceduralModelFilterMatchretryCount;
        [NMS(Index = 332)]
        /* 0x07D4 */ public int ProceduralModelsShown;
        [NMS(Index = 336)]
        /* 0x07D8 */ public int ProceduralModelsThumbnailSize;
        [NMS(Index = 432)]
        /* 0x07DC */ public int ProfilerPartIndexPhase;
        [NMS(Index = 433)]
        /* 0x07E0 */ public int ProfilerPartIndexStride;
        [NMS(Index = 434)]
        /* 0x07E4 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        [NMS(Index = 297)]
        /* 0x07E8 */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        [NMS(Index = 187)]
        /* 0x07EC */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        [NMS(Index = 206)]
        /* 0x07F0 */ public RecordSettingEnum RecordSetting;
        [NMS(Index = 219)]
        /* 0x07F4 */ public int RecurrenceTimeOffset;
        [NMS(Index = 450)]
        /* 0x07F8 */ public int ScreenshotForUploadHeight;
        [NMS(Index = 449)]
        /* 0x07FC */ public int ScreenshotForUploadWidth;
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
        [NMS(Index = 299)]
        /* 0x0800 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        [NMS(Index = 118)]
        /* 0x0804 */ public ShaderPreloadEnum ShaderPreload;
        [NMS(Index = 242)]
        /* 0x0808 */ public int ShowSpecificGraph;
        [NMS(Index = 258)]
        /* 0x080C */ public int SmokeTestConfigCaptureCycles;
        [NMS(Index = 259)]
        /* 0x0810 */ public float SmokeTestConfigCaptureDurationInSeconds;
        [NMS(Index = 260)]
        /* 0x0814 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        [NMS(Index = 251)]
        /* 0x0818 */ public int SmokeTestConfigPlanetPositionCount;
        [NMS(Index = 253)]
        /* 0x081C */ public float SmokeTestConfigScenarioLength;
        [NMS(Index = 252)]
        /* 0x0820 */ public float SmokeTestConfigScenarioPreambleLength;
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
        [NMS(Index = 248)]
        /* 0x0824 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
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
        [NMS(Index = 249)]
        /* 0x0828 */ public SmokeTestScenarioEnum SmokeTestScenario;
        [NMS(Index = 264)]
        /* 0x082C */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        [NMS(Index = 117)]
        /* 0x0830 */ public SolarSystemBootEnum SolarSystemBoot;
        [NMS(Index = 101)]
        /* 0x0834 */ public float SprintMultiplier;
        [NMS(Index = 284)]
        /* 0x0838 */ public float SunLightScaleGgx;
        [NMS(Index = 452)]
        /* 0x083C */ public int SwipeDetectionMaxFrames;
        [NMS(Index = 453)]
        /* 0x0840 */ public float SwipeDetectionNormalizedTravelThreshold;
        [NMS(Index = 326)]
        /* 0x0844 */ public int SynergyPort;
        // size: 0x3
        public enum UseBanksEnum : uint {
            False,
            True,
            Default,
        }
        [NMS(Index = 213)]
        /* 0x0848 */ public UseBanksEnum UseBanks;
        [NMS(Index = 201)]
        /* 0x084C */ public float WeaponScale3P;
        [NMS(Index = 191)]
        /* 0x0850 */ public ushort RealityGenerationIteration;
        [NMS(Index = 305)]
        /* 0x0852 */ public NMSString0x800 AutoJoinUserNames;
        [NMS(Index = 80)]
        /* 0x1052 */ public NMSString0x400 DebugTwitchRewards;
        [NMS(Index = 310)]
        /* 0x1452 */ public NMSString0x200 LoadToBase;
        [NMS(Index = 76)]
        /* 0x1652 */ public NMSString0x200 SeasonalDataOverrideFile;
        [NMS(Index = 320)]
        /* 0x1852 */ public NMSString0x100 ForceHgAccount;
        [NMS(Index = 106)]
        /* 0x1952 */ public NMSString0x100 ForcePlayerPosition;
        [NMS(Index = 103)]
        /* 0x1A52 */ public NMSString0x100 ForceUniverseAddress;
        [NMS(Index = 313)]
        /* 0x1B52 */ public NMSString0x100 GOGLogin;
        [NMS(Index = 238)]
        /* 0x1C52 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        [NMS(Index = 113)]
        /* 0x1D52 */ public NMSString0x100 WorkingDirectory;
        [NMS(Index = 300)]
        /* 0x1E52 */ public NMSString0x80 AuthBaseUrl;
        [NMS(Index = 298)]
        /* 0x1ED2 */ public NMSString0x80 ProxyURI;
        [NMS(Index = 321)]
        /* 0x1F52 */ public NMSString0x40 ForceBaseDownloadUser;
        [NMS(Index = 442)]
        /* 0x1F92 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        [NMS(Index = 441)]
        /* 0x1FD2 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        [NMS(Index = 448)]
        /* 0x2012 */ public NMSString0x40 ScreenshotForUploadName;
        [NMS(Index = 184)]
        /* 0x2052 */ public NMSString0x20 AllowedLanguagesFile;
        [NMS(Index = 429)]
        /* 0x2072 */ public NMSString0x20 AutomaticPartSpawnID;
        [NMS(Index = 223)]
        /* 0x2092 */ public NMSString0x20 CrashDumpIdentifier;
        [NMS(Index = 212)]
        /* 0x20B2 */ public NMSString0x20 SaveTestingCommand;
        [NMS(Index = 266)]
        /* 0x20D2 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        [NMS(Index = 267)]
        /* 0x20F2 */ public NMSString0x20 SmokeTestRunFolder;
        [NMS(Index = 325)]
        /* 0x2112 */ public NMSString0x20 SynergyServer;
        [NMS(Index = 461)]
        /* 0x2132 */ public bool ActiveMissionsIgnoreStartCancelConditions;
        [NMS(Index = 132)]
        /* 0x2133 */ public bool AllowGalaxyMapRequests;
        [NMS(Index = 424)]
        /* 0x2134 */ public bool AllowGlobalPartSnapping;
        [NMS(Index = 353)]
        /* 0x2135 */ public bool AllowNGuiVR;
        [NMS(Index = 440)]
        /* 0x2136 */ public bool AllowOverrideSettlementOwnership;
        [NMS(Index = 81)]
        /* 0x2137 */ public bool AllowPause;
        [NMS(Index = 97)]
        /* 0x2138 */ public bool AllowPetBattlerPvEOnPvPTable;
        [NMS(Index = 153)]
        /* 0x2139 */ public bool AllowRobotBehaviors;
        [NMS(Index = 1)]
        /* 0x213A */ public bool AllowSavingOnAbandonedFreighters;
        [NMS(Index = 160)]
        /* 0x213B */ public bool AllSeasonMilestonesShowComplete;
        [NMS(Index = 82)]
        /* 0x213C */ public bool AllSettlementsAreCompleted;
        [NMS(Index = 67)]
        /* 0x213D */ public bool AlternateControls;
        [NMS(Index = 75)]
        /* 0x213E */ public bool AlwaysAllowFreighterInventoryAccess;
        [NMS(Index = 73)]
        /* 0x213F */ public bool AlwaysAllowShipOperations;
        [NMS(Index = 150)]
        /* 0x2140 */ public bool AlwaysAllowSpookFiends;
        [NMS(Index = 74)]
        /* 0x2141 */ public bool AlwaysAllowVehicleOperations;
        [NMS(Index = 18)]
        /* 0x2142 */ public bool AlwaysHaveFocus;
        [NMS(Index = 294)]
        /* 0x2143 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        [NMS(Index = 306)]
        /* 0x2144 */ public bool AlwaysSaveGameAsClient;
        [NMS(Index = 240)]
        /* 0x2145 */ public bool AlwaysShowSaveIds;
        [NMS(Index = 68)]
        /* 0x2146 */ public bool AlwaysShowURI;
        [NMS(Index = 37)]
        /* 0x2147 */ public bool AlwaysSpaceBattle;
        [NMS(Index = 462)]
        /* 0x2148 */ public bool AssertIfDiploFound;
        [NMS(Index = 312)]
        /* 0x2149 */ public bool AutoJoinRandomGames;
        [NMS(Index = 304)]
        /* 0x214A */ public bool AutoJoinUserEnabled;
        [NMS(Index = 431)]
        /* 0x214B */ public bool AutomaticPartSpawnInactive;
        [NMS(Index = 436)]
        /* 0x214C */ public bool BaseAdmin;
        [NMS(Index = 86)]
        /* 0x214D */ public bool BlockCommunicatorSignals;
        [NMS(Index = 443)]
        /* 0x214E */ public bool BlockSettlementsNetwork;
        [NMS(Index = 39)]
        /* 0x214F */ public bool BlockSpaceBattle;
        [NMS(Index = 347)]
        /* 0x2150 */ public bool BodyTurning;
        [NMS(Index = 11)]
        /* 0x2151 */ public bool BootDirectlyIntoLastSave;
        [NMS(Index = 200)]
        /* 0x2152 */ public bool BootMusic;
        [NMS(Index = 29)]
        /* 0x2153 */ public bool CanLeaveDialogs;
        [NMS(Index = 301)]
        /* 0x2154 */ public bool CertificateSecurityBypass;
        [NMS(Index = 210)]
        /* 0x2155 */ public bool CheckForMissingLocStrings;
        [NMS(Index = 54)]
        /* 0x2156 */ public bool ClothForceAsyncSimulationOff;
        [NMS(Index = 55)]
        /* 0x2157 */ public bool ClothForceAsyncSimulationOn;
        [NMS(Index = 53)]
        /* 0x2158 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        [NMS(Index = 50)]
        /* 0x2159 */ public bool ClothForcePositionExtrapolationBackOn;
        [NMS(Index = 48)]
        /* 0x215A */ public bool ClothForcePositionExtrapolationOff;
        [NMS(Index = 49)]
        /* 0x215B */ public bool ClothForcePositionExtrapolationOn;
        [NMS(Index = 52)]
        /* 0x215C */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        [NMS(Index = 51)]
        /* 0x215D */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        [NMS(Index = 272)]
        /* 0x215E */ public bool CompressTextures;
        [NMS(Index = 221)]
        /* 0x215F */ public bool CrashDumpFull;
        [NMS(Index = 92)]
        /* 0x2160 */ public bool CrashOnF10;
        [NMS(Index = 268)]
        /* 0x2161 */ public bool CreatureChatter;
        [NMS(Index = 270)]
        /* 0x2162 */ public bool CreatureDrawVocals;
        [NMS(Index = 269)]
        /* 0x2163 */ public bool CreatureErrors;
        [NMS(Index = 438)]
        /* 0x2164 */ public bool CrossPlatformFeaturedBases;
        [NMS(Index = 418)]
        /* 0x2165 */ public bool DChecksEnabled;
        [NMS(Index = 420)]
        /* 0x2166 */ public bool DChecksOutputBinary;
        [NMS(Index = 421)]
        /* 0x2167 */ public bool DChecksOutputFileLine;
        [NMS(Index = 419)]
        /* 0x2168 */ public bool DChecksOutputJson;
        [NMS(Index = 207)]
        /* 0x2169 */ public bool DebugBuildingSpawns;
        [NMS(Index = 277)]
        /* 0x216A */ public bool DebugDepthReprojection;
        [NMS(Index = 176)]
        /* 0x216B */ public bool DebugDrawPlayerInteract;
        [NMS(Index = 20)]
        /* 0x216C */ public bool DebugGalaxyMapInQuickMenu;
        [NMS(Index = 273)]
        /* 0x216D */ public bool DebugIBL;
        [NMS(Index = 211)]
        /* 0x216E */ public bool DebugNetworkLocks;
        [NMS(Index = 188)]
        /* 0x216F */ public bool DebugPersistentInteractions;
        [NMS(Index = 276)]
        /* 0x2170 */ public bool DebugRenderSpaceOffset;
        [NMS(Index = 274)]
        /* 0x2171 */ public bool DebugSpotlights;
        [NMS(Index = 275)]
        /* 0x2172 */ public bool DebugTerrainTextures;
        [NMS(Index = 224)]
        /* 0x2173 */ public bool DebugThreatLevels;
        [NMS(Index = 412)]
        /* 0x2174 */ public bool DeferRegionBodies;
        [NMS(Index = 2)]
        /* 0x2175 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Index = 422)]
        /* 0x2176 */ public bool DisableBaseBuilding;
        [NMS(Index = 423)]
        /* 0x2177 */ public bool DisableBaseBuildingLimits;
        [NMS(Index = 426)]
        /* 0x2178 */ public bool DisableBasePowerRequirements;
        [NMS(Index = 289)]
        /* 0x2179 */ public bool DisableClouds;
        [NMS(Index = 43)]
        /* 0x217A */ public bool DisableContinuousSaving;
        [NMS(Index = 435)]
        /* 0x217B */ public bool DisableCorvetteSwapParts;
        [NMS(Index = 93)]
        /* 0x217C */ public bool DisableCorvetteValidation;
        [NMS(Index = 171)]
        /* 0x217D */ public bool DisableDebugControls;
        [NMS(Index = 175)]
        /* 0x217E */ public bool DisableDiscoveryNaming;
        [NMS(Index = 218)]
        /* 0x217F */ public bool DisableFileWatcher;
        [NMS(Index = 28)]
        /* 0x2180 */ public bool DisableHazards;
        [NMS(Index = 351)]
        /* 0x2181 */ public bool DisableHeadConstraints;
        [NMS(Index = 44)]
        /* 0x2182 */ public bool DisableInvalidSaveVersion;
        [NMS(Index = 350)]
        /* 0x2183 */ public bool DisableLeftHand;
        [NMS(Index = 406)]
        /* 0x2184 */ public bool DisableLimits;
        [NMS(Index = 463)]
        /* 0x2185 */ public bool DisableMissionShop;
        [NMS(Index = 307)]
        /* 0x2186 */ public bool DisableMonumentDownloads;
        [NMS(Index = 64, MxmlName = "DisableNPCHiddenUntilScanned ")]
        /* 0x2187 */ public bool DisableNPCHiddenUntilScanned;
        [NMS(Index = 63)]
        /* 0x2188 */ public bool DisableNPCs;
        [NMS(Index = 445)]
        /* 0x2189 */ public bool DisablePartialStories;
        [NMS(Index = 99)]
        /* 0x218A */ public bool DisablePetBattlerSpectatorWelcomeMessageForSwitch2;
        [NMS(Index = 217)]
        /* 0x218B */ public bool DisableProfanityFilter;
        [NMS(Index = 41)]
        /* 0x218C */ public bool DisableSaveSlotSorting;
        [NMS(Index = 322)]
        /* 0x218D */ public bool DisableSaveUploadRateLimits;
        [NMS(Index = 42)]
        /* 0x218E */ public bool DisableSaving;
        [NMS(Index = 83)]
        /* 0x218F */ public bool DisableSettlements;
        [NMS(Index = 278)]
        /* 0x2190 */ public bool DisableShadowSwitching;
        [NMS(Index = 195)]
        /* 0x2191 */ public bool DisableShipSaveDataRecovery;
        [NMS(Index = 303)]
        /* 0x2192 */ public bool DisableSpaceStationSpawnOnJoin;
        [NMS(Index = 45)]
        /* 0x2193 */ public bool DisableStorms;
        [NMS(Index = 19)]
        /* 0x2194 */ public bool DisableVibration;
        [NMS(Index = 185)]
        /* 0x2195 */ public bool DoAlienLanguage;
        [NMS(Index = 271)]
        /* 0x2196 */ public bool DrawCreaturesInRoutines;
        [NMS(Index = 225)]
        /* 0x2197 */ public bool DumpManifestContents;
        [NMS(Index = 444)]
        /* 0x2198 */ public bool EnableAccessibleUI;
        [NMS(Index = 163)]
        /* 0x2199 */ public bool EnableBaseBuildingExpandables;
        [NMS(Index = 427)]
        /* 0x219A */ public bool EnableBaseMovingOption;
        [NMS(Index = 139)]
        /* 0x219B */ public bool EnableCloudAnimation;
        [NMS(Index = 285)]
        /* 0x219C */ public bool EnableComputePost;
        [NMS(Index = 169)]
        /* 0x219D */ public bool EnableCustomSolarSystemMapMaterials;
        [NMS(Index = 149)]
        /* 0x219E */ public bool EnableDayNightCycle;
        [NMS(Index = 116)]
        /* 0x219F */ public bool EnableDebugSceneAutoSave;
        [NMS(Index = 130)]
        /* 0x21A0 */ public bool EnableFrontendPreload;
        [NMS(Index = 161)]
        /* 0x21A1 */ public bool EnableGalaxyRecolouring;
        [NMS(Index = 164)]
        /* 0x21A2 */ public bool EnableGameTables;
        [NMS(Index = 283)]
        /* 0x21A3 */ public bool EnableGgx;
        [NMS(Index = 85)]
        /* 0x21A4 */ public bool EnableMemoryPoolAllocPrint;
        [NMS(Index = 167)]
        /* 0x21A5 */ public bool EnableNearbySolarSystemWarpMarkers;
        [NMS(Index = 95)]
        /* 0x21A6 */ public bool EnablePetBattlerRandomPets;
        [NMS(Index = 96)]
        /* 0x21A7 */ public bool EnablePetBattlerTurnTimeoutInPvE;
        [NMS(Index = 352)]
        /* 0x21A8 */ public bool EnablePhotomodeVR;
        [NMS(Index = 166)]
        /* 0x21A9 */ public bool EnableSolarSystemMap;
        [NMS(Index = 324)]
        /* 0x21AA */ public bool EnableSynergy;
        [NMS(Index = 88)]
        /* 0x21AB */ public bool EnableTouchScreenDebugging;
        [NMS(Index = 94)]
        /* 0x21AC */ public bool EnforceCorvetteComplexityLimit;
        [NMS(Index = 24)]
        /* 0x21AD */ public bool EverythingIsFree;
        [NMS(Index = 25)]
        /* 0x21AE */ public bool EverythingIsKnown;
        [NMS(Index = 26)]
        /* 0x21AF */ public bool EverythingIsStar;
        [NMS(Index = 315)]
        /* 0x21B0 */ public bool FakeHandsInMultiplayer;
        [NMS(Index = 40)]
        /* 0x21B1 */ public bool FastAndFrequentFleetInterventions;
        [NMS(Index = 9)]
        /* 0x21B2 */ public bool FastLoad;
        [NMS(Index = 172)]
        /* 0x21B3 */ public bool FixedFramerate;
        [NMS(Index = 203)]
        /* 0x21B4 */ public bool FleetDirectorAutoMode;
        [NMS(Index = 460)]
        /* 0x21B5 */ public bool ForceAllExhibitsToBeEditable;
        [NMS(Index = 198)]
        /* 0x21B6 */ public bool ForceBasicLoadScreen;
        [NMS(Index = 385)]
        /* 0x21B7 */ public bool ForceBinaryStar;
        [NMS(Index = 361)]
        /* 0x21B8 */ public bool ForceBiome;
        [NMS(Index = 364)]
        /* 0x21B9 */ public bool ForceBiomeMaintainsTerrain;
        [NMS(Index = 66)]
        /* 0x21BA */ public bool ForceBuildersAlwaysKnown;
        [NMS(Index = 367)]
        /* 0x21BB */ public bool ForceBuildingRace;
        [NMS(Index = 357)]
        /* 0x21BC */ public bool ForceCorruptSentinels;
        [NMS(Index = 371)]
        /* 0x21BD */ public bool ForceCreatureLifeLevel;
        [NMS(Index = 372)]
        /* 0x21BE */ public bool ForceDefaultCreatureFile;
        [NMS(Index = 47)]
        /* 0x21BF */ public bool ForceDisableClothComponent;
        [NMS(Index = 60)]
        /* 0x21C0 */ public bool ForceDisableNonPlayerRagdollComponents;
        [NMS(Index = 59)]
        /* 0x21C1 */ public bool ForceDisableRagdollComponent;
        [NMS(Index = 62)]
        /* 0x21C2 */ public bool ForceDisableSeparatePhysicsWorlds;
        [NMS(Index = 61)]
        /* 0x21C3 */ public bool ForceDisableSplitIkOptimisation;
        [NMS(Index = 57)]
        /* 0x21C4 */ public bool ForceDisableSpringComponent;
        [NMS(Index = 98)]
        /* 0x21C5 */ public bool ForceDiscoverAllSpacePoi;
        [NMS(Index = 46)]
        /* 0x21C6 */ public bool ForceEnableClothComponent;
        [NMS(Index = 58)]
        /* 0x21C7 */ public bool ForceEnableRagdollComponent;
        [NMS(Index = 56)]
        /* 0x21C8 */ public bool ForceEnableSpringComponent;
        [NMS(Index = 356)]
        /* 0x21C9 */ public bool ForceExtremeSentinels;
        [NMS(Index = 355)]
        /* 0x21CA */ public bool ForceExtremeWeather;
        [NMS(Index = 124)]
        /* 0x21CB */ public bool ForceFrontendPersonalityTest;
        [NMS(Index = 91)]
        /* 0x21CC */ public bool ForceFullFeatureMode;
        [NMS(Index = 383)]
        /* 0x21CD */ public bool ForceGasGiantSystem;
        [NMS(Index = 382)]
        /* 0x21CE */ public bool ForceGiantSystem;
        [NMS(Index = 107)]
        /* 0x21CF */ public bool ForceInitialShip;
        [NMS(Index = 108)]
        /* 0x21D0 */ public bool ForceInitialWeapon;
        [NMS(Index = 177)]
        /* 0x21D1 */ public bool ForceInteractionToSettings;
        [NMS(Index = 369)]
        /* 0x21D2 */ public bool ForceLifeLevel;
        [NMS(Index = 359)]
        /* 0x21D3 */ public bool ForceLoadAllWeather;
        [NMS(Index = 159)]
        /* 0x21D4 */ public bool ForceNexusInQuickMenu;
        [NMS(Index = 381)]
        /* 0x21D5 */ public bool ForcePirateSystem;
        [NMS(Index = 401)]
        /* 0x21D6 */ public bool ForcePlanetsToHaveNoCaves;
        [NMS(Index = 402)]
        /* 0x21D7 */ public bool ForcePlanetsToHaveNoNoiseLayers;
        [NMS(Index = 403)]
        /* 0x21D8 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        [NMS(Index = 400)]
        /* 0x21D9 */ public bool ForcePlanetsToHaveNoWater;
        [NMS(Index = 388)]
        /* 0x21DA */ public bool ForcePlanetsToHaveWater;
        [NMS(Index = 384)]
        /* 0x21DB */ public bool ForcePrimeTerrain;
        [NMS(Index = 197)]
        /* 0x21DC */ public bool ForcePurpleSystemsToAlwaysBirth;
        [NMS(Index = 196)]
        /* 0x21DD */ public bool ForcePurpleSystemsVisibleOnLoad;
        [NMS(Index = 404)]
        /* 0x21DE */ public bool ForceRareAsteroidSystem;
        [NMS(Index = 465)]
        /* 0x21DF */ public bool ForceScanEventsToGoPrime;
        [NMS(Index = 466)]
        /* 0x21E0 */ public bool ForceScanEventsToSpecificGrassColour;
        [NMS(Index = 354)]
        /* 0x21E1 */ public bool ForceScrapWorlds;
        [NMS(Index = 365)]
        /* 0x21E2 */ public bool ForceScreenFilter;
        [NMS(Index = 316)]
        /* 0x21E3 */ public bool ForceSmallLobby;
        [NMS(Index = 395)]
        /* 0x21E4 */ public bool ForceSpaceSkyColourRare;
        [NMS(Index = 358)]
        /* 0x21E5 */ public bool ForceStarType;
        [NMS(Index = 127)]
        /* 0x21E6 */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Index = 386)]
        /* 0x21E7 */ public bool ForceTernaryStar;
        [NMS(Index = 379)]
        /* 0x21E8 */ public bool ForceTerrainType;
        [NMS(Index = 90)]
        /* 0x21E9 */ public bool ForceTgaDlc;
        [NMS(Index = 317)]
        /* 0x21EA */ public bool ForceTinyLobby;
        [NMS(Index = 34)]
        /* 0x21EB */ public bool ForceTranslateAllAlienText;
        [NMS(Index = 104)]
        /* 0x21EC */ public bool ForceUniverseAddressFromChangelist;
        [NMS(Index = 21)]
        /* 0x21ED */ public bool ForceUnlockSolarSystemMap;
        [NMS(Index = 391)]
        /* 0x21EE */ public bool ForceWaterCondition;
        [NMS(Index = 194)]
        /* 0x21EF */ public bool FormatDownloadStorageAreaOnBoot;
        [NMS(Index = 15)]
        /* 0x21F0 */ public bool GodMode;
        [NMS(Index = 243)]
        /* 0x21F1 */ public bool GraphCommandBuffer;
        [NMS(Index = 245)]
        /* 0x21F2 */ public bool GraphFPS;
        [NMS(Index = 244)]
        /* 0x21F3 */ public bool GraphGeneration;
        [NMS(Index = 246)]
        /* 0x21F4 */ public bool GraphTexStreaming;
        [NMS(Index = 214)]
        /* 0x21F5 */ public bool HangOnCrash;
        [NMS(Index = 344)]
        /* 0x21F6 */ public bool HmdFrameShiftEnabled;
        [NMS(Index = 346)]
        /* 0x21F7 */ public bool HmdShowTrackedEyePos;
        [NMS(Index = 345)]
        /* 0x21F8 */ public bool HmdUseSolidGuiPointer;
        [NMS(Index = 215)]
        /* 0x21F9 */ public bool HotReloadModGlobals;
        [NMS(Index = 35)]
        /* 0x21FA */ public bool IgnoreFreighterSpawnWarpRequirement;
        [NMS(Index = 467)]
        /* 0x21FB */ public bool IgnoreMissionRank;
        [NMS(Index = 162)]
        /* 0x21FC */ public bool IgnoreSteamDev;
        [NMS(Index = 311)]
        /* 0x21FD */ public bool IgnoreTransactionTimeouts;
        [NMS(Index = 181)]
        /* 0x21FE */ public bool InfiniteInteractions;
        [NMS(Index = 27)]
        /* 0x21FF */ public bool InfiniteStamina;
        [NMS(Index = 156)]
        /* 0x2200 */ public bool InstanceCollision;
        [NMS(Index = 180)]
        /* 0x2201 */ public bool InteractionsAllwaysGivesTech;
        [NMS(Index = 410)]
        /* 0x2202 */ public bool LimitGlobalBodies;
        [NMS(Index = 409)]
        /* 0x2203 */ public bool LimitGlobalInstances;
        [NMS(Index = 408)]
        /* 0x2204 */ public bool LimitPerRegionBodies;
        [NMS(Index = 407)]
        /* 0x2205 */ public bool LimitPerRegionInstances;
        [NMS(Index = 288)]
        /* 0x2206 */ public bool LoadShaderSourceIfRenderdocEnabled;
        [NMS(Index = 72)]
        /* 0x2207 */ public bool LockAllTitles;
        [NMS(Index = 202)]
        /* 0x2208 */ public bool LogMissingLocalisedText;
        [NMS(Index = 23)]
        /* 0x2209 */ public bool MapWarpCheckIgnoreDrive;
        [NMS(Index = 22)]
        /* 0x220A */ public bool MapWarpCheckIgnoreFuel;
        [NMS(Index = 36)]
        /* 0x220B */ public bool MaximumFreighterSpawns;
        [NMS(Index = 170)]
        /* 0x220C */ public bool MeltdownsEnabled;
        [NMS(Index = 123)]
        /* 0x220D */ public bool MemCsv;
        [NMS(Index = 468)]
        /* 0x220E */ public bool MissionMessageLoggingEnabled;
        [NMS(Index = 469)]
        /* 0x220F */ public bool MissionNGUIShowsConditionResults;
        [NMS(Index = 470)]
        /* 0x2210 */ public bool MissionNGUIShowsTableNames;
        [NMS(Index = 471)]
        /* 0x2211 */ public bool MissionSurveyEnabled;
        [NMS(Index = 399)]
        /* 0x2212 */ public bool ModifyPlanetsInInitialSystems;
        [NMS(Index = 472)]
        /* 0x2213 */ public bool MPMissions;
        [NMS(Index = 473)]
        /* 0x2214 */ public bool MPMissionsAlwaysEPIC;
        [NMS(Index = 158)]
        /* 0x2215 */ public bool MultiplePlayerFreightersInASystem;
        [NMS(Index = 168)]
        /* 0x2216 */ public bool NexusBots;
        [NMS(Index = 84)]
        /* 0x2217 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        [NMS(Index = 329)]
        /* 0x2218 */ public bool PreloadToolbox;
        [NMS(Index = 233)]
        /* 0x2219 */ public bool PrintAvgFrameTimes;
        [NMS(Index = 335)]
        /* 0x221A */ public bool ProceduralModelsDeterministicSequence;
        [NMS(Index = 286)]
        /* 0x221B */ public bool Proto2DevKit;
        [NMS(Index = 314)]
        /* 0x221C */ public bool RecordNetworkStatsOnBoot;
        [NMS(Index = 32)]
        /* 0x221D */ public bool RenderCreatureDetails;
        [NMS(Index = 174)]
        /* 0x221E */ public bool RenderHud;
        [NMS(Index = 282)]
        /* 0x221F */ public bool RenderLowFramerate;
        [NMS(Index = 129)]
        /* 0x2220 */ public bool ResetForcedSaveSlotOnLoad;
        [NMS(Index = 102)]
        /* 0x2221 */ public bool ResetToSupportedResolution;
        [NMS(Index = 70)]
        /* 0x2222 */ public bool RevealAllTitles;
        [NMS(Index = 216)]
        /* 0x2223 */ public bool SaveOutModdedMetadata;
        [NMS(Index = 459)]
        /* 0x2224 */ public bool ScratchpadPlanetEnvironment;
        [NMS(Index = 173)]
        /* 0x2225 */ public bool ScreenshotMode;
        [NMS(Index = 121)]
        /* 0x2226 */ public bool ShaderCaching;
        [NMS(Index = 119)]
        /* 0x2227 */ public bool ShaderPreloadListExport;
        [NMS(Index = 120)]
        /* 0x2228 */ public bool ShaderPreloadListImport;
        [NMS(Index = 65)]
        /* 0x2229 */ public bool ShipSalvageGivesAllParts;
        [NMS(Index = 296)]
        /* 0x222A */ public bool ShowAtlasErrorOSD;
        [NMS(Index = 226)]
        /* 0x222B */ public bool ShowDebugMessages;
        [NMS(Index = 229)]
        /* 0x222C */ public bool ShowDynamicResScale;
        [NMS(Index = 327)]
        /* 0x222D */ public bool ShowEditorPlacementPreview;
        [NMS(Index = 69)]
        /* 0x222E */ public bool ShowFireteamMembersUA;
        [NMS(Index = 227)]
        /* 0x222F */ public bool ShowFramerate;
        [NMS(Index = 235)]
        /* 0x2230 */ public bool ShowGPUMemory;
        [NMS(Index = 228)]
        /* 0x2231 */ public bool ShowGPURenderTime;
        [NMS(Index = 241)]
        /* 0x2232 */ public bool ShowGraphs;
        [NMS(Index = 348)]
        /* 0x2233 */ public bool ShowHmdHandControllers;
        [NMS(Index = 209)]
        /* 0x2234 */ public bool ShowLongestStrings;
        [NMS(Index = 236)]
        /* 0x2235 */ public bool ShowMempoolOverlay;
        [NMS(Index = 474)]
        /* 0x2236 */ public bool ShowMissionIdInTitle;
        [NMS(Index = 237)]
        /* 0x2237 */ public bool ShowMouseSmoothing;
        [NMS(Index = 234)]
        /* 0x2238 */ public bool ShowPositionDebug;
        [NMS(Index = 239)]
        /* 0x2239 */ public bool ShowRenderStatsDisplay;
        [NMS(Index = 349)]
        /* 0x223A */ public bool ShowTeleportEffectLocally;
        [NMS(Index = 287)]
        /* 0x223B */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 295)]
        /* 0x223C */ public bool SimulateNoNetworkConnection;
        [NMS(Index = 0)]
        /* 0x223D */ public bool SkipAbandonedFreighterUnlocking;
        [NMS(Index = 6)]
        /* 0x223E */ public bool SkipIntro;
        [NMS(Index = 7)]
        /* 0x223F */ public bool SkipLogos;
        [NMS(Index = 13)]
        /* 0x2240 */ public bool SkipPlanetDiscoverOnBoot;
        [NMS(Index = 33)]
        /* 0x2241 */ public bool SkipTutorial;
        [NMS(Index = 8)]
        /* 0x2242 */ public bool SkipUITimers;
        [NMS(Index = 255)]
        /* 0x2243 */ public bool SmokeTestCameraFly;
        [NMS(Index = 261)]
        /* 0x2244 */ public bool SmokeTestConfigRandomizePlanetSeed;
        [NMS(Index = 247)]
        /* 0x2245 */ public bool SmokeTestDumpStatsMode;
        [NMS(Index = 254)]
        /* 0x2246 */ public bool SmokeTestFastExit;
        [NMS(Index = 250)]
        /* 0x2247 */ public bool SmokeTestLegacyOutput;
        [NMS(Index = 256)]
        /* 0x2248 */ public bool SmokeTestOutputOnly;
        [NMS(Index = 265)]
        /* 0x2249 */ public bool SmokeTestPostBandwidthStats;
        [NMS(Index = 257)]
        /* 0x224A */ public bool SmokeTestPureFlight;
        [NMS(Index = 263)]
        /* 0x224B */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 262)]
        /* 0x224C */ public bool SmokeTestSmokeBotEnabled;
        [NMS(Index = 151)]
        /* 0x224D */ public bool SpawnPirates;
        [NMS(Index = 155)]
        /* 0x224E */ public bool SpawnPulseEncounters;
        [NMS(Index = 152)]
        /* 0x224F */ public bool SpawnRobots;
        [NMS(Index = 154)]
        /* 0x2250 */ public bool SpawnShips;
        [NMS(Index = 157)]
        /* 0x2251 */ public bool SpecialsShop;
        [NMS(Index = 291)]
        /* 0x2252 */ public bool SpotlightsTiledOn;
        [NMS(Index = 290)]
        /* 0x2253 */ public bool SpotlightsTiledSettings;
        [NMS(Index = 293)]
        /* 0x2254 */ public bool SpotlightsTiledVisualise;
        [NMS(Index = 292)]
        /* 0x2255 */ public bool SpotlightsTiledZBins;
        [NMS(Index = 100)]
        /* 0x2256 */ public bool StartAsOrb;
        [NMS(Index = 182)]
        /* 0x2257 */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Index = 208)]
        /* 0x2258 */ public bool StressTestLongNameDisplay;
        [NMS(Index = 17)]
        /* 0x2259 */ public bool SuperKillGuns;
        [NMS(Index = 133)]
        /* 0x225A */ public bool SuppressSeasonalRewardReminders;
        [NMS(Index = 16)]
        /* 0x225B */ public bool TakeNoDamage;
        [NMS(Index = 4)]
        /* 0x225C */ public bool ThirdPersonIsDefaultCameraForPlayer;
        [NMS(Index = 5)]
        /* 0x225D */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        [NMS(Index = 79)]
        /* 0x225E */ public bool UnlockAllPlatformRewards;
        [NMS(Index = 77)]
        /* 0x225F */ public bool UnlockAllSeasonRewards;
        [NMS(Index = 446)]
        /* 0x2260 */ public bool UnlockAllStories;
        [NMS(Index = 71)]
        /* 0x2261 */ public bool UnlockAllTitles;
        [NMS(Index = 78)]
        /* 0x2262 */ public bool UnlockAllTwitchRewards;
        [NMS(Index = 447)]
        /* 0x2263 */ public bool UnlockAllWords;
        [NMS(Index = 165)]
        /* 0x2264 */ public bool UpdateMarkersJob;
        [NMS(Index = 136)]
        /* 0x2265 */ public bool UseBloom;
        [NMS(Index = 143)]
        /* 0x2266 */ public bool UseBuildings;
        [NMS(Index = 137)]
        /* 0x2267 */ public bool UseClouds;
        [NMS(Index = 144)]
        /* 0x2268 */ public bool UseCreatures;
        [NMS(Index = 145)]
        /* 0x2269 */ public bool UseElevation;
        [NMS(Index = 138)]
        /* 0x226A */ public bool UseGTAO;
        [NMS(Index = 31)]
        /* 0x226B */ public bool UseGunImpactEffect;
        [NMS(Index = 189)]
        /* 0x226C */ public bool UseHighlightedOptionStyle;
        [NMS(Index = 89)]
        /* 0x226D */ public bool UseImmediateModeFrontend;
        [NMS(Index = 141)]
        /* 0x226E */ public bool UseInstances;
        [NMS(Index = 148)]
        /* 0x226F */ public bool UseLegacyBuildingTable;
        [NMS(Index = 146)]
        /* 0x2270 */ public bool UseLegacyFreighters;
        [NMS(Index = 147)]
        /* 0x2271 */ public bool UseLegacySpaceStations;
        [NMS(Index = 87)]
        /* 0x2272 */ public bool UseMovementStickForRun;
        [NMS(Index = 142)]
        /* 0x2273 */ public bool UseObjects;
        [NMS(Index = 417)]
        /* 0x2274 */ public bool UseOldTerrainMeshing;
        [NMS(Index = 308)]
        /* 0x2275 */ public bool UsePadOnUnfocusedWindow;
        [NMS(Index = 134)]
        /* 0x2276 */ public bool UseParticles;
        [NMS(Index = 331)]
        /* 0x2277 */ public bool UseProcTextureDebugger;
        [NMS(Index = 131)]
        /* 0x2278 */ public bool UseSceneInfoWindow;
        [NMS(Index = 30)]
        /* 0x2279 */ public bool UseScreenEffects;
        [NMS(Index = 457)]
        /* 0x227A */ public bool UseSeasonTransferInventoryConfigOverride;
        [NMS(Index = 140)]
        /* 0x227B */ public bool UseTerrain;
        [NMS(Index = 135)]
        /* 0x227C */ public bool UseVolumetrics;
        [NMS(Index = 14)]
        /* 0x227D */ public bool VideoCaptureMode;
    }
}

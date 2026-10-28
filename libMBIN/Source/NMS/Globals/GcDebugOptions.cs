using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAE1546FE573F1602, NameHash = 0xAA861200)]
    public class GcDebugOptions : NMSTemplate
    {
        [NMS(Index = 467)]
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        [NMS(Index = 229)]
        /* 0x0030 */ public GcFilename CrashDumpPath;
        [NMS(Index = 464)]
        /* 0x0040 */ public NMSString0x10 CreateSeasonContextMaskIdOverride;
        [NMS(Index = 347)]
        /* 0x0050 */ public GcFilename CursorTexture;
        [NMS(Index = 115)]
        /* 0x0060 */ public GcFilename CutScene;
        [NMS(Index = 345)]
        /* 0x0070 */ public GcFilename DebugFont;
        [NMS(Index = 346)]
        /* 0x0080 */ public GcFilename DebugFontTexture;
        [NMS(Index = 116)]
        /* 0x0090 */ public GcFilename DebugScene;
        [NMS(Index = 383)]
        /* 0x00A0 */ public NMSString0x10 DefaultAirCreatureTable;
        [NMS(Index = 385)]
        /* 0x00B0 */ public NMSString0x10 DefaultCaveCreatureTable;
        [NMS(Index = 382)]
        /* 0x00C0 */ public NMSString0x10 DefaultGroundCreatureTable;
        [NMS(Index = 196)]
        /* 0x00D0 */ public GcFilename DefaultSaveData;
        [NMS(Index = 384)]
        /* 0x00E0 */ public NMSString0x10 DefaultWaterCreatureTable;
        [NMS(Index = 473)]
        /* 0x00F0 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        [NMS(Index = 195)]
        /* 0x0100 */ public List<NMSString0x20> LocTableList;
        [NMS(Index = 348)]
        /* 0x0110 */ public GcFilename PauseTexture;
        [NMS(Index = 286)]
        /* 0x0120 */ public GcFilename PipelineFile;
        [NMS(Index = 288)]
        /* 0x0130 */ public GcFilename PipelineFileEditor;
        [NMS(Index = 287)]
        /* 0x0140 */ public GcFilename PipelineFileFrontend;
        [NMS(Index = 349)]
        /* 0x0150 */ public GcFilename PlayTexture;
        [NMS(Index = 193)]
        /* 0x0160 */ public GcFilename RealityPresetFile;
        [NMS(Index = 351)]
        /* 0x0170 */ public GcFilename RenderToTexture;
        [NMS(Index = 113)]
        /* 0x0180 */ public GcFilename SceneSettings;
        [NMS(Index = 350)]
        /* 0x0190 */ public GcFilename StepTexture;
        [NMS(Index = 465)]
        /* 0x01A0 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        [NMS(Index = 227)]
        /* 0x01B0 */ public ulong ForceTimeToEpoch;
        [NMS(Index = 106)]
        /* 0x01B8 */ public ulong ForceUniverseAddressFromSeed;
        [NMS(Index = 3)]
        /* 0x01C0 */ public ulong OverrideAbandonedFreighterSeed;
        [NMS(Index = 316)]
        /* 0x01C8 */ public ulong OverrideMatchmakingVersion;
        [NMS(Index = 448)]
        /* 0x01D0 */ public TkGlobals ToolkitGlobals;
        [NMS(Index = 207, MxmlName = "3dTextDistance")]
        /* 0x07F0 */ public float _3dTextDistance;
        [NMS(Index = 208, MxmlName = "3dTextMinScale")]
        /* 0x07F4 */ public float _3dTextMinScale;
        [NMS(Index = 439)]
        /* 0x07F8 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        [NMS(Index = 434)]
        /* 0x07FC */ public float BaseDownloadTimeout;
        [NMS(Index = 446)]
        /* 0x0800 */ public uint BasePayloadMultiplier;
        [NMS(Index = 10)]
        /* 0x0804 */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        [NMS(Index = 123)]
        /* 0x0808 */ public BootLoadDelayEnum BootLoadDelay;
        [NMS(Index = 202)]
        /* 0x080C */ public float BootLogoFadeRate;
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
        [NMS(Index = 111)]
        /* 0x0810 */ public BootModeEnum BootMode;
        [NMS(Index = 186)]
        /* 0x0814 */ public TkLanguages DebugLanguage;
        [NMS(Index = 237)]
        /* 0x0818 */ public float DebugMenuAlpha;
        [NMS(Index = 239)]
        /* 0x081C */ public float DebugTextLineHeight;
        [NMS(Index = 238)]
        /* 0x0820 */ public float DebugTextSize;
        [NMS(Index = 338)]
        /* 0x0824 */ public int DebugTextureSize;
        [NMS(Index = 309)]
        /* 0x0828 */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Index = 396)]
        /* 0x082C */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        [NMS(Index = 414)]
        /* 0x0830 */ public int ForceAsteroidSystemIndex;
        [NMS(Index = 372)]
        /* 0x0834 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        [NMS(Index = 371)]
        /* 0x0838 */ public GcBiomeType ForceBiomeTo;
        [NMS(Index = 377)]
        /* 0x083C */ public GcAlienRace ForceBuildingRaceTo;
        [NMS(Index = 386)]
        /* 0x0840 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        [NMS(Index = 407)]
        /* 0x0844 */ public int ForceGrassColourIndex;
        [NMS(Index = 127)]
        /* 0x0848 */ public float ForceInitialTimeOfDay;
        [NMS(Index = 181)]
        /* 0x084C */ public int ForceInteractionIndex;
        [NMS(Index = 189)]
        /* 0x0850 */ public GcAlienRace ForceInteractionRaceTo;
        [NMS(Index = 379)]
        /* 0x0854 */ public GcPlanetLife ForceLifeLevelTo;
        [NMS(Index = 182)]
        /* 0x0858 */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        [NMS(Index = 375)]
        /* 0x085C */ public GcScreenFilters ForceScreenFilterTo;
        [NMS(Index = 399)]
        /* 0x0860 */ public float ForceSeaLevel;
        [NMS(Index = 402)]
        /* 0x0864 */ public int ForceSkyColourIndex;
        [NMS(Index = 405)]
        /* 0x0868 */ public uint ForceSkyColourSeed;
        [NMS(Index = 38)]
        /* 0x086C */ public GcSpaceBattleType ForceSpaceBattleType;
        [NMS(Index = 403)]
        /* 0x0870 */ public int ForceSpaceSkyColourIndex;
        [NMS(Index = 369)]
        /* 0x0874 */ public GcGalaxyStarTypes ForceStarTypeTo;
        [NMS(Index = 129)]
        /* 0x0878 */ public float ForceSunAngle;
        [NMS(Index = 387)]
        /* 0x087C */ public GcPlanetLife ForceTerrainSettings;
        [NMS(Index = 389)]
        /* 0x0880 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        [NMS(Index = 126)]
        /* 0x0884 */ public float ForceTimeOfDay;
        [NMS(Index = 406)]
        /* 0x0888 */ public int ForceWaterColourIndex;
        [NMS(Index = 401)]
        /* 0x088C */ public TkWaterCondition ForceWaterConditionTo;
        [NMS(Index = 398)]
        /* 0x0890 */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        [NMS(Index = 110)]
        /* 0x0894 */ public GameStateModeEnum GameStateMode;
        [NMS(Index = 423)]
        /* 0x0898 */ public float GenerateCostAngle;
        [NMS(Index = 422)]
        /* 0x089C */ public float GenerateCostDistance;
        [NMS(Index = 424)]
        /* 0x08A0 */ public float GenerateCostLOD;
        [NMS(Index = 425)]
        /* 0x08A4 */ public float GenerateCostWait;
        [NMS(Index = 420)]
        /* 0x08A8 */ public int GenerateFarLodBuildingDist;
        [NMS(Index = 336)]
        /* 0x08AC */ public int MaxNumDebugMessages;
        [NMS(Index = 213)]
        /* 0x08B0 */ public float MenuHapticsForgeDuration;
        [NMS(Index = 211)]
        /* 0x08B4 */ public float MenuHapticsForgeIntensity;
        [NMS(Index = 212)]
        /* 0x08B8 */ public float MenuHapticsForgeSharpness;
        // size: 0x2
        public enum MenuHapticsModeEnum : uint {
            UIKitLight,
            ForgeBurst,
        }
        [NMS(Index = 210)]
        /* 0x08BC */ public MenuHapticsModeEnum MenuHapticsMode;
        [NMS(Index = 437)]
        /* 0x08C0 */ public int MoveBaseIndex;
        [NMS(Index = 460)]
        /* 0x08C4 */ public int MultipleFingersSamePressFrameDelta;
        [NMS(Index = 12)]
        /* 0x08C8 */ public GcGameMode NewSaveGameMode;
        [NMS(Index = 330)]
        /* 0x08CC */ public int OverrideCommunityMissionNumber;
        [NMS(Index = 326)]
        /* 0x08D0 */ public int OverrideServerSeasonEndTime;
        [NMS(Index = 325)]
        /* 0x08D4 */ public int OverrideServerSeasonNumber;
        [NMS(Index = 463)]
        /* 0x08D8 */ public float PanDeadzone;
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
        [NMS(Index = 112)]
        /* 0x08DC */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Index = 341)]
        /* 0x08E0 */ public int ProceduralModelBatchSize;
        [NMS(Index = 342)]
        /* 0x08E4 */ public int ProceduralModelFilterMatchretryCount;
        [NMS(Index = 340)]
        /* 0x08E8 */ public int ProceduralModelsShown;
        [NMS(Index = 344)]
        /* 0x08EC */ public int ProceduralModelsThumbnailSize;
        [NMS(Index = 441)]
        /* 0x08F0 */ public int ProfilerPartIndexPhase;
        [NMS(Index = 442)]
        /* 0x08F4 */ public int ProfilerPartIndexStride;
        [NMS(Index = 443)]
        /* 0x08F8 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        [NMS(Index = 304)]
        /* 0x08FC */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        [NMS(Index = 190)]
        /* 0x0900 */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        [NMS(Index = 209)]
        /* 0x0904 */ public RecordSettingEnum RecordSetting;
        [NMS(Index = 226)]
        /* 0x0908 */ public int RecurrenceTimeOffset;
        [NMS(Index = 459)]
        /* 0x090C */ public int ScreenshotForUploadHeight;
        [NMS(Index = 458)]
        /* 0x0910 */ public int ScreenshotForUploadWidth;
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
        [NMS(Index = 306)]
        /* 0x0914 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        [NMS(Index = 119)]
        /* 0x0918 */ public ShaderPreloadEnum ShaderPreload;
        [NMS(Index = 249)]
        /* 0x091C */ public int ShowSpecificGraph;
        [NMS(Index = 265)]
        /* 0x0920 */ public int SmokeTestConfigCaptureCycles;
        [NMS(Index = 266)]
        /* 0x0924 */ public float SmokeTestConfigCaptureDurationInSeconds;
        [NMS(Index = 267)]
        /* 0x0928 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        [NMS(Index = 258)]
        /* 0x092C */ public int SmokeTestConfigPlanetPositionCount;
        [NMS(Index = 260)]
        /* 0x0930 */ public float SmokeTestConfigScenarioLength;
        [NMS(Index = 259)]
        /* 0x0934 */ public float SmokeTestConfigScenarioPreambleLength;
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
        [NMS(Index = 255)]
        /* 0x0938 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
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
        [NMS(Index = 256)]
        /* 0x093C */ public SmokeTestScenarioEnum SmokeTestScenario;
        [NMS(Index = 271)]
        /* 0x0940 */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        [NMS(Index = 118)]
        /* 0x0944 */ public SolarSystemBootEnum SolarSystemBoot;
        [NMS(Index = 102)]
        /* 0x0948 */ public float SprintMultiplier;
        [NMS(Index = 291)]
        /* 0x094C */ public float SunLightScaleGgx;
        [NMS(Index = 461)]
        /* 0x0950 */ public int SwipeDetectionMaxFrames;
        [NMS(Index = 462)]
        /* 0x0954 */ public float SwipeDetectionNormalizedTravelThreshold;
        [NMS(Index = 334)]
        /* 0x0958 */ public int SynergyPort;
        // size: 0x3
        public enum UseBanksEnum : uint {
            False,
            True,
            Default,
        }
        [NMS(Index = 220)]
        /* 0x095C */ public UseBanksEnum UseBanks;
        [NMS(Index = 204)]
        /* 0x0960 */ public float WeaponScale3P;
        [NMS(Index = 194)]
        /* 0x0964 */ public ushort RealityGenerationIteration;
        [NMS(Index = 312)]
        /* 0x0966 */ public NMSString0x800 AutoJoinUserNames;
        [NMS(Index = 80)]
        /* 0x1166 */ public NMSString0x400 DebugTwitchRewards;
        [NMS(Index = 317)]
        /* 0x1566 */ public NMSString0x200 LoadToBase;
        [NMS(Index = 76)]
        /* 0x1766 */ public NMSString0x200 SeasonalDataOverrideFile;
        [NMS(Index = 327)]
        /* 0x1966 */ public NMSString0x100 ForceHgAccount;
        [NMS(Index = 107)]
        /* 0x1A66 */ public NMSString0x100 ForcePlayerPosition;
        [NMS(Index = 104)]
        /* 0x1B66 */ public NMSString0x100 ForceUniverseAddress;
        [NMS(Index = 320)]
        /* 0x1C66 */ public NMSString0x100 GOGLogin;
        [NMS(Index = 245)]
        /* 0x1D66 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        [NMS(Index = 114)]
        /* 0x1E66 */ public NMSString0x100 WorkingDirectory;
        [NMS(Index = 307)]
        /* 0x1F66 */ public NMSString0x80 AuthBaseUrl;
        [NMS(Index = 305)]
        /* 0x1FE6 */ public NMSString0x80 ProxyURI;
        [NMS(Index = 328)]
        /* 0x2066 */ public NMSString0x40 ForceBaseDownloadUser;
        [NMS(Index = 451)]
        /* 0x20A6 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        [NMS(Index = 450)]
        /* 0x20E6 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        [NMS(Index = 457)]
        /* 0x2126 */ public NMSString0x40 ScreenshotForUploadName;
        [NMS(Index = 187)]
        /* 0x2166 */ public NMSString0x20 AllowedLanguagesFile;
        [NMS(Index = 438)]
        /* 0x2186 */ public NMSString0x20 AutomaticPartSpawnID;
        [NMS(Index = 230)]
        /* 0x21A6 */ public NMSString0x20 CrashDumpIdentifier;
        [NMS(Index = 219)]
        /* 0x21C6 */ public NMSString0x20 SaveTestingCommand;
        [NMS(Index = 273)]
        /* 0x21E6 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        [NMS(Index = 274)]
        /* 0x2206 */ public NMSString0x20 SmokeTestRunFolder;
        [NMS(Index = 333)]
        /* 0x2226 */ public NMSString0x20 SynergyServer;
        [NMS(Index = 470)]
        /* 0x2246 */ public bool ActiveMissionsIgnoreStartCancelConditions;
        [NMS(Index = 133)]
        /* 0x2247 */ public bool AllowGalaxyMapRequests;
        [NMS(Index = 433)]
        /* 0x2248 */ public bool AllowGlobalPartSnapping;
        [NMS(Index = 362)]
        /* 0x2249 */ public bool AllowNGuiVR;
        [NMS(Index = 449)]
        /* 0x224A */ public bool AllowOverrideSettlementOwnership;
        [NMS(Index = 81)]
        /* 0x224B */ public bool AllowPause;
        [NMS(Index = 98)]
        /* 0x224C */ public bool AllowPetBattlerPvEOnPvPTable;
        [NMS(Index = 154)]
        /* 0x224D */ public bool AllowRobotBehaviors;
        [NMS(Index = 1)]
        /* 0x224E */ public bool AllowSavingOnAbandonedFreighters;
        [NMS(Index = 161)]
        /* 0x224F */ public bool AllSeasonMilestonesShowComplete;
        [NMS(Index = 82)]
        /* 0x2250 */ public bool AllSettlementsAreCompleted;
        [NMS(Index = 67)]
        /* 0x2251 */ public bool AlternateControls;
        [NMS(Index = 75)]
        /* 0x2252 */ public bool AlwaysAllowFreighterInventoryAccess;
        [NMS(Index = 73)]
        /* 0x2253 */ public bool AlwaysAllowShipOperations;
        [NMS(Index = 151)]
        /* 0x2254 */ public bool AlwaysAllowSpookFiends;
        [NMS(Index = 74)]
        /* 0x2255 */ public bool AlwaysAllowVehicleOperations;
        [NMS(Index = 18)]
        /* 0x2256 */ public bool AlwaysHaveFocus;
        [NMS(Index = 301)]
        /* 0x2257 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        [NMS(Index = 313)]
        /* 0x2258 */ public bool AlwaysSaveGameAsClient;
        [NMS(Index = 247)]
        /* 0x2259 */ public bool AlwaysShowSaveIds;
        [NMS(Index = 68)]
        /* 0x225A */ public bool AlwaysShowURI;
        [NMS(Index = 37)]
        /* 0x225B */ public bool AlwaysSpaceBattle;
        [NMS(Index = 471)]
        /* 0x225C */ public bool AssertIfDiploFound;
        [NMS(Index = 319)]
        /* 0x225D */ public bool AutoJoinRandomGames;
        [NMS(Index = 311)]
        /* 0x225E */ public bool AutoJoinUserEnabled;
        [NMS(Index = 440)]
        /* 0x225F */ public bool AutomaticPartSpawnInactive;
        [NMS(Index = 445)]
        /* 0x2260 */ public bool BaseAdmin;
        [NMS(Index = 86)]
        /* 0x2261 */ public bool BlockCommunicatorSignals;
        [NMS(Index = 452)]
        /* 0x2262 */ public bool BlockSettlementsNetwork;
        [NMS(Index = 39)]
        /* 0x2263 */ public bool BlockSpaceBattle;
        [NMS(Index = 356)]
        /* 0x2264 */ public bool BodyTurning;
        [NMS(Index = 11)]
        /* 0x2265 */ public bool BootDirectlyIntoLastSave;
        [NMS(Index = 203)]
        /* 0x2266 */ public bool BootMusic;
        [NMS(Index = 29)]
        /* 0x2267 */ public bool CanLeaveDialogs;
        [NMS(Index = 308)]
        /* 0x2268 */ public bool CertificateSecurityBypass;
        [NMS(Index = 217)]
        /* 0x2269 */ public bool CheckForMissingLocStrings;
        [NMS(Index = 54)]
        /* 0x226A */ public bool ClothForceAsyncSimulationOff;
        [NMS(Index = 55)]
        /* 0x226B */ public bool ClothForceAsyncSimulationOn;
        [NMS(Index = 53)]
        /* 0x226C */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        [NMS(Index = 50)]
        /* 0x226D */ public bool ClothForcePositionExtrapolationBackOn;
        [NMS(Index = 48)]
        /* 0x226E */ public bool ClothForcePositionExtrapolationOff;
        [NMS(Index = 49)]
        /* 0x226F */ public bool ClothForcePositionExtrapolationOn;
        [NMS(Index = 52)]
        /* 0x2270 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        [NMS(Index = 51)]
        /* 0x2271 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        [NMS(Index = 279)]
        /* 0x2272 */ public bool CompressTextures;
        [NMS(Index = 228)]
        /* 0x2273 */ public bool CrashDumpFull;
        [NMS(Index = 93)]
        /* 0x2274 */ public bool CrashOnF10;
        [NMS(Index = 275)]
        /* 0x2275 */ public bool CreatureChatter;
        [NMS(Index = 277)]
        /* 0x2276 */ public bool CreatureDrawVocals;
        [NMS(Index = 276)]
        /* 0x2277 */ public bool CreatureErrors;
        [NMS(Index = 447)]
        /* 0x2278 */ public bool CrossPlatformFeaturedBases;
        [NMS(Index = 427)]
        /* 0x2279 */ public bool DChecksEnabled;
        [NMS(Index = 429)]
        /* 0x227A */ public bool DChecksOutputBinary;
        [NMS(Index = 430)]
        /* 0x227B */ public bool DChecksOutputFileLine;
        [NMS(Index = 428)]
        /* 0x227C */ public bool DChecksOutputJson;
        [NMS(Index = 214)]
        /* 0x227D */ public bool DebugBuildingSpawns;
        [NMS(Index = 284)]
        /* 0x227E */ public bool DebugDepthReprojection;
        [NMS(Index = 179)]
        /* 0x227F */ public bool DebugDrawPlayerInteract;
        [NMS(Index = 20)]
        /* 0x2280 */ public bool DebugGalaxyMapInQuickMenu;
        [NMS(Index = 280)]
        /* 0x2281 */ public bool DebugIBL;
        [NMS(Index = 218)]
        /* 0x2282 */ public bool DebugNetworkLocks;
        [NMS(Index = 191)]
        /* 0x2283 */ public bool DebugPersistentInteractions;
        [NMS(Index = 283)]
        /* 0x2284 */ public bool DebugRenderSpaceOffset;
        [NMS(Index = 281)]
        /* 0x2285 */ public bool DebugSpotlights;
        [NMS(Index = 282)]
        /* 0x2286 */ public bool DebugTerrainTextures;
        [NMS(Index = 231)]
        /* 0x2287 */ public bool DebugThreatLevels;
        [NMS(Index = 421)]
        /* 0x2288 */ public bool DeferRegionBodies;
        [NMS(Index = 2)]
        /* 0x2289 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Index = 431)]
        /* 0x228A */ public bool DisableBaseBuilding;
        [NMS(Index = 432)]
        /* 0x228B */ public bool DisableBaseBuildingLimits;
        [NMS(Index = 435)]
        /* 0x228C */ public bool DisableBasePowerRequirements;
        [NMS(Index = 296)]
        /* 0x228D */ public bool DisableClouds;
        [NMS(Index = 43)]
        /* 0x228E */ public bool DisableContinuousSaving;
        [NMS(Index = 444)]
        /* 0x228F */ public bool DisableCorvetteSwapParts;
        [NMS(Index = 94)]
        /* 0x2290 */ public bool DisableCorvetteValidation;
        [NMS(Index = 174)]
        /* 0x2291 */ public bool DisableDebugControls;
        [NMS(Index = 178)]
        /* 0x2292 */ public bool DisableDiscoveryNaming;
        [NMS(Index = 225)]
        /* 0x2293 */ public bool DisableFileWatcher;
        [NMS(Index = 28)]
        /* 0x2294 */ public bool DisableHazards;
        [NMS(Index = 360)]
        /* 0x2295 */ public bool DisableHeadConstraints;
        [NMS(Index = 44)]
        /* 0x2296 */ public bool DisableInvalidSaveVersion;
        [NMS(Index = 359)]
        /* 0x2297 */ public bool DisableLeftHand;
        [NMS(Index = 415)]
        /* 0x2298 */ public bool DisableLimits;
        [NMS(Index = 472)]
        /* 0x2299 */ public bool DisableMissionShop;
        [NMS(Index = 314)]
        /* 0x229A */ public bool DisableMonumentDownloads;
        [NMS(Index = 64, MxmlName = "DisableNPCHiddenUntilScanned ")]
        /* 0x229B */ public bool DisableNPCHiddenUntilScanned;
        [NMS(Index = 63)]
        /* 0x229C */ public bool DisableNPCs;
        [NMS(Index = 454)]
        /* 0x229D */ public bool DisablePartialStories;
        [NMS(Index = 100)]
        /* 0x229E */ public bool DisablePetBattlerSpectatorWelcomeMessageForSwitch2;
        [NMS(Index = 224)]
        /* 0x229F */ public bool DisableProfanityFilter;
        [NMS(Index = 41)]
        /* 0x22A0 */ public bool DisableSaveSlotSorting;
        [NMS(Index = 329)]
        /* 0x22A1 */ public bool DisableSaveUploadRateLimits;
        [NMS(Index = 42)]
        /* 0x22A2 */ public bool DisableSaving;
        [NMS(Index = 83)]
        /* 0x22A3 */ public bool DisableSettlements;
        [NMS(Index = 285)]
        /* 0x22A4 */ public bool DisableShadowSwitching;
        [NMS(Index = 198)]
        /* 0x22A5 */ public bool DisableShipSaveDataRecovery;
        [NMS(Index = 310)]
        /* 0x22A6 */ public bool DisableSpaceStationSpawnOnJoin;
        [NMS(Index = 45)]
        /* 0x22A7 */ public bool DisableStorms;
        [NMS(Index = 19)]
        /* 0x22A8 */ public bool DisableVibration;
        [NMS(Index = 188)]
        /* 0x22A9 */ public bool DoAlienLanguage;
        [NMS(Index = 278)]
        /* 0x22AA */ public bool DrawCreaturesInRoutines;
        [NMS(Index = 232)]
        /* 0x22AB */ public bool DumpManifestContents;
        [NMS(Index = 453)]
        /* 0x22AC */ public bool EnableAccessibleUI;
        [NMS(Index = 164)]
        /* 0x22AD */ public bool EnableBaseBuildingExpandables;
        [NMS(Index = 436)]
        /* 0x22AE */ public bool EnableBaseMovingOption;
        [NMS(Index = 140)]
        /* 0x22AF */ public bool EnableCloudAnimation;
        [NMS(Index = 292)]
        /* 0x22B0 */ public bool EnableComputePost;
        [NMS(Index = 172)]
        /* 0x22B1 */ public bool EnableCustomSolarSystemMapMaterials;
        [NMS(Index = 150)]
        /* 0x22B2 */ public bool EnableDayNightCycle;
        [NMS(Index = 117)]
        /* 0x22B3 */ public bool EnableDebugSceneAutoSave;
        [NMS(Index = 131)]
        /* 0x22B4 */ public bool EnableFrontendPreload;
        [NMS(Index = 162)]
        /* 0x22B5 */ public bool EnableGalaxyRecolouring;
        [NMS(Index = 165)]
        /* 0x22B6 */ public bool EnableGameTables;
        [NMS(Index = 290)]
        /* 0x22B7 */ public bool EnableGgx;
        [NMS(Index = 85)]
        /* 0x22B8 */ public bool EnableMemoryPoolAllocPrint;
        [NMS(Index = 168)]
        /* 0x22B9 */ public bool EnableNearbySolarSystemWarpMarkers;
        [NMS(Index = 96)]
        /* 0x22BA */ public bool EnablePetBattlerRandomPets;
        [NMS(Index = 97)]
        /* 0x22BB */ public bool EnablePetBattlerTurnTimeoutInPvE;
        [NMS(Index = 361)]
        /* 0x22BC */ public bool EnablePhotomodeVR;
        [NMS(Index = 167)]
        /* 0x22BD */ public bool EnableSolarSystemMap;
        [NMS(Index = 332)]
        /* 0x22BE */ public bool EnableSynergy;
        [NMS(Index = 88)]
        /* 0x22BF */ public bool EnableTouchScreenDebugging;
        [NMS(Index = 169)]
        /* 0x22C0 */ public bool EnableWeaponSelectWheel;
        [NMS(Index = 95)]
        /* 0x22C1 */ public bool EnforceCorvetteComplexityLimit;
        [NMS(Index = 24)]
        /* 0x22C2 */ public bool EverythingIsFree;
        [NMS(Index = 25)]
        /* 0x22C3 */ public bool EverythingIsKnown;
        [NMS(Index = 26)]
        /* 0x22C4 */ public bool EverythingIsStar;
        [NMS(Index = 322)]
        /* 0x22C5 */ public bool FakeHandsInMultiplayer;
        [NMS(Index = 40)]
        /* 0x22C6 */ public bool FastAndFrequentFleetInterventions;
        [NMS(Index = 9)]
        /* 0x22C7 */ public bool FastLoad;
        [NMS(Index = 175)]
        /* 0x22C8 */ public bool FixedFramerate;
        [NMS(Index = 206)]
        /* 0x22C9 */ public bool FleetDirectorAutoMode;
        [NMS(Index = 469)]
        /* 0x22CA */ public bool ForceAllExhibitsToBeEditable;
        [NMS(Index = 201)]
        /* 0x22CB */ public bool ForceBasicLoadScreen;
        [NMS(Index = 394)]
        /* 0x22CC */ public bool ForceBinaryStar;
        [NMS(Index = 370)]
        /* 0x22CD */ public bool ForceBiome;
        [NMS(Index = 373)]
        /* 0x22CE */ public bool ForceBiomeMaintainsTerrain;
        [NMS(Index = 66)]
        /* 0x22CF */ public bool ForceBuildersAlwaysKnown;
        [NMS(Index = 376)]
        /* 0x22D0 */ public bool ForceBuildingRace;
        [NMS(Index = 366)]
        /* 0x22D1 */ public bool ForceCorruptSentinels;
        [NMS(Index = 380)]
        /* 0x22D2 */ public bool ForceCreatureLifeLevel;
        [NMS(Index = 381)]
        /* 0x22D3 */ public bool ForceDefaultCreatureFile;
        [NMS(Index = 474)]
        /* 0x22D4 */ public bool ForceDeliveryDropOffSuccess;
        [NMS(Index = 47)]
        /* 0x22D5 */ public bool ForceDisableClothComponent;
        [NMS(Index = 60)]
        /* 0x22D6 */ public bool ForceDisableNonPlayerRagdollComponents;
        [NMS(Index = 59)]
        /* 0x22D7 */ public bool ForceDisableRagdollComponent;
        [NMS(Index = 62)]
        /* 0x22D8 */ public bool ForceDisableSeparatePhysicsWorlds;
        [NMS(Index = 61)]
        /* 0x22D9 */ public bool ForceDisableSplitIkOptimisation;
        [NMS(Index = 57)]
        /* 0x22DA */ public bool ForceDisableSpringComponent;
        [NMS(Index = 99)]
        /* 0x22DB */ public bool ForceDiscoverAllSpacePoi;
        [NMS(Index = 46)]
        /* 0x22DC */ public bool ForceEnableClothComponent;
        [NMS(Index = 58)]
        /* 0x22DD */ public bool ForceEnableRagdollComponent;
        [NMS(Index = 56)]
        /* 0x22DE */ public bool ForceEnableSpringComponent;
        [NMS(Index = 365)]
        /* 0x22DF */ public bool ForceExtremeSentinels;
        [NMS(Index = 364)]
        /* 0x22E0 */ public bool ForceExtremeWeather;
        [NMS(Index = 125)]
        /* 0x22E1 */ public bool ForceFrontendPersonalityTest;
        [NMS(Index = 92)]
        /* 0x22E2 */ public bool ForceFullFeatureMode;
        [NMS(Index = 392)]
        /* 0x22E3 */ public bool ForceGasGiantSystem;
        [NMS(Index = 391)]
        /* 0x22E4 */ public bool ForceGiantSystem;
        [NMS(Index = 108)]
        /* 0x22E5 */ public bool ForceInitialShip;
        [NMS(Index = 109)]
        /* 0x22E6 */ public bool ForceInitialWeapon;
        [NMS(Index = 180)]
        /* 0x22E7 */ public bool ForceInteractionToSettings;
        [NMS(Index = 378)]
        /* 0x22E8 */ public bool ForceLifeLevel;
        [NMS(Index = 368)]
        /* 0x22E9 */ public bool ForceLoadAllWeather;
        [NMS(Index = 160)]
        /* 0x22EA */ public bool ForceNexusInQuickMenu;
        [NMS(Index = 390)]
        /* 0x22EB */ public bool ForcePirateSystem;
        [NMS(Index = 410)]
        /* 0x22EC */ public bool ForcePlanetsToHaveNoCaves;
        [NMS(Index = 411)]
        /* 0x22ED */ public bool ForcePlanetsToHaveNoNoiseLayers;
        [NMS(Index = 412)]
        /* 0x22EE */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        [NMS(Index = 409)]
        /* 0x22EF */ public bool ForcePlanetsToHaveNoWater;
        [NMS(Index = 397)]
        /* 0x22F0 */ public bool ForcePlanetsToHaveWater;
        [NMS(Index = 393)]
        /* 0x22F1 */ public bool ForcePrimeTerrain;
        [NMS(Index = 200)]
        /* 0x22F2 */ public bool ForcePurpleSystemsToAlwaysBirth;
        [NMS(Index = 199)]
        /* 0x22F3 */ public bool ForcePurpleSystemsVisibleOnLoad;
        [NMS(Index = 413)]
        /* 0x22F4 */ public bool ForceRareAsteroidSystem;
        [NMS(Index = 475)]
        /* 0x22F5 */ public bool ForceScanEventsToGoPrime;
        [NMS(Index = 476)]
        /* 0x22F6 */ public bool ForceScanEventsToSpecificGrassColour;
        [NMS(Index = 363)]
        /* 0x22F7 */ public bool ForceScrapWorlds;
        [NMS(Index = 374)]
        /* 0x22F8 */ public bool ForceScreenFilter;
        [NMS(Index = 323)]
        /* 0x22F9 */ public bool ForceSmallLobby;
        [NMS(Index = 404)]
        /* 0x22FA */ public bool ForceSpaceSkyColourRare;
        [NMS(Index = 367)]
        /* 0x22FB */ public bool ForceStarType;
        [NMS(Index = 128)]
        /* 0x22FC */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Index = 395)]
        /* 0x22FD */ public bool ForceTernaryStar;
        [NMS(Index = 388)]
        /* 0x22FE */ public bool ForceTerrainType;
        [NMS(Index = 91)]
        /* 0x22FF */ public bool ForceTgaDlc;
        [NMS(Index = 324)]
        /* 0x2300 */ public bool ForceTinyLobby;
        [NMS(Index = 34)]
        /* 0x2301 */ public bool ForceTranslateAllAlienText;
        [NMS(Index = 105)]
        /* 0x2302 */ public bool ForceUniverseAddressFromChangelist;
        [NMS(Index = 477)]
        /* 0x2303 */ public bool ForceUnlockOutpostMissionBoard;
        [NMS(Index = 21)]
        /* 0x2304 */ public bool ForceUnlockSolarSystemMap;
        [NMS(Index = 400)]
        /* 0x2305 */ public bool ForceWaterCondition;
        [NMS(Index = 170)]
        /* 0x2306 */ public bool ForceWeaponWheelDisplay;
        [NMS(Index = 197)]
        /* 0x2307 */ public bool FormatDownloadStorageAreaOnBoot;
        [NMS(Index = 15)]
        /* 0x2308 */ public bool GodMode;
        [NMS(Index = 250)]
        /* 0x2309 */ public bool GraphCommandBuffer;
        [NMS(Index = 252)]
        /* 0x230A */ public bool GraphFPS;
        [NMS(Index = 251)]
        /* 0x230B */ public bool GraphGeneration;
        [NMS(Index = 253)]
        /* 0x230C */ public bool GraphTexStreaming;
        [NMS(Index = 221)]
        /* 0x230D */ public bool HangOnCrash;
        [NMS(Index = 352)]
        /* 0x230E */ public bool HmdFrameShiftEnabled;
        [NMS(Index = 355)]
        /* 0x230F */ public bool HmdShowEyeAimTarget;
        [NMS(Index = 354)]
        /* 0x2310 */ public bool HmdShowTrackedEyePos;
        [NMS(Index = 353)]
        /* 0x2311 */ public bool HmdUseSolidGuiPointer;
        [NMS(Index = 222)]
        /* 0x2312 */ public bool HotReloadModGlobals;
        [NMS(Index = 35)]
        /* 0x2313 */ public bool IgnoreFreighterSpawnWarpRequirement;
        [NMS(Index = 478)]
        /* 0x2314 */ public bool IgnoreMissionRank;
        [NMS(Index = 163)]
        /* 0x2315 */ public bool IgnoreSteamDev;
        [NMS(Index = 318)]
        /* 0x2316 */ public bool IgnoreTransactionTimeouts;
        [NMS(Index = 184)]
        /* 0x2317 */ public bool InfiniteInteractions;
        [NMS(Index = 27)]
        /* 0x2318 */ public bool InfiniteStamina;
        [NMS(Index = 157)]
        /* 0x2319 */ public bool InstanceCollision;
        [NMS(Index = 183)]
        /* 0x231A */ public bool InteractionsAllwaysGivesTech;
        [NMS(Index = 419)]
        /* 0x231B */ public bool LimitGlobalBodies;
        [NMS(Index = 418)]
        /* 0x231C */ public bool LimitGlobalInstances;
        [NMS(Index = 417)]
        /* 0x231D */ public bool LimitPerRegionBodies;
        [NMS(Index = 416)]
        /* 0x231E */ public bool LimitPerRegionInstances;
        [NMS(Index = 295)]
        /* 0x231F */ public bool LoadShaderSourceIfRenderdocEnabled;
        [NMS(Index = 72)]
        /* 0x2320 */ public bool LockAllTitles;
        [NMS(Index = 205)]
        /* 0x2321 */ public bool LogMissingLocalisedText;
        [NMS(Index = 23)]
        /* 0x2322 */ public bool MapWarpCheckIgnoreDrive;
        [NMS(Index = 22)]
        /* 0x2323 */ public bool MapWarpCheckIgnoreFuel;
        [NMS(Index = 36)]
        /* 0x2324 */ public bool MaximumFreighterSpawns;
        [NMS(Index = 173)]
        /* 0x2325 */ public bool MeltdownsEnabled;
        [NMS(Index = 124)]
        /* 0x2326 */ public bool MemCsv;
        [NMS(Index = 479)]
        /* 0x2327 */ public bool MissionMessageLoggingEnabled;
        [NMS(Index = 480)]
        /* 0x2328 */ public bool MissionNGUIShowsConditionResults;
        [NMS(Index = 481)]
        /* 0x2329 */ public bool MissionNGUIShowsTableNames;
        [NMS(Index = 482)]
        /* 0x232A */ public bool MissionSurveyEnabled;
        [NMS(Index = 408)]
        /* 0x232B */ public bool ModifyPlanetsInInitialSystems;
        [NMS(Index = 483)]
        /* 0x232C */ public bool MPMissions;
        [NMS(Index = 484)]
        /* 0x232D */ public bool MPMissionsAlwaysEPIC;
        [NMS(Index = 159)]
        /* 0x232E */ public bool MultiplePlayerFreightersInASystem;
        [NMS(Index = 171)]
        /* 0x232F */ public bool NexusBots;
        [NMS(Index = 84)]
        /* 0x2330 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        [NMS(Index = 337)]
        /* 0x2331 */ public bool PreloadToolbox;
        [NMS(Index = 240)]
        /* 0x2332 */ public bool PrintAvgFrameTimes;
        [NMS(Index = 343)]
        /* 0x2333 */ public bool ProceduralModelsDeterministicSequence;
        [NMS(Index = 293)]
        /* 0x2334 */ public bool Proto2DevKit;
        [NMS(Index = 321)]
        /* 0x2335 */ public bool RecordNetworkStatsOnBoot;
        [NMS(Index = 32)]
        /* 0x2336 */ public bool RenderCreatureDetails;
        [NMS(Index = 177)]
        /* 0x2337 */ public bool RenderHud;
        [NMS(Index = 289)]
        /* 0x2338 */ public bool RenderLowFramerate;
        [NMS(Index = 130)]
        /* 0x2339 */ public bool ResetForcedSaveSlotOnLoad;
        [NMS(Index = 103)]
        /* 0x233A */ public bool ResetToSupportedResolution;
        [NMS(Index = 70)]
        /* 0x233B */ public bool RevealAllTitles;
        [NMS(Index = 223)]
        /* 0x233C */ public bool SaveOutModdedMetadata;
        [NMS(Index = 468)]
        /* 0x233D */ public bool ScratchpadPlanetEnvironment;
        [NMS(Index = 176)]
        /* 0x233E */ public bool ScreenshotMode;
        [NMS(Index = 122)]
        /* 0x233F */ public bool ShaderCaching;
        [NMS(Index = 120)]
        /* 0x2340 */ public bool ShaderPreloadListExport;
        [NMS(Index = 121)]
        /* 0x2341 */ public bool ShaderPreloadListImport;
        [NMS(Index = 65)]
        /* 0x2342 */ public bool ShipSalvageGivesAllParts;
        [NMS(Index = 303)]
        /* 0x2343 */ public bool ShowAtlasErrorOSD;
        [NMS(Index = 233)]
        /* 0x2344 */ public bool ShowDebugMessages;
        [NMS(Index = 236)]
        /* 0x2345 */ public bool ShowDynamicResScale;
        [NMS(Index = 335)]
        /* 0x2346 */ public bool ShowEditorPlacementPreview;
        [NMS(Index = 69)]
        /* 0x2347 */ public bool ShowFireteamMembersUA;
        [NMS(Index = 234)]
        /* 0x2348 */ public bool ShowFramerate;
        [NMS(Index = 242)]
        /* 0x2349 */ public bool ShowGPUMemory;
        [NMS(Index = 235)]
        /* 0x234A */ public bool ShowGPURenderTime;
        [NMS(Index = 248)]
        /* 0x234B */ public bool ShowGraphs;
        [NMS(Index = 357)]
        /* 0x234C */ public bool ShowHmdHandControllers;
        [NMS(Index = 216)]
        /* 0x234D */ public bool ShowLongestStrings;
        [NMS(Index = 243)]
        /* 0x234E */ public bool ShowMempoolOverlay;
        [NMS(Index = 485)]
        /* 0x234F */ public bool ShowMissionIdInTitle;
        [NMS(Index = 244)]
        /* 0x2350 */ public bool ShowMouseSmoothing;
        [NMS(Index = 241)]
        /* 0x2351 */ public bool ShowPositionDebug;
        [NMS(Index = 246)]
        /* 0x2352 */ public bool ShowRenderStatsDisplay;
        [NMS(Index = 358)]
        /* 0x2353 */ public bool ShowTeleportEffectLocally;
        [NMS(Index = 89)]
        /* 0x2354 */ public bool ShowTouchFingerCircles;
        [NMS(Index = 294)]
        /* 0x2355 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 302)]
        /* 0x2356 */ public bool SimulateNoNetworkConnection;
        [NMS(Index = 0)]
        /* 0x2357 */ public bool SkipAbandonedFreighterUnlocking;
        [NMS(Index = 6)]
        /* 0x2358 */ public bool SkipIntro;
        [NMS(Index = 7)]
        /* 0x2359 */ public bool SkipLogos;
        [NMS(Index = 13)]
        /* 0x235A */ public bool SkipPlanetDiscoverOnBoot;
        [NMS(Index = 33)]
        /* 0x235B */ public bool SkipTutorial;
        [NMS(Index = 8)]
        /* 0x235C */ public bool SkipUITimers;
        [NMS(Index = 262)]
        /* 0x235D */ public bool SmokeTestCameraFly;
        [NMS(Index = 268)]
        /* 0x235E */ public bool SmokeTestConfigRandomizePlanetSeed;
        [NMS(Index = 254)]
        /* 0x235F */ public bool SmokeTestDumpStatsMode;
        [NMS(Index = 261)]
        /* 0x2360 */ public bool SmokeTestFastExit;
        [NMS(Index = 257)]
        /* 0x2361 */ public bool SmokeTestLegacyOutput;
        [NMS(Index = 263)]
        /* 0x2362 */ public bool SmokeTestOutputOnly;
        [NMS(Index = 272)]
        /* 0x2363 */ public bool SmokeTestPostBandwidthStats;
        [NMS(Index = 264)]
        /* 0x2364 */ public bool SmokeTestPureFlight;
        [NMS(Index = 270)]
        /* 0x2365 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 269)]
        /* 0x2366 */ public bool SmokeTestSmokeBotEnabled;
        [NMS(Index = 152)]
        /* 0x2367 */ public bool SpawnPirates;
        [NMS(Index = 156)]
        /* 0x2368 */ public bool SpawnPulseEncounters;
        [NMS(Index = 153)]
        /* 0x2369 */ public bool SpawnRobots;
        [NMS(Index = 155)]
        /* 0x236A */ public bool SpawnShips;
        [NMS(Index = 158)]
        /* 0x236B */ public bool SpecialsShop;
        [NMS(Index = 298)]
        /* 0x236C */ public bool SpotlightsTiledOn;
        [NMS(Index = 297)]
        /* 0x236D */ public bool SpotlightsTiledSettings;
        [NMS(Index = 300)]
        /* 0x236E */ public bool SpotlightsTiledVisualise;
        [NMS(Index = 299)]
        /* 0x236F */ public bool SpotlightsTiledZBins;
        [NMS(Index = 101)]
        /* 0x2370 */ public bool StartAsOrb;
        [NMS(Index = 185)]
        /* 0x2371 */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Index = 215)]
        /* 0x2372 */ public bool StressTestLongNameDisplay;
        [NMS(Index = 17)]
        /* 0x2373 */ public bool SuperKillGuns;
        [NMS(Index = 134)]
        /* 0x2374 */ public bool SuppressSeasonalRewardReminders;
        [NMS(Index = 16)]
        /* 0x2375 */ public bool TakeNoDamage;
        [NMS(Index = 4)]
        /* 0x2376 */ public bool ThirdPersonIsDefaultCameraForPlayer;
        [NMS(Index = 5)]
        /* 0x2377 */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        [NMS(Index = 79)]
        /* 0x2378 */ public bool UnlockAllPlatformRewards;
        [NMS(Index = 77)]
        /* 0x2379 */ public bool UnlockAllSeasonRewards;
        [NMS(Index = 455)]
        /* 0x237A */ public bool UnlockAllStories;
        [NMS(Index = 71)]
        /* 0x237B */ public bool UnlockAllTitles;
        [NMS(Index = 78)]
        /* 0x237C */ public bool UnlockAllTwitchRewards;
        [NMS(Index = 456)]
        /* 0x237D */ public bool UnlockAllWords;
        [NMS(Index = 166)]
        /* 0x237E */ public bool UpdateMarkersJob;
        [NMS(Index = 137)]
        /* 0x237F */ public bool UseBloom;
        [NMS(Index = 144)]
        /* 0x2380 */ public bool UseBuildings;
        [NMS(Index = 138)]
        /* 0x2381 */ public bool UseClouds;
        [NMS(Index = 145)]
        /* 0x2382 */ public bool UseCreatures;
        [NMS(Index = 146)]
        /* 0x2383 */ public bool UseElevation;
        [NMS(Index = 139)]
        /* 0x2384 */ public bool UseGTAO;
        [NMS(Index = 31)]
        /* 0x2385 */ public bool UseGunImpactEffect;
        [NMS(Index = 192)]
        /* 0x2386 */ public bool UseHighlightedOptionStyle;
        [NMS(Index = 90)]
        /* 0x2387 */ public bool UseImmediateModeFrontend;
        [NMS(Index = 142)]
        /* 0x2388 */ public bool UseInstances;
        [NMS(Index = 149)]
        /* 0x2389 */ public bool UseLegacyBuildingTable;
        [NMS(Index = 147)]
        /* 0x238A */ public bool UseLegacyFreighters;
        [NMS(Index = 148)]
        /* 0x238B */ public bool UseLegacySpaceStations;
        [NMS(Index = 87)]
        /* 0x238C */ public bool UseMovementStickForRun;
        [NMS(Index = 143)]
        /* 0x238D */ public bool UseObjects;
        [NMS(Index = 426)]
        /* 0x238E */ public bool UseOldTerrainMeshing;
        [NMS(Index = 315)]
        /* 0x238F */ public bool UsePadOnUnfocusedWindow;
        [NMS(Index = 135)]
        /* 0x2390 */ public bool UseParticles;
        [NMS(Index = 339)]
        /* 0x2391 */ public bool UseProcTextureDebugger;
        [NMS(Index = 132)]
        /* 0x2392 */ public bool UseSceneInfoWindow;
        [NMS(Index = 30)]
        /* 0x2393 */ public bool UseScreenEffects;
        [NMS(Index = 466)]
        /* 0x2394 */ public bool UseSeasonTransferInventoryConfigOverride;
        [NMS(Index = 141)]
        /* 0x2395 */ public bool UseTerrain;
        [NMS(Index = 136)]
        /* 0x2396 */ public bool UseVolumetrics;
        [NMS(Index = 14)]
        /* 0x2397 */ public bool VideoCaptureMode;
        [NMS(Index = 331)]
        /* 0x2398 */ public bool VisualiseNetReplicatedEntityOwnership;
    }
}

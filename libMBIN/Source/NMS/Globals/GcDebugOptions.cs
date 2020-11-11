using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1FE0, GUID = 0xDE8EC1FE3A23726E)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public bool ForceScanEventsToGoPrime;
        /* 0x0001 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x0002 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x0003 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0004 */ public byte[] Padding4;
        /* 0x0008 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x0010 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x0011 */ public bool SkipIntro;
        /* 0x0012 */ public bool SkipLogos;
        /* 0x0014 */ public int BootDirectlyIntoSaveSlot;
        /* 0x0018 */ public bool BootDirectlyIntoLastSave;
        /* 0x001C */ public GcGameMode NewSaveGameMode;
        /* 0x0020 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x0021 */ public bool VideoCaptureMode;
        /* 0x0022 */ public bool GodMode;
        /* 0x0023 */ public bool TakeNoDamage;
        /* 0x0024 */ public bool AlwaysHaveFocus;
        /* 0x0025 */ public bool DisableVibration;
        /* 0x0026 */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x0027 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x0028 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x0029 */ public bool EverythingIsFree;
        /* 0x002A */ public bool EverythingIsKnown;
        /* 0x002B */ public bool EverythingIsStar;
        /* 0x002C */ public bool InfiniteStamina;
        /* 0x002D */ public bool DisableHazards;
        /* 0x002E */ public bool IgnoreMissionRank;
        /* 0x002F */ public bool CanLeaveDialogs;
        /* 0x0030 */ public bool DisableOldMissions;
        /* 0x0031 */ public bool UseScreenEffects;
        /* 0x0032 */ public bool UseGunImpactEffect;
        /* 0x0033 */ public bool RenderCreatureDetails;
        /* 0x0034 */ public bool SkipTutorial;
        /* 0x0035 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x0036 */ public bool MaximumFreighterSpawns;
        /* 0x0037 */ public bool DisableSaveSlotSorting;
        /* 0x0038 */ public bool DisableSaving;
        /* 0x0039 */ public bool DisableStorms;
        /* 0x003A */ public bool AlternateControls;
        /* 0x003B */ public bool AlwaysShowURI;
        /* 0x003C */ public bool MPMissionsAlwaysEPIC;
        /* 0x003D */ public bool ShowFireteamMembersUA;
        /* 0x003E */ public bool RevealAllTitles;
        /* 0x003F */ public bool UnlockAllTitles;
        /* 0x0040 */ public bool LockAllTitles;
        /* 0x0041 */ public bool AlwaysAllowShipOperations;
        /* 0x0042 */ public bool AlwaysAllowVehicleOperations;
        /* 0x0043 */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x0044 */ public bool UseDebugScreenSettings;
        /* 0x0048 */ public int ScreenWidth;
        /* 0x004C */ public int ScreenHeight;
        /* 0x0050 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
        /* 0x0054 */ public GameWindowModeEnum GameWindowMode;
        /* 0x0058 */ public int Monitor;
        /* 0x005C */ public int TiledWindowsSplitCount;
        /* 0x0060 */ public int TiledWindowsIndex;
        [NMS(Size = 0x100)]
        /* 0x0064 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x0164 */ public string ForcePlayerPosition;
        /* 0x0264 */ public bool ForceInitialShip;
        /* 0x0265 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
        /* 0x0268 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
        /* 0x026C */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation }
        /* 0x0270 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x0274 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x02F4 */ public string WorkingDirectory;
        [NMS(Size = 0x80)]
        /* 0x03F4 */ public string DebugScene;
		public enum SolarSystemBootEnum { FromSettings, Generate }
        /* 0x0474 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
        /* 0x0478 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x047C */ public bool ShaderPreloadListExport;
        /* 0x047D */ public bool ShaderPreloadListImport;
        /* 0x047E */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
        /* 0x0480 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0484 */ public bool MemCsv;
        /* 0x0488 */ public float ForceTimeOfDay;
        /* 0x048C */ public float ForceInitialTimeOfDay;
        /* 0x0490 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0494 */ public float ForceSunAngle;
        /* 0x0498 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0499 */ public bool UseParticles;
        /* 0x049A */ public bool UseHeavyAir;
        /* 0x049B */ public bool UseVolumetrics;
        /* 0x049C */ public bool UseClouds;
        /* 0x049D */ public bool EnableCloudAnimation;
        /* 0x049E */ public bool UseTerrain;
        /* 0x049F */ public bool UseInstances;
        /* 0x04A0 */ public bool UseObjects;
        /* 0x04A1 */ public bool UseBuildings;
        /* 0x04A2 */ public bool UseCreatures;
        /* 0x04A3 */ public bool UseElevation;
        /* 0x04A4 */ public bool UseLegacyFreighters;
        /* 0x04A5 */ public bool UseLegacyBuildingTable;
        /* 0x04A6 */ public bool EnableDayNightCycle;
        /* 0x04A7 */ public bool SpawnPirates;
        /* 0x04A8 */ public bool SpawnRobots;
        /* 0x04A9 */ public bool SpawnShips;
        /* 0x04AA */ public bool SpawnPulseEncounters;
        /* 0x04AB */ public bool InstanceCollision;
        /* 0x04AC */ public bool LoadMissions;
        /* 0x04AD */ public bool MPMissions;
        /* 0x04AE */ public bool SpecialsShop;
        /* 0x04AF */ public bool MultiplePlayerFreightersInASystem;
        /* 0x04B0 */ public bool ForceNexusInQuickMenu;
        /* 0x04B1 */ public bool MissionSurveyEnabled;
        /* 0x04B2 */ public bool MouseLookEnabled;
        /* 0x04B3 */ public bool StartPaused;
        /* 0x04B4 */ public bool DisableDebugControls;
        /* 0x04B5 */ public bool FixedFramerate;
        /* 0x04B6 */ public bool ScreenshotMode;
        /* 0x04B7 */ public bool RenderHud;
        /* 0x04B8 */ public bool DisableDiscoveryNaming;
        /* 0x04B9 */ public bool DebugDrawPlayerInteract;
        /* 0x04BA */ public bool ForceInteractionToSettings;
        /* 0x04BC */ public int ForceInteractionIndex;
        /* 0x04C0 */ public bool InteractionsAllwaysGivesTech;
        /* 0x04C1 */ public bool InfiniteInteractions;
        /* 0x04C2 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x04C4 */ public TkLanguages DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x04C8 */ public string AllowedLanguagesFile;
        /* 0x04E8 */ public bool DoAlienLanguage;
        /* 0x04EC */ public GcAlienRace ForceInteractionRaceTo;
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x04F0 */ public RealityModeEnum RealityMode;
        /* 0x04F4 */ public bool DebugPersistentInteractions;
        /* 0x04F5 */ public bool DisableMissionShop;
        [NMS(Size = 0x80)]
        /* 0x04F6 */ public string RealityPresetFile;
        /* 0x0576 */ public ushort RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x0578 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x0618 */ public string DefaultSaveData;
        /* 0x0698 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0699 */ public bool ForceBasicLoadScreen;
        /* 0x069C */ public float BootLogoFadeRate;
        /* 0x06A0 */ public bool BootMusic;
        /* 0x06A4 */ public float WeaponScale3P;
        /* 0x06A8 */ public bool LogMissingLocalisedText;
        /* 0x06A9 */ public bool FleetDirectorAutoMode;
        /* 0x06AC */ public float _3dTextDistance;
        /* 0x06B0 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
        /* 0x06B4 */ public RecordSettingEnum RecordSetting;
        /* 0x06B8 */ public bool DebugBuildingSpawns;
        /* 0x06B9 */ public bool StressTestLongNameDisplay;
        /* 0x06BA */ public bool ShowLongestStrings;
        [NMS(Size = 0x20)]
        /* 0x06BB */ public string SaveTestingCommand;
        /* 0x06DB */ public bool NeverUseBanks;
        /* 0x06DC */ public bool DisableProfanityFilter;
        /* 0x06DD */ public bool DisableFileWatcher;
        /* 0x06DE */ public bool DisableShaderReload;
        /* 0x06E0 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x06E4 */ public string CrashDumpPath;
        [NMS(Size = 0x20)]
        /* 0x0764 */ public string CrashDumpIdentifier;
        /* 0x0784 */ public bool EnableLivePP;
        /* 0x0785 */ public bool DebugThreatLevels;
        /* 0x0786 */ public bool ShowDebugMessages;
        /* 0x0787 */ public bool ShowFramerate;
        /* 0x0788 */ public bool PrintAvgFrameTimes;
        /* 0x0789 */ public bool ShowPositionDebug;
        /* 0x078A */ public bool ShowGPUMemory;
        /* 0x078B */ public bool ShowMempoolOverlay;
        /* 0x078C */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x078D */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x088D */ public bool ShowGraphs;
        /* 0x0890 */ public int ShowSpecificGraph;
        /* 0x0894 */ public bool GraphCommandBuffer;
        /* 0x0895 */ public bool GraphGeneration;
        /* 0x0896 */ public bool GraphFPS;
        /* 0x0897 */ public bool GraphTexStreaming;
        /* 0x0898 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourPlanet, TourSolarSystem, TourGalaxy, TourUDAs }
        /* 0x089C */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        public enum SmokeTestScenarioEnum { None, TerrainSnapShotFromAltitude, BelowCloudLayerSnapShot, Flying, UltraBiomeSnapShot }
        /* 0x08A0 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x08A4 */ public bool SmokeTestLegacyOutput;
        /* 0x08A8 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x08AC */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x08B0 */ public float SmokeTestConfigScenarioLength;
        /* 0x08B4 */ public bool SmokeTestCameraFly;
        /* 0x08B5 */ public bool SmokeTestOutputOnly;
        /* 0x08B6 */ public bool SmokeTestPureFlight;
        /* 0x08B8 */ public int SmokeTestConfigCaptureCycles;
        /* 0x08BC */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x08C0 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x08C4 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x08C5 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x08C6 */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x08C8 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x08CC */ public bool SmokeTestPostBandwidthStats;
        [NMS(Size = 0x20)]
        /* 0x08CD */ public string SmokeTestForcePlanetDetail;
        /* 0x08ED */ public bool CreatureChatter;
        /* 0x08EE */ public bool CreatureErrors;
        /* 0x08EF */ public bool CreatureDrawVocals;
        /* 0x08F0 */ public bool DrawCreaturesInRoutines;
        /* 0x08F1 */ public bool CompressTextures;
        /* 0x08F2 */ public bool DebugIBL;
        /* 0x08F3 */ public bool DebugTerrainTextures;
        /* 0x08F4 */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x08F5 */ public string PipelineFile;
        [NMS(Size = 0x80)]
        /* 0x0975 */ public string PipelineFilePS4;
        [NMS(Size = 0x80)]
        /* 0x09F5 */ public string PipelineFileXboxOne;
        [NMS(Size = 0x80)]
        /* 0x0A75 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
        /* 0x0AF5 */ public string PipelineFileVRPS4;
        [NMS(Size = 0x80)]
        /* 0x0B75 */ public string PipelineFileFrontend;
        [NMS(Size = 0x80)]
        /* 0x0BF5 */ public string PipelineFileEditor;
        /* 0x0C75 */ public bool RenderLowFramerate;
        /* 0x0C76 */ public bool EnableComputePost;
        /* 0x0C77 */ public bool EnableEvenOddRender;
        /* 0x0C78 */ public bool MinGPUMode;
        /* 0x0C79 */ public bool Proto2DevKit;
        /* 0x0C7A */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x0C7B */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
        /* 0x0C7C */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0x0C80 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
        /* 0x0D00 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0x0D04 */ public string AuthBaseUrl;
        /* 0x0D84 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x0D85 */ public string OverrideUsernameForDev;
        /* 0x0DA8 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x0DAC */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x0DAD */ public bool AutoJoinUserEnabled;
        [NMS(Size = 0x8)]
        /* 0x0DAE */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x15AE */ public bool AlwaysSaveGameAsClient;
        /* 0x15AF */ public bool DisableMonumentDownloads;
        /* 0x15B0 */ public bool UsePadOnUnfocusedWindow;
        /* 0x15B4 */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x15B8 */ public string LoadToBase;
        /* 0x17B8 */ public bool IgnoreTransactionTimeouts;
        /* 0x17B9 */ public bool AutoJoinRandomGames;
        [NMS(Size = 0x100)]
        /* 0x17BA */ public string GOGLogin;
        /* 0x18BA */ public bool RecordNetworkStatsOnBoot;
        /* 0x18BB */ public bool FakeHandsInMultiplayer;
        /* 0x18BC */ public bool ForceSmallLobby;
        /* 0x18BD */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x18BE */ public string SynergyServer;
        /* 0x18E0 */ public int SynergyPort;
        /* 0x18E4 */ public bool ShowEditorPlacementPreview;
        /* 0x18E8 */ public int MaxNumDebugMessages;
        /* 0x18EC */ public bool PreloadToolbox;
        /* 0x18F0 */ public int DebugTextureSize;
        /* 0x18F4 */ public bool UseProcTextureDebugger;
        /* 0x18F8 */ public int ProceduralModelsShown;
        /* 0x18FC */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1900 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1980 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1A00 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1A80 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1B00 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1B80 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1C00 */ public string RenderToTexture;
        /* 0x1C80 */ public bool HmdEnable;
        /* 0x1C84 */ public int HmdPreviewScale;
        /* 0x1C88 */ public bool HmdTracking;
        /* 0x1C89 */ public bool HmdStereoRender;
        /* 0x1C8A */ public bool HmdDistortionPassthru;
        /* 0x1C8C */ public int HmdMonitor;
        /* 0x1C90 */ public int HmdEyeBufferWidth;
        /* 0x1C94 */ public int HmdEyeBufferHeight;
        /* 0x1C98 */ public float HmdEyeScalePos;
        /* 0x1C9C */ public float HmdHeadScalePos;
        /* 0x1CA0 */ public bool HmdFrameShiftEnabled;
        /* 0x1CA1 */ public bool HmdUseSolidGuiPointer;
        /* 0x1CA2 */ public bool BodyTurning;
        /* 0x1CA4 */ public float HmdImmersionFactor;
        /* 0x1CA8 */ public bool ShowHmdHandControllers;
        /* 0x1CA9 */ public bool ShowTeleportEffectLocally;
        /* 0x1CAA */ public bool DisableLeftHand;
        /* 0x1CAB */ public bool DisableHeadConstraints;
        /* 0x1CAC */ public bool EnablePhotomodeVR;
        /* 0x1CAD */ public bool AllowNGuiVR;
        /* 0x1CAE */ public bool ForceExtremeWeather;
        /* 0x1CAF */ public bool ForceExtremeSentinels;
        /* 0x1CB0 */ public bool ForceStarType;
        /* 0x1CB1 */ public bool ForceLoadAllWeather;
        /* 0x1CB4 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1CB8 */ public bool ForceBiome;
        /* 0x1CBC */ public GcBiomeSubType ForceBiomeTo;
        /* 0x1CC0 */ public bool ForceScreenFilter;
        /* 0x1CC4 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x1CC8 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1CCC */ public bool ForceBuildingRace;
        /* 0x1CD0 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1CD4 */ public bool ForceLifeLevel;
        /* 0x1CD8 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1CDC */ public bool ForceCreatureLifeLevel;
        /* 0x1CDD */ public bool ForceDefaultCreatureFile;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1CDE */ public byte[] Padding1CDE;
        [NMS(Size = 0x10)]
        /* 0x1CE0 */ public string DefaultGroundCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1CF0 */ public string DefaultAirCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1D00 */ public string DefaultWaterCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1D10 */ public string DefaultCaveCreatureTable;
        /* 0x1D20 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1D24 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x1D28 */ public bool ForceTerrainType;
        /* 0x1D2C */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x1D30 */ public bool ForcePrimeTerrain;
        /* 0x1D31 */ public bool ForceBinaryStar;
        /* 0x1D32 */ public bool ForceTernaryStar;
        /* 0x1D34 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x1D38 */ public bool ForcePlanetsToHaveWater;
        /* 0x1D3C */ public int ForceWaterObjectFileIndex;
        /* 0x1D40 */ public int ForceSkyColourIndex;
        /* 0x1D44 */ public int ForceWaterColourIndex;
        /* 0x1D48 */ public int ForceGrassColourIndex;
        /* 0x1D4C */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1D4D */ public bool DisableLimits;
        /* 0x1D4E */ public bool LimitPerRegionInstances;
        /* 0x1D4F */ public bool LimitPerRegionBodies;
        /* 0x1D50 */ public bool LimitGlobalInstances;
        /* 0x1D51 */ public bool LimitGlobalBodies;
        /* 0x1D54 */ public int GenerateFarLodBuildingDist;
        /* 0x1D58 */ public bool DeferRegionBodies;
        /* 0x1D5C */ public float GenerateCostDistance;
        /* 0x1D60 */ public float GenerateCostAngle;
        /* 0x1D64 */ public float GenerateCostLOD;
        /* 0x1D68 */ public float GenerateCostWait;
        /* 0x1D6C */ public bool DChecksEnabled;
        /* 0x1D6D */ public bool DChecksOutputJson;
        /* 0x1D6E */ public bool DChecksOutputBinary;
        /* 0x1D6F */ public bool DChecksOutputFileLine;
        /* 0x1D70 */ public int FrameFlipRateDefault;
        /* 0x1D74 */ public int FrameFlipRateLoad;
        /* 0x1D78 */ public int FrameFlipRateGame;
        /* 0x1D7C */ public float MaxFrameRate;
        /* 0x1D80 */ public bool DisableBaseBuilding;
        /* 0x1D81 */ public bool DisableBaseBuildingLimits;
        /* 0x1D84 */ public float BaseDownloadTimeout;
        /* 0x1D88 */ public bool DisableBasePowerRequirements;
        /* 0x1D89 */ public bool EnableBaseMovingOption;
        /* 0x1D8C */ public int MoveBaseIndex;
        /* 0x1D90 */ public int AutomaticPartSpawnIndex;
        /* 0x1D94 */ public bool BaseAdmin;
        [NMS(Size = 0x20)]
        /* 0x1D95 */ public string BaseServerPlatform;       // "pc"
        /* 0x1DB8 */ public uint BasePayloadMultiplier;
        /* 0x1DBC */ public bool CrossPlatformFeaturedBases;
        /* 0x1DBD */ public bool ShowMissionIdInTitle;
        /* 0x1DC0 */ public TkGlobals ToolkitGlobals;
    }
}

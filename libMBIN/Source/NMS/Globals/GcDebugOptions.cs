using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x3235F67C0A712F2)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
		/* 0x4 */ public int BootDirectlyIntoSaveSlot;
		/* 0x8 */ public GcGameMode NewSaveGameMode;

		/* 0xC */ public bool SkipPlanetDiscoverOnBoot;
		/* 0xD */ public bool VideoCaptureMode;
		/* 0xE */ public bool GodMode;
		/* 0xF */ public bool AlwaysHaveFocus;
		/* 0x10 */ public bool DisableVibration;
		/* 0x11 */ public bool MapWarpCheckIgnoreFuel;
		/* 0x12 */ public bool MapWarpCheckIgnoreDrive;
		/* 0x13 */ public bool EverythingIsFree;
		/* 0x14 */ public bool EverythingIsKnown;
		/* 0x15 */ public bool EverythingIsStar;
		/* 0x16 */ public bool IgnoreMissionRank;
		/* 0x17 */ public bool CanLeaveDialogs;
        /* 0x18 */ public bool Unknown0x18;             // this could potentially be anywhere within this chunk.

		/* 0x19 */ public bool DisableOldMissions;
		/* 0x1A */ public bool UseScreenEffects;
		/* 0x1B */ public bool UseGunImpactEffect;

        /* 0x1C */ public bool Unknown0x1C;             // this could potentially be anywhere within this chunk.
		/* 0x1D */ public bool RenderCreatureDetails;
		/* 0x1E */ public bool SkipTutorial;
		/* 0x1F */ public bool IgnoreFreighterSpawnWarpRequirement;

		/* 0x20 */ public bool DisableSaveSlotSorting;

		/* 0x21 */ public bool DisableSaving;           // Don't know where these two known values are
		/* 0x22 */ public bool UseDebugScreenSettings;
        /* 0x23 */ public bool Unknown0x23;
        /* 0x24 */ public bool Unknown0x24;

		/* 0x28 */ public int ScreenWidth;
		/* 0x2C */ public int ScreenHeight;
		/* 0x30 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x34 */ public GameWindowModeEnum GameWindowMode;
        /* 0x38 */ public int Monitor;
        /* 0x3C */ public int UnknownInt0x3C;   // Possibly the default value for some Enum...
        /* 0x40 */ public int UnknownInt0x40;
        [NMS(Size = 0x100)]
        /* 0x44 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x144 */ public string ForcePlayerPosition;
        /* 0x244 */ public bool ForceInitialShip;
        /* 0x245 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x248 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x24C */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet }
		/* 0x250 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x254 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2D4 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3D4 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3D8 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3DC */ public bool ShaderPreloadListExport;
        /* 0x3DD */ public bool ShaderPreloadListImport;
        /* 0x3DE */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3E0 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x3E4 */ public bool MemCsv;
        /* 0x3E8 */ public float ForceTimeOfDay;

        // Start of "block of mess". The following values could be quite wrong. Lots of testing needed!!

        /* 0x3EC */ public int UnknownInt0x3EC;
        /* 0x3F0 */ public int UnknownInt0x3F0;
        /* 0x3F4 */ public bool Unknown0x3F1;
        /* 0x3F5 */ public bool UseParticles;
        /* 0x3F6 */ public bool UseVolumetrics;
        /* 0x3F7 */ public bool UseClouds;
        /* 0x3F8 */ public bool UseTerrain;
        /* 0x3F9 */ public bool UseInstances;
        /* 0x3FA */ public bool UseObjects;
        /* 0x3FB */ public bool UseBuildings;
        /* 0x3FC */ public bool UseCreatures;
        /* 0x3FD */ public bool UseElevation;
        /* 0x3FE */ public bool Unknown0x3FE;
        /* 0x3FF */ public bool Unknown0x3FF;
        /* 0x400 */ public bool Unknown0x400;
        /* 0x401 */ public bool UseLegacyFreighters;
        /* 0x402 */ public bool SpawnPirates;
        /* 0x403 */ public bool SpawnPirates;
        /* 0x404 */ public bool SpawnRobots;
        /* 0x405 */ public bool InstanceCollision;
        /* 0x406 */ public bool MPMissions;
        /* 0x407 */ public bool Unknown0x407;
        /* 0x408 */ public bool Unknown0x408;
        /* 0x409 */ public bool SpecialsShop;
		/* 0x40A */ public bool MultiplePlayerFreightersInASystem;

        // End of "block of mess" (?)

		/* 0x40B */ public bool MouseLookEnabled;
		/* 0x40C */ public bool StartPaused;
		/* 0x40D */ public bool DisableDebugControls;
		/* 0x40E */ public bool DisableAsserts;
		/* 0x40F */ public bool FixedFramerate;
		/* 0x410 */ public bool ScreenshotMode;
		/* 0x411 */ public bool RenderHud;
		/* 0x412 */ public bool DisableDiscoveryNaming;
		/* 0x413 */ public bool DebugDrawPlayerInteract;
		/* 0x414 */ public bool ForceInteractionToSettings;
		/* 0x418 */ public int ForceInteractionIndex;
        /* 0x41C */ public bool InteractionsAllwaysGivesTech;
        /* 0x41D */ public bool InfiniteInteractions;
        /* 0x41E */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x420 */ public float DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x424 */ public string AllowedLanguagesFile;
        /* 0x444 */ public bool DoAlienLanguage;
        /* 0x448 */ public float ForceInteractionRaceTo;
        /* 0x44C */ public float RealityMode;
        /* 0x450 */ public bool DebugPersistentInteractions;
        /* 0x451 */ public bool Unknown0x451;
        [NMS(Size = 0x80)]
        /* 0x452 */ public string RealityPresetFile;
        /* 0x4D2 */ public short RealityGenerationIteration;
        [NMS(Size = 0x4)]
        /* 0x4D4 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x554 */ public string DefaultSaveData;
        /* 0x5D4 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5D5 */ public bool ForceBasicLoadScreen;
        /* 0x5D8 */ public float BootLogoFadeRate;
        /* 0x5DC */ public bool BootMusic;
        /* 0x5E0 */ public float WeaponScale3P;
        /* 0x5E4 */ public bool LogMissingLocalisedText;
        /* 0x5E5 */ public bool FleetDirectorAutoMode;
        /* 0x5E8 */ public float _3dTextDistance;
        /* 0x5EC */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x5F0 */ public RecordSettingEnum RecordSetting;
        /* 0x5F4 */ public bool DebugBuildingSpawns;
        /* 0x5F5 */ public bool StressTestLongNameDisplay;
        /* 0x5F6 */ public bool Unknown0x5F6;
        [NMS(Size = 0x20)]
        /* 0x5F7 */ public string SaveTestingCommand;
        /* 0x617 */ public bool NeverUseBanks;
        /* 0x618 */ public bool DisableProfanityFilter;
        /* 0x619 */ public bool DisableFileWatcher;
        /* 0x61C */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x620 */ public string Unknown0x620;
        [NMS(Size = 0x20)]
        /* 0x6A0 */ public string Unknown0x6A0;
        /* 0x6C0 */ public bool Unknown0x6C0;
        /* 0x6C1 */ public bool ShowDebugMessages;
        /* 0x6C2 */ public bool ShowFramerate;
        /* 0x6C3 */ public bool ShowPositionDebug;
        /* 0x6C4 */ public bool Unknown0x6C4;
        /* 0x6C5 */ public bool ShowGPUMemory;
        /* 0x6C6 */ public bool ShowMempoolOverlay;
        /* 0x6C7 */ public bool ShowMouseSmoothing;

        [NMS(Size = 0x100)]
        /* 0x6C8 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x7C8 */ public bool ShowGraphs;
        /* 0x7CC */ public int ShowSpecificGraph;
        /* 0x7D0 */ public bool GraphCommandBuffer;
        /* 0x7D1 */ public bool GraphGeneration;
        /* 0x7D2 */ public bool GraphFPS;
        /* 0x7D3 */ public bool GraphTexStreaming;
        /* 0x7D4 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x7D8 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x7DC */ public bool SmokeTestCameraFly;
        /* 0x7DD */ public bool SmokeTestOutputOnly;
        /* 0x7DE */ public bool SmokeTestPureFlight;
        /* 0x7E0 */ public int SmokeTestConfigCaptureCycles;
        /* 0x7E4 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x7E8 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x7EC */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x7ED */ public bool SmokeTestSmokeBotEnabled;
		/* 0x7EE */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x7F0 */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x7F4 */ public bool CreatureChatter;
		/* 0x7F5 */ public bool CreatureErrors;
		/* 0x7F6 */ public bool CreatureDrawVocals;
		/* 0x7F7 */ public bool DrawCreaturesInRoutines;
		/* 0x7F8 */ public bool ShowFirstPersonCharacterShadow;
		/* 0x7F9 */ public bool CompressTextures;
		/* 0x7FA */ public bool DebugIBL;
		/* 0x7FB */ public bool DebugTerrainTextures;
		/* 0x7FC */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x7FD */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x87D */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x8FD */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x97D */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0x9FD */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xA7D */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xAFD */ public string PipelineFileEditor;
		/* 0xB7D */ public bool RenderLowFramerate;
		/* 0xB7E */ public bool EnableComputePost;
        /* 0xB7F */ public bool EnableEvenOddRender;
		/* 0xB80 */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xB84 */ public ProxyTypeEnum ProxyType;

        [NMS(Size = 0x80)]
        /* 0xB88 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC08 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC0C */ public string AuthBaseUrl;
        /* 0xC8C */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xC8D */ public string OverrideUsernameForDev;
        /* 0xCB0 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCB4 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCB5 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCB6 */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14B6 */ public bool AlwaysSaveGameAsClient;
        /* 0x14B7 */ public bool DisableMonumentDownloads;
        /* 0x14B8 */ public bool UsePadOnUnfocusedWindow;
        /* 0x14BC */ public int OverrideMatchmakingVersion;
        /* 0x14C0 */ public bool IgnoreTransactionTimeouts;
        /* 0x14C1 */ public bool Unknown0x14C1;
        [NMS(Size = 0x100)]
        /* 0x14C2 */ public string Unknown0x14C2;
        /* 0x15C2 */ public bool Unknown0x15C2;
        /* 0x15C3 */ public bool Unknown0x15C3;
        /* 0x15C4 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x15C5 */ public string SynergyServer;
        /* 0x15E8 */ public int SynergyPort;
        /* 0x15EC */ public bool ShowEditorPlacementPreview;
        /* 0x15F0 */ public int MaxNumDebugMessages;
        /* 0x15F4 */ public bool PreloadToolbox;
        /* 0x15F8 */ public int DebugTextureSize;
        /* 0x15FC */ public bool UseProcTextureDebugger;
        /* 0x1600 */ public int ProceduralModelsShown;
        /* 0x1604 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1608 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1688 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1708 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1788 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1808 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1888 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1908 */ public string RenderToTexture;

        // Not sure about this block...
        /* 0x1988 */ public bool HmdEnable;
        /* 0x198C */ public int UnknownInt0x108C;
        /* 0x1990 */ public bool HmdOutput;
        /* 0x1991 */ public bool HmdTracking;
        /* 0x1992 */ public bool HmdStereoRender;
        /* 0x1993 */ public bool HmdDistortionPassthru;         // There shouldn't be anything at 0x1993...

        /* 0x1994 */ public int HmdMonitor;
        /* 0x1998 */ public int HmdEyeBufferWidth;
        /* 0x199C */ public int HmdEyeBufferHeight;

        /* 0x19A0 */ public float HmdEyeScalePos;
        /* 0x19A4 */ public float HmdHeadScalePos;
        /* 0x19A8 */ public bool Unknown0x19A8;                 // these may have picked up a bool from above
        /* 0x19A9 */ public bool Unknown0x19A9;
        /* 0x19AA */ public bool Unknown0x19AA;
        /* 0x19AC */ public float HmdImmersionFactor;

        // Don't know how many bools there are. There should be at least as it is a qword...
        /* 0x19B0 */ public bool Unknown0x19B0;
        /* 0x19B1 */ public bool Unknown0x19B1;
        /* 0x19B2 */ public bool Unknown0x19B2;         // this is True
        /* 0x19B3 */ public bool Unknown0x19B3;
        /* 0x19B4 */ public bool Unknown0x19B4;
        /* 0x19B5 */ public bool Unknown0x19B5;
        /* 0x19B6 */ public bool Unknown0x19B6;
        /* 0x19B7 */ public bool Unknown0x19B7;

        /* 0x19B8 */ public bool ForceExtremeWeather;
        /* 0x19B9 */ public bool ForceExtremeSentinels;
        /* 0x19BA */ public bool ForceStarType;
        /* 0x19BC */ public GcGalaxyStarTypes ForceStarTypeTo;

        /* 0x19C0 */ public bool ForceBiome;
        /* 0x19C4 */ public GcBiomeType ForceBiomeTo;
        /* 0x19C8 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x19CC */ public bool ForceBuildingRace;
        /* 0x19D0 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x19D4 */ public bool ForceLifeLevel;
        /* 0x19D8 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x19DC */ public bool ForceCreatureLifeLevel;
        /* 0x19DD */ public bool ForceDefaultCreatureFile;
        /* 0x19E0 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x19E4 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x19E8 */ public bool ForceTerrainType;
        /* 0x19EC */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x19F0 */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x19F4 */ public bool ForcePlanetsToHaveWater;
        /* 0x19F8 */ public int UnknownInt0x19F8;
        /* 0x19FC */ public int UnknownInt0x19FC;
        /* 0x1A00 */ public int UnknownInt0x1A00;
        /* 0x1A04 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1A05 */ public bool DisableLimits;
        /* 0x1A06 */ public bool LimitPerRegionInstances;
        /* 0x1A07 */ public bool LimitPerRegionBodies;
        /* 0x1A08 */ public bool LimitGlobalInstances;
        /* 0x1A09 */ public bool LimitGlobalBodies;
        /* 0x1A0C */ public int GenerateFarLodBuildingDist;
        /* 0x1A10 */ public bool DeferRegionBodies;
        /* 0x1A14 */ public float GenerateCostDistance;
        /* 0x1A18 */ public float GenerateCostAngle;
        /* 0x1A1C */ public float GenerateCostLOD;
        /* 0x1A20 */ public float GenerateCostWait;
        /* 0x1A24 */ public bool DChecksEnabled;
        /* 0x1A25 */ public bool DChecksOutputJson;
        /* 0x1A26 */ public bool DChecksOutputBinary;
        /* 0x1A27 */ public bool DChecksOutputFileLine;
        /* 0x1A28 */ public int FrameFlipRateDefault;
        /* 0x1A2C */ public int FrameFlipRateLoad;
        /* 0x1A30 */ public int FrameFlipRateGame;
        /* 0x1A34 */ public float MaxFrameRate;
        /* 0x1A38 */ public bool DisableBaseBuilding;
        /* 0x1A39 */ public bool DisableBaseBuildingLimits;
        /* 0x1A3C */ public float BaseDownloadTimeout;
        /* 0x1A40 */ public bool BaseBuildingPartsRequirePower;
        /* 0x1A41 */ public bool Unknown0x1A41;
        /* 0x1A42 */ public bool Unknown0x1A42;
        /* 0x1A43 */ public bool Unknown0x1A43;         // probably not used...
        /* 0x1A44 */ public int UnknownInt0x1A44;       // this and the following int are in a qword
        /* 0x1A48 */ public int UnknownInt0x1A48;
        /* 0x1A4C */ public bool Unknown0x1A4C;
        /* 0x1A50 */ public int UnknownInt0x1A50;
        /* 0x1A54 */ public int UnknownInt0x1A54;
        /* 0x1A58 */ public bool Unknown0x1A58;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15A9 */ public byte[] Endpadding;
    }
}

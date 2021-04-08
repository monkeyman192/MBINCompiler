﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2558, GUID = 0x3A0ABD79424C4E21)]
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
        [NMS(Size = 0x200)]
        /* 0x0044 */ public string SeasonalDataOverrideFile;
        /* 0x0244 */ public bool UnlockAllSeasonRewards;
        /* 0x0245 */ public bool UnlockAllTwitchRewards;
        [NMS(Size = 0x4)]
        /* 0x0246 */ public NMSString0x100[] DebugTwitchRewards;
        /* 0x0646 */ public bool UseDebugScreenSettings;
        /* 0x0648 */ public int ScreenWidth;
        /* 0x064C */ public int ScreenHeight;
        /* 0x0650 */ public bool DisableVSync;
        public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
        /* 0x0654 */ public GameWindowModeEnum GameWindowMode;
        /* 0x0658 */ public int Monitor;
        /* 0x065C */ public int TiledWindowsSplitCount;
        /* 0x0660 */ public int TiledWindowsIndex;
        [NMS(Size = 0x100)]
        /* 0x0664 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x0764 */ public string ForcePlayerPosition;
        /* 0x0864 */ public bool ForceInitialShip;
        /* 0x0865 */ public bool ForceInitialWeapon;
        public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
        /* 0x0868 */ public GameStateModeEnum GameStateMode;
        public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
        /* 0x086C */ public BootModeEnum BootMode;
        public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation }
        /* 0x0870 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x0874 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x08F4 */ public string WorkingDirectory;
        [NMS(Size = 0x80)]
        /* 0x09F4 */ public string DebugScene;
        public enum SolarSystemBootEnum { FromSettings, Generate }
        /* 0x0A74 */ public SolarSystemBootEnum SolarSystemBoot;
        public enum ShaderPreloadEnum { Off, Full }
        /* 0x0A78 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0A7C */ public bool ShaderPreloadListExport;
        /* 0x0A7D */ public bool ShaderPreloadListImport;
        /* 0x0A7E */ public bool ShaderCaching;
        public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
        /* 0x0A80 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0A84 */ public bool MemCsv;
        /* 0x0A88 */ public float ForceTimeOfDay;
        /* 0x0A8C */ public float ForceInitialTimeOfDay;
        /* 0x0A90 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0A94 */ public float ForceSunAngle;
        /* 0x0A98 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0A99 */ public bool UseParticles;
        /* 0x0A9A */ public bool UseHeavyAir;
        /* 0x0A9B */ public bool UseVolumetrics;
        /* 0x0A9C */ public bool UseClouds;
        /* 0x0A9D */ public bool EnableCloudAnimation;
        /* 0x0A9E */ public bool UseTerrain;
        /* 0x0A9F */ public bool UseInstances;
        /* 0x0AA0 */ public bool UseObjects;
        /* 0x0AA1 */ public bool UseBuildings;
        /* 0x0AA2 */ public bool UseCreatures;
        /* 0x0AA3 */ public bool UseElevation;
        /* 0x0AA4 */ public bool UseLegacyFreighters;
        /* 0x0AA5 */ public bool UseLegacyBuildingTable;
        /* 0x0AA6 */ public bool EnableDayNightCycle;
        /* 0x0AA7 */ public bool SpawnPirates;
        /* 0x0AA8 */ public bool SpawnRobots;
        /* 0x0AA9 */ public bool SpawnShips;
        /* 0x0AAA */ public bool SpawnPulseEncounters;
        /* 0x0AAB */ public bool InstanceCollision;
        /* 0x0AAC */ public bool LoadMissions;
        /* 0x0AAD */ public bool MPMissions;
        /* 0x0AAE */ public bool SpecialsShop;
        /* 0x0AAF */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0AB0 */ public bool ForceNexusInQuickMenu;
        /* 0x0AB1 */ public bool MissionSurveyEnabled;
        /* 0x0AB2 */ public bool SeasonalModeEnabled;
        /* 0x0AB3 */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0AB4 */ public bool HazardsSpawnGifts;
        /* 0x0AB5 */ public bool MouseLookEnabled;
        /* 0x0AB6 */ public bool StartPaused;
        /* 0x0AB7 */ public bool DisableDebugControls;
        /* 0x0AB8 */ public bool FixedFramerate;
        /* 0x0AB9 */ public bool ScreenshotMode;
        /* 0x0ABA */ public bool RenderHud;
        /* 0x0ABB */ public bool DisableDiscoveryNaming;
        /* 0x0ABC */ public bool DebugDrawPlayerInteract;
        /* 0x0ABD */ public bool ForceInteractionToSettings;
        /* 0x0AC0 */ public int ForceInteractionIndex;
        /* 0x0AC4 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AC5 */ public bool InfiniteInteractions;
        /* 0x0AC6 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AC8 */ public TkLanguages DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x0ACC */ public string AllowedLanguagesFile;
        /* 0x0AEC */ public bool DoAlienLanguage;
        /* 0x0AF0 */ public GcAlienRace ForceInteractionRaceTo;
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x0AF4 */ public RealityModeEnum RealityMode;
        /* 0x0AF8 */ public bool DebugPersistentInteractions;
        /* 0x0AF9 */ public bool UseHighlightedOptionStyle;
        /* 0x0AFA */ public bool DisableMissionShop;
        [NMS(Size = 0x80)]
        /* 0x0AFB */ public string RealityPresetFile;
        /* 0x0B7C */ public ushort RealityGenerationIteration;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x0B7E */ public byte[] PaddingB7E;
        /* 0x0B80 */ public List<NMSString0x20> LocTableList;
        [NMS(Size = 0x80)]
        /* 0x0B90 */ public string DefaultSaveData;
        /* 0x0C10 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C11 */ public bool ForceBasicLoadScreen;
        /* 0x0C14 */ public float BootLogoFadeRate;
        /* 0x0C18 */ public bool BootMusic;
        /* 0x0C1C */ public float WeaponScale3P;
        /* 0x0C20 */ public bool LogMissingLocalisedText;
        /* 0x0C21 */ public bool FleetDirectorAutoMode;
        /* 0x0C24 */ public float _3dTextDistance;
        /* 0x0C28 */ public float _3dTextMinScale;
        public enum RecordSettingEnum { None, Record, Playback }
        /* 0x0C2C */ public RecordSettingEnum RecordSetting;
        /* 0x0C30 */ public bool DebugBuildingSpawns;
        /* 0x0C31 */ public bool StressTestLongNameDisplay;
        /* 0x0C32 */ public bool ShowLongestStrings;
        [NMS(Size = 0x20)]
        /* 0x0C33 */ public string SaveTestingCommand;
        /* 0x0C53 */ public bool NeverUseBanks;
        /* 0x0C54 */ public bool DisableProfanityFilter;
        /* 0x0C55 */ public bool DisableFileWatcher;
        /* 0x0C56 */ public bool DisableShaderReload;
        /* 0x0C58 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x0C5C */ public string CrashDumpPath;
        [NMS(Size = 0x20)]
        /* 0x0CDC */ public string CrashDumpIdentifier;
        /* 0x0CFC */ public bool EnableLivePP;
        /* 0x0CFD */ public bool DebugThreatLevels;
        /* 0x0CFE */ public bool ShowDebugMessages;
        /* 0x0CFF */ public bool ShowFramerate;
        /* 0x0D00 */ public bool PrintAvgFrameTimes;
        /* 0x0D01 */ public bool ShowPositionDebug;
        /* 0x0D02 */ public bool ShowGPUMemory;
        /* 0x0D03 */ public bool ShowMempoolOverlay;
        /* 0x0D04 */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x0D05 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x0E05 */ public bool ShowGraphs;
        /* 0x0E08 */ public int ShowSpecificGraph;
        /* 0x0E0C */ public bool GraphCommandBuffer;
        /* 0x0E0D */ public bool GraphGeneration;
        /* 0x0E0E */ public bool GraphFPS;
        /* 0x0E0F */ public bool GraphTexStreaming;
        /* 0x0E10 */ public bool SmokeTestDumpStatsMode;
        public enum SmokeTestCycleModeEnum { None, TourPlanet, TourSolarSystem, TourGalaxy, TourUDAs }
        /* 0x0E14 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        public enum SmokeTestScenarioEnum { None, TerrainSnapShotFromAltitude, BelowCloudLayerSnapShot, Flying, UltraBiomeSnapShot }
        /* 0x0E18 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E1C */ public bool SmokeTestLegacyOutput;
        /* 0x0E20 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E24 */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E28 */ public float SmokeTestConfigScenarioLength;
        /* 0x0E2C */ public bool SmokeTestFastExit;
        /* 0x0E2D */ public bool SmokeTestCameraFly;
        /* 0x0E2E */ public bool SmokeTestOutputOnly;
        /* 0x0E2F */ public bool SmokeTestPureFlight;
        /* 0x0E30 */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E34 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E38 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E3C */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E3D */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E3E */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x0E40 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E44 */ public bool SmokeTestPostBandwidthStats;
        [NMS(Size = 0x20)]
        /* 0x0E45 */ public string SmokeTestForcePlanetDetail;
        /* 0x0E65 */ public bool CreatureChatter;
        /* 0x0E66 */ public bool CreatureErrors;
        /* 0x0E67 */ public bool CreatureDrawVocals;
        /* 0x0E68 */ public bool DrawCreaturesInRoutines;
        /* 0x0E69 */ public bool CompressTextures;
        /* 0x0E6A */ public bool DebugIBL;
        /* 0x0E6B */ public bool DebugTerrainTextures;
        /* 0x0E6C */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x0E6D */ public string PipelineFile;
        [NMS(Size = 0x80)]
        /* 0x0EED */ public string PipelineFilePS4;
        [NMS(Size = 0x80)]
        /* 0x0F6D */ public string PipelineFileXboxOne;
        [NMS(Size = 0x80)]
        /* 0x0FED */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
        /* 0x106D */ public string PipelineFileVRPS4;
        [NMS(Size = 0x80)]
        /* 0x10ED */ public string PipelineFileFrontend;
        [NMS(Size = 0x80)]
        /* 0x116D */ public string PipelineFileEditor;
        /* 0x11ED */ public bool RenderLowFramerate;
        /* 0x11EE */ public bool EnableComputePost;
        /* 0x11EF */ public bool EnableEvenOddRender;
        /* 0x11F0 */ public bool MinGPUMode;
        /* 0x11F1 */ public bool Proto2DevKit;
        /* 0x11F2 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x11F3 */ public bool SimulateNoNetworkConnection;
        public enum ProxyTypeEnum { None, ManualURI, InetProxy }
        /* 0x11F4 */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0x11F8 */ public string ProxyURI;
        public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
        /* 0x1278 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0x127C */ public string AuthBaseUrl;
        /* 0x12FC */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x12FD */ public string OverrideUsernameForDev;
        /* 0x1320 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x1324 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x1325 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 0x8)]
        /* 0x1326 */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x1B26 */ public bool AlwaysSaveGameAsClient;
        /* 0x1B27 */ public bool DisableMonumentDownloads;
        /* 0x1B28 */ public bool UsePadOnUnfocusedWindow;
        /* 0x1B2C */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x1B30 */ public string LoadToBase;
        /* 0x1D30 */ public bool IgnoreTransactionTimeouts;
        /* 0x1D31 */ public bool AutoJoinRandomGames;
        [NMS(Size = 0x100)]
        /* 0x1D32 */ public string GOGLogin;
        /* 0x1E32 */ public bool RecordNetworkStatsOnBoot;
        /* 0x1E33 */ public bool FakeHandsInMultiplayer;
        /* 0x1E34 */ public bool ForceSmallLobby;
        /* 0x1E35 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x1E36 */ public string SynergyServer;
        /* 0x1E58 */ public int SynergyPort;
        /* 0x1E5C */ public bool ShowEditorPlacementPreview;
        /* 0x1E60 */ public int MaxNumDebugMessages;
        /* 0x1E64 */ public bool PreloadToolbox;
        /* 0x1E68 */ public int DebugTextureSize;
        /* 0x1E6C */ public bool UseProcTextureDebugger;
        /* 0x1E70 */ public int ProceduralModelsShown;
        /* 0x1E74 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1E78 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1EF8 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1F78 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1FF8 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x2078 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x20F8 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x2178 */ public string RenderToTexture;
        /* 0x21F8 */ public bool HmdEnable;
        /* 0x21FC */ public int HmdPreviewScale;
        /* 0x2200 */ public bool HmdTracking;
        /* 0x2201 */ public bool HmdStereoRender;
        /* 0x2202 */ public bool HmdDistortionPassthru;
        /* 0x2204 */ public int HmdMonitor;
        /* 0x2208 */ public int HmdEyeBufferWidth;
        /* 0x220C */ public int HmdEyeBufferHeight;
        /* 0x2210 */ public float HmdEyeScalePos;
        /* 0x2214 */ public float HmdHeadScalePos;
        /* 0x2218 */ public bool HmdFrameShiftEnabled;
        /* 0x2219 */ public bool HmdUseSolidGuiPointer;
        /* 0x221A */ public bool BodyTurning;
        /* 0x221C */ public float HmdImmersionFactor;
        /* 0x2220 */ public bool ShowHmdHandControllers;
        /* 0x2221 */ public bool ShowTeleportEffectLocally;
        /* 0x2222 */ public bool DisableLeftHand;
        /* 0x2223 */ public bool DisableHeadConstraints;
        /* 0x2224 */ public bool EnablePhotomodeVR;
        /* 0x2225 */ public bool AllowNGuiVR;
        /* 0x2226 */ public bool ForceExtremeWeather;
        /* 0x2227 */ public bool ForceExtremeSentinels;
        /* 0x2228 */ public bool ForceStarType;
        /* 0x2229 */ public bool ForceLoadAllWeather;
        /* 0x222C */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x2230 */ public bool ForceBiome;
        /* 0x2234 */ public GcBiomeType ForceBiomeTo;
        /* 0x2238 */ public bool ForceScreenFilter;
        /* 0x223C */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x2240 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x2244 */ public bool ForceBuildingRace;
        /* 0x2248 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x224C */ public bool ForceLifeLevel;
        /* 0x2250 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x2254 */ public bool ForceCreatureLifeLevel;
        /* 0x2255 */ public bool ForceDefaultCreatureFile;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2256 */ public byte[] Padding2256;
        [NMS(Size = 0x10)]
        /* 0x2258 */ public string DefaultGroundCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x2268 */ public string DefaultAirCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x2278 */ public string DefaultWaterCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x2288 */ public string DefaultCaveCreatureTable;
        /* 0x2298 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x229C */ public GcPlanetLife ForceTerrainSettings;
        /* 0x22A0 */ public bool ForceTerrainType;
        /* 0x22A4 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x22A8 */ public bool ForcePrimeTerrain;
        /* 0x22A9 */ public bool ForceBinaryStar;
        /* 0x22AA */ public bool ForceTernaryStar;
        /* 0x22AC */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x22B0 */ public bool ForcePlanetsToHaveWater;
        /* 0x22B4 */ public int ForceWaterObjectFileIndex;
        /* 0x22B8 */ public int ForceSkyColourIndex;
        /* 0x22BC */ public int ForceWaterColourIndex;
        /* 0x22C0 */ public int ForceGrassColourIndex;
        /* 0x22C4 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x22C5 */ public bool DisableLimits;
        /* 0x22C6 */ public bool LimitPerRegionInstances;
        /* 0x22C7 */ public bool LimitPerRegionBodies;
        /* 0x22C8 */ public bool LimitGlobalInstances;
        /* 0x22C9 */ public bool LimitGlobalBodies;
        /* 0x22CC */ public int GenerateFarLodBuildingDist;
        /* 0x22D0 */ public bool DeferRegionBodies;
        /* 0x22D4 */ public float GenerateCostDistance;
        /* 0x22D8 */ public float GenerateCostAngle;
        /* 0x22DC */ public float GenerateCostLOD;
        /* 0x22E0 */ public float GenerateCostWait;
        /* 0x22E4 */ public bool DChecksEnabled;
        /* 0x22E5 */ public bool DChecksOutputJson;
        /* 0x22E6 */ public bool DChecksOutputBinary;
        /* 0x22E7 */ public bool DChecksOutputFileLine;
        /* 0x22E8 */ public int FrameFlipRateDefault;
        /* 0x22EC */ public int FrameFlipRateLoad;
        /* 0x22F0 */ public int FrameFlipRateGame;
        /* 0x22F4 */ public float MaxFrameRate;
        /* 0x22F8 */ public bool DisableBaseBuilding;
        /* 0x22F9 */ public bool DisableBaseBuildingLimits;
        /* 0x22FA */ public bool AllowGlobalPartSnapping;
        /* 0x22FC */ public float BaseDownloadTimeout;
        /* 0x2300 */ public bool DisableBasePowerRequirements;
        /* 0x2301 */ public bool EnableBaseMovingOption;
        /* 0x2304 */ public int MoveBaseIndex;
        /* 0x2308 */ public int AutomaticPartSpawnIndex;
        /* 0x230C */ public bool BaseAdmin;
        [NMS(Size = 0x20)]
        /* 0x230D */ public string BaseServerPlatform;       // "pc"
        /* 0x2330 */ public uint BasePayloadMultiplier;
        /* 0x2334 */ public bool CrossPlatformFeaturedBases;
        /* 0x2335 */ public bool ShowMissionIdInTitle;
        /* 0x2338 */ public TkGlobals ToolkitGlobals;
    }
}

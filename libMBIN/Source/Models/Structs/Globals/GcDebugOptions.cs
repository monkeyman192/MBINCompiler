namespace libMBIN.Models.Structs
{
    public class GcDebugOptions : NMSTemplate           // locations at start of lines will be wrong in parts
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
        /* 0x3 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x4 */ public bool VideoCaptureMode;
        /* 0x5 */ public bool GodMode;
        /* 0x6 */ public bool AlwaysHaveFocus;
        /* 0x7 */ public bool DisableVibration;
        /* 0x8 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x9 */ public bool MapWarpCheckIgnoreDrive;
        /* 0xA */ public bool EverythingIsFree;
        /* 0xB */ public bool EverythingIsKnown;
        /* 0xC */ public bool EverythingIsStar;
        /* 0xD */ public bool IgnoreMissionRank;
        /* 0xE */ public bool CanLeaveDialogs;
        /* 0xF */ public bool DisableOldMissions;
        /* 0x10 */ public bool UseScreenEffects;
        /* 0x11 */ public bool UseGunImpactEffect;
        /* 0x12 */ public bool RenderCreatureDetails;
        /* 0x13 */ public bool SkipTutorial;
        /* 0x14 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x15 */ public bool DisableSaveSlotSorting;
        /* 0x16 */ public bool UseDebugScreenSettings;
        /* 0x18 */ public int ScreenWidth;
        /* 0x1C */ public int ScreenHeight;
        /* 0x20 */ public bool DisableVSync;
        /* 0x24 */ public int GameWindowMode;
        public string[] GameWindowModeValues()
        {
            return new[] { "Bordered", "Borderless", "Fullscreen" };
}
        /* 0x28 */ public int Monitor;
        [NMS(Size = 0x100)]
        /* 0x2C */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x12C */ public string ForcePlayerPosition;
        /* 0x22C */ public bool ForceInitialShip;
        /* 0x22D */ public bool ForceInitialWeapon;
        /* 0x230 */ public int GameStateMode;
        public string[] GameStateModeValues()
        {
            return new[] { "LoadPreset", "UserStorage", "FreshStart" };
}
        /* 0x234 */ public int BootMode;
        public string[] BootModeValues()
        {
            return new[] {"MinimalSolarSystem", "SolarSystem", "GalaxyMap", "SmokeTest",
                          "SmokeTestGalaxyMap", "Scratchpad", "UnitTest" };
}
        /* 0x238 */ public int PlayerSpawnLocationOverride;
        public string[] PlayerSpawnLocationOverrideValues()
        {
            return new[] { "None", "FromSettings", "Space", "SpaceStation", "RandomPlanet", "GameStartPlanet" };
}
        [NMS(Size = 0x80)]
        /* 0x23C */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2BC */ public string WorkingDirectory;
        /* 0x3BC */ public int SolarSystemBoot;
        public string[] SolarSystemBootValues()
        {
            return new[] { "FromSettings", "Generate" };
}
        /* 0x3C0 */ public int ShaderPreload;
        public string[] ShaderPreloadValues()
        {
            return new[] { "Off", "Full" };
}
        /* 0x3C4 */ public float PresetGameMode;        // int? prob an enum too of the game modes?? 
        /* 0x3C8 */ public bool ShaderPreloadListExport;
        /* 0x3C9 */ public bool ShaderPreloadListImport;
        /* 0x3CA */ public bool ShaderCaching;
        /* 0x3CC */ public int BootLoadDelay;
        public string[] BootLoadDelayValues()
        {
            return new[] { "LoadAll", "WaitForPlanet", "WaitForNothing" };
}
        /* 0x3D0 */ public bool MemCsv;
        /* 0x3D4 */ public float ForceTimeOfDay;
        /* 0x3D8 */ public bool UseParticles;
        /* 0x3D9 */ public bool UseVolumetrics;
        /* 0x3DA */ public bool UseClouds;
        /* 0x3DB */ public bool UseTerrain;
        /* 0x3DC */ public bool UseInstances;
        /* 0x3DD */ public bool UseObjects;
        /* 0x3DE */ public bool UseBuildings;
        /* 0x3DF */ public bool UseCreatures;
        /* 0x3E0 */ public bool UseElevation;
        /* 0x3E1 */ public bool UseLegacyFreighters;
        /* 0x3E2 */ public bool SpawnPirates;
        /* 0x3E3 */ public bool SpawnRobots;
        /* 0x3E4 */ public bool SpawnShips;
        /* 0x3E5 */ public bool InstanceCollision;
        /* 0x3E6 */ public bool MPMissions;
        /* 0x3E7 */ public bool SpecialsShop;
        /* 0x3E8 */ public bool MouseLookEnabled;
        /* 0x3E9 */ public bool StartPaused;
        /* 0x3EA */ public bool DisableDebugControls;
        /* 0x3EB */ public bool DisableAsserts;
        /* 0x3EC */ public bool FixedFramerate;
        /* 0x3ED */ public bool ScreenshotMode;
        /* 0x3EE */ public bool RenderHud;
        /* 0x3EF */ public bool DisableDiscoveryNaming;
        /* 0x3F0 */ public bool DebugDrawPlayerInteract;
        /* 0x3F1 */ public bool ForceInteractionToSettings;
        /* 0x3F4 */ public float ForceInteractionIndex;
        /* 0x3F8 */ public bool InteractionsAllwaysGivesTech;
        /* 0x3F9 */ public bool InfiniteInteractions;
        /* 0x3FA */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x3FC */ public float DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x400 */ public string AllowedLanguagesFile;
        /* 0x420 */ public bool DoAlienLanguage;
        /* 0x424 */ public float ForceInteractionRaceTo;
        /* 0x428 */ public float RealityMode;
        /* 0x42C */ public bool DebugPersistentInteractions;
        [NMS(Size = 0x80)]
        /* 0x42D */ public string RealityPresetFile;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x4AD */ public byte[] Padding4AD;
        /* 0x4AE */ public short RealityGenerationIteration;
        [NMS(Size = 3)]
        /* 0x4B0 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x510 */ public string DefaultSaveData;
        /* 0x590 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x591 */ public bool ForceBasicLoadScreen;
        /* 0x594 */ public float BootLogoFadeRate;
        /* 0x598 */ public bool BootMusic;
        /* 0x59C */ public float WeaponScale3P;
        /* 0x5A0 */ public bool LogMissingLocalisedText;
        /* 0x5A1 */ public bool FleetDirectorAutoMode;
        /* 0x5A4 */ public float _3dTextDistance;
        /* 0x5A8 */ public float _3dTextMinScale;
        /* 0x5AC */ public int RecordSetting;
        public string[] RecordSettingValues()
        {
            return new[] { "None", "Record", "Playback" };
}
        /* 0x5B0 */ public bool DebugBuildingSpawns;
        /* 0x5B1 */ public bool StressTestLongNameDisplay;
        [NMS(Size = 0x20)]
        /* 0x5B2 */ public string SaveTestingCommand;
        /* 0x5D2 */ public bool NeverUseBanks;
        /* 0x5D3 */ public bool DisableProfanityFilter;
        /* 0x5D4 */ public bool DisableFileWatcher;
        /* 0x5D5 */ public bool ShowDebugMessages;
        /* 0x5D6 */ public bool ShowFramerate;
        /* 0x5D7 */ public bool ShowPositionDebug;
        /* 0x5D8 */ public bool ShowGPUMemory;
        /* 0x5D9 */ public bool ShowMempoolOverlay;
        /* 0x5DA */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x5DB */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x6DB */ public bool ShowGraphs;
        /* 0x6DC */ public bool GraphCommandBuffer;
        /* 0x6DD */ public bool GraphGeneration;
        /* 0x6DE */ public bool GraphFPS;
        /* 0x6DF */ public bool GraphTexStreaming;
        /* 0x6E0 */ public bool SmokeTestDumpStatsMode;
        /* 0x6E4 */ public int SmokeTestCycleMode;
        public string[] SmokeTestCycleModeValues()
        {
            return new[] { "None", "TourSolarSystem", "RegeneratePlanet" };
}
        /* 0x6E8 */ public bool SmokeTestCameraFly;
        /* 0x6EC */ public int SmokeTestConfigCaptureCycles;
        /* 0x6F0 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x6F4 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x6F8 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x6F9 */ public bool CreatureChatter;
        /* 0x6FA */ public bool CreatureErrors;
        /* 0x6FB */ public bool CreatureDrawVocals;
        /* 0x6FC */ public bool DrawCreaturesInRoutines;
        /* 0x6FD */ public bool ShowFirstPersonCharacterShadow;
        /* 0x6FE */ public bool CompressTextures;
        /* 0x6FF */ public bool DebugIBL;
        /* 0x700 */ public bool DebugTerrainTextures;
        /* 0x701 */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x702 */ public string PipelineFile;
        [NMS(Size = 0x80)]
        /* 0x782 */ public string PipelineFilePS4;
        [NMS(Size = 0x80)]
        /* 0x802 */ public string PipelineFileXboxOne;
        [NMS(Size = 0x80)]
        /* 0x882 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
        /* 0x902 */ public string PipelineFileFrontend;
        [NMS(Size = 0x80)]
        /* 0x982 */ public string PipelineFileEditor;
        /* 0xA02 */ public bool RenderLowFramerate;
        /* 0xA03 */ public bool EnableComputePost;
        /* 0xA04 */ public bool SimulateNoNetworkConnection;
        /* 0xA08 */ public int ProxyType;
        public string[] ProxyTypeValues()
        {
            return new[] { "None", "ManualURI", "InetProxy" };
}
        [NMS(Size = 0x80)]
        /* 0xA0C */ public string ProxyURI;
        /* 0xA8C */ public int ServerEnv;
        public string[] ServerEnvValues()
        {
            return new[] { "default", "dev", "qa", "prodqa", "prod", "custom", "pentest" };     // this and ProxyTypeValues swapped order in exe? 
}
        [NMS(Size = 0x80)]
        /* 0xA90 */ public string AuthBaseUrl;
        /* 0xB10 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xB11 */ public string OverrideUsernameForDev;
        /* 0xB34 */ public float DiscoveryAutoSyncIntervalSeconds;
        /* 0xB38 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xB39 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xB3A */ public NMSString0x100[] AutoJoinUserNames;
        /* 0x133A */ public bool AlwaysSaveGameAsClient;
        /* 0x133B */ public bool DisableMonumentDownloads;
        /* 0x133C */ public bool UsePadOnUnfocusedWindow;
        /* 0x1340 */ public float OverrideMatchmakingVersion;
        /* 0x1344 */ public bool IgnoreTransactionTimeouts;
        /* 0x1345 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x1346 */ public string SynergyServer;
        /* 0x1368 */ public int SynergyPort;
        /* 0x136C */ public bool ShowEditorPlacementPreview;
        /* 0x1370 */ public int MaxNumDebugMessages;
        /* 0x1374 */ public bool PreloadToolbox;
        /* 0x1378 */ public int DebugTextureSize;
        /* 0x137C */ public bool UseProcTextureDebugger;
        /* 0x1380 */ public int ProceduralModelsShown;
        /* 0x1384 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1388 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1408 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1488 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1508 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1588 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1608 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1688 */ public string RenderToTexture;
        /* 0x1708 */ public bool HmdEnable;
        /* 0x1709 */ public bool HmdOutput;
        /* 0x170A */ public bool HmdTracking;
        /* 0x170B */ public bool HmdStereoRender;
        /* 0x170C */ public bool HmdDistortionPassthru;
        /* 0x1710 */ public int HmdMonitor;
        /* 0x1714 */ public float HmdEyeBufferWidth;
        /* 0x1718 */ public float HmdEyeBufferHeight;
        /* 0x171C */ public float HmdEyeScalePos;
        /* 0x1720 */ public float HmdHeadScalePos;
        /* 0x1724 */ public float HmdImmersionFactor;
        /* 0x1728 */ public bool ForceExtremeWeather;
        /* 0x1729 */ public bool ForceExtremeSentinels;
        /* 0x172A */ public bool ForceStarType;
        /* 0x172C */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1730 */ public bool ForceBiome;
        /* 0x1734 */ public GcBiomeType ForceBiomeTo;
        /* 0x1738 */ public int ForceBiomeFileIndex;
        /* 0x173C */ public bool ForceBuildingRace;
        /* 0x1740 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1744 */ public bool ForceLifeLevel;
        /* 0x1748 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x174C */ public bool ForceCreatureLifeLevel;
        /* 0x174D */ public bool ForceDefaultCreatureFile;
        /* 0x1750 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1754 */ public int ForceTerrainSettings;       // maybe TkVoxelGeneratorSettingsTypes??
        /* 0x1758 */ public bool ForceTerrainType;
        /* 0x175C */ public int ForceTerranTypeTo;
        /* 0x1760 */ public int ForceAnomalyTo;
        public string[] ForceAnomalyToValues()
        {
            return new[] { "None", "AtlasType1", "AtlasType2", "Blackhole", "Anomaly", "Spacewalk" };
        }
        /* 0x1764 */ public bool ForcePlanetsToHaveWater;
        /* 0x1765 */ public bool DisableLimits;
        /* 0x1766 */ public bool LimitPerRegionInstances;
        /* 0x1767 */ public bool LimitPerRegionBodies;
        /* 0x1768 */ public bool LimitGlobalInstances;
        /* 0x1769 */ public bool LimitGlobalBodies;
        /* 0x176C */ public int GenerateFarLodBuildingDist;
        /* 0x1770 */ public bool DeferRegionBodies;
        /* 0x1774 */ public float GenerateCostDistance;
        /* 0x1778 */ public float GenerateCostAngle;
        /* 0x177C */ public float GenerateCostLOD;
        /* 0x1780 */ public float GenerateCostWait;
        /* 0x1784 */ public bool DChecksEnabled;
        /* 0x1785 */ public bool DChecksOutputJson;
        /* 0x1786 */ public bool DChecksOutputBinary;
        /* 0x1787 */ public bool DChecksOutputFileLine;
        /* 0x1788 */ public int FrameFlipRateDefault;
        /* 0x178C */ public int FrameFlipRateLoad;
        /* 0x1790 */ public int FrameFlipRateGame;
        /* 0x1794 */ public float MaxFrameRate;
        /* 0x1798 */ public bool DisableBaseBuilding;
        /* 0x1799 */ public bool DisableBaseBuildingLimits;
        /* 0x179C */ public float BaseDownloadTimeout;
    }
}

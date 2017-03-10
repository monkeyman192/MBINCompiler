namespace MBINCompiler.Models.Structs
{
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x00 */ public bool SkipIntro;
        /* 0x01 */ public bool VideoCaptureMode;
        /* 0x02 */ public bool GodMode;
		/* 0x03	*/ public bool AlwaysHaveFocus;
        /* 0x04 */ public bool DisableVibration;
        /* 0x05 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x06 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x07 */ public bool EverythingIsFree;
        /* 0x08 */ public bool EverythingIsKnown;
        /* 0x09 */ public bool EverythingIsStar;
        /* 0x0A */ public bool UseScreenEffects;
        /* 0x0B */ public bool UseGunImpactEffect;
        /* 0x0C */ public bool RenderCreatureDetails;
		/* 0x0D */ public bool UseDebugScreenSettings;
        /* 0x10 */ public int ScreenWidth;
        /* 0x14 */ public int ScreenHeight;
        /* 0x18 */ public bool DisableVSync;
        /* 0x1C */ public int GameWindowMode;
        public string[] GameWindowModeValues()
        {
            return new[] { "Bordered", "Borderless", "Fullscreen" };
        }

        /* 0x20 */ public int Monitor;
		/* should there be padding here? */
        [NMS(Size = 0x100)]
        /* 0x123? */ public string ForceUniverseAddress; // 0x100
        [NMS(Size = 0x100)]
        /* 0x223 */ public string ForcePlayerPosition; // 0x100

        /* 0x224 */ public bool ForceInitialShip;
        /* 0x225 */ public bool ForceInitialWeapon;
        /* 0x228 */ public int GameStateMode;
        public string[] GameStateModeValues()
        {
            return new[] { "LoadPreset", "UserStorage", "FreshStart" };
        }

        /* 0x22C */ public int BootMode;
        public string[] BootModeValues()
        {
            return new[] { "SolarSystem", "GalaxyMap", "SmokeTest", "SmokeTestGalaxyMap", "Scratchpad", "UnitTest" };
        }
        /* 0x230 */ public int PlayerSpawnLocationOverride;
        public string[] PlayerSpawnLocationOverrideValues()
        {
            return new[] { "None", "FromSettings", "Space", "SpaceStation", "RandomPlanet", "GameStartPlanet" };
        }

        [NMS(Size = 0x80)]
        /* 0x234 */ public string SceneSettings; // 0x80
        [NMS(Size = 0x100)]
        /* 0x2B4 */ public string WorkingDirectory; // 0x100

        /* 0x3B4 */ public int SolarSystemBoot;
        public string[] SolarSystemBootValues()
        {
            return new[] { "FromSettings", "Generate" };
        }
        /* 0x3B8 */ public int ShaderPreload;
        public string[] ShaderPreloadValues()
        {
            return new[] { "Off", "Full" };
        }
		/* Unsure of whats going on with PresetGameMode, I added it but its way shorter than everything else  Check address 1401BC1D2 */
		/* 0x3BC?*/ public int PresetGameMode; // Looks just like DebugLanguages below which had unused note
        /* 0x3C0 */ public bool ShaderPreloadListExport;
        /* 0x3C1 */ public bool ShaderPreloadListImport;
        /* 0x3C2 */ public bool ShaderCaching;
		/* 2 bit int? this seems weird should this be a short instead of int?*/
        /* 0x3C4 */ public int BootLoadDelay;
        public string[] BootLoadDelayValues()
        {
            return new[] { "LoadAll", "WaitForPlanet", "WaitForNothing" };
        }
        /* 0x3C8 */ public bool UseParticles;
        /* 0x3C9 */ public bool UseVolumetrics;
        /* 0x3CA */ public bool UseClouds;
        /* 0x3CB */ public bool UseTerrain;
        /* 0x3CC */ public bool UseInstances;
        /* 0x3CD */ public bool UseObjects;
        /* 0x3CE */ public bool UseBuildings;
        /* 0x3CF */ public bool UseCreatures;
        /* 0x3D0 */ public bool UseElevation;
        /* 0x3D1 */ public bool SpawnPirates;
        /* 0x3D2 */ public bool SpawnRobots;
        /* 0x3D3 */ public bool SpawnShips;
        /* 0x3D4 */ public bool InstanceCollision;
        /* 0x3D5 */ public bool MouseLookEnabled;
        /* 0x3D6 */ public bool StartPaused;
        /* 0x3D7 */ public bool DisableDebugControls;
        /* 0x3D8 */ public bool DisableAsserts;
        /* 0x3D9 */ public bool FixedFramerate;
        /* 0x3DA */ public bool ScreenshotMode;
        /* 0x3DB */ public bool RenderHud;
		/* 0x3DC */ public bool DisableDiscoveryNaming;
        /* 0x3DD */ public bool DebugDrawPlayerInteract;
        /* 0x3DE */ public bool ForceInteractionToSettings;
        /* 0x3E0 */ public int ForceInteractionIndex;
        /* 0x3E4 */ public bool InteractionsAllwaysGivesTech; // (sic)
        /* 0x3E5 */ public bool InfiniteInteractions;
        /* 0x3E6 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x3E7 */ public int DebugLanguages; // unused?

        [NMS(Size = 0x20)]
        /* 0x40B */ public string AllowedLanguagesFile; // 0x20
        /* 0x40C */ public bool DoAlienLanguage;
        /* 0x410 */ public int ForceInteractionRaceTo; // unused?
        /* 0x414 */ public int RealityMode;
        public string[] RealityModeValues()
        {
            return new[] { "LoadPreset", "Generate" };
        }
        /* 0x418 */ public bool DebugPersistentInteractions;

        [NMS(Size = 0x80)]
        /* 0x498 */ public string RealityPresetFile; // 0x80
        /* 0x49A */ public short RealityGenerationIteration;

        [NMS(Size = 0x80)]
        /* 0x51B */ public string DefaultSaveData; // 0x80
        /* 0x51C */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x51D */ public bool ForceBasicLoadScreen;
        /* 0x520 */ public float BootLogoFadeRate;
        /* 0x524 */ public bool BootMusic;
        /* 0x525 */ public bool LogMissingLocalisedText;
        /* 0x526 */ public bool FleetDirectorAutoMode;
        /* 0x528 */ public float _3dTextDistance;
        /* 0x52C */ public float _3dTextMinScale;
        /* 0x530 */ public int RecordSetting;
        public string[] RecordSettingValues()
        {
            return new[] { "None", "Record", "Playback" }; // "None" isnt specified in exe
        }
        /* 0x534 */ public bool DebugBuildingSpawns;
        /* 0x535 */ public bool StressTestLongNameDisplay;
        /* 0x536 */ public bool ShowFramerate;
        /* 0x537 */ public bool ShowPositionDebug;
        /* 0x538 */ public bool ShowGPUMemory;
        /* 0x539 */ public bool ShowMempoolOverlay;

        [NMS(Size = 0x100)]
        /* 0x53A */ public string ShowUniverseAddressOnGalaxyMap; // 0x100
        /* 0x63A */ public bool ShowGraphs;
        /* 0x63B */ public bool GraphCommandBuffer;
        /* 0x63C */ public bool GraphGeneration;
        /* 0x63D */ public bool GraphFPS;
        /* 0x63E */ public bool SmokeTestDumpStatsMode;
        /* 0x640 */ public int SmokeTestCycleMode;
        public string[] SmokeTestCycleModeValues()
        {
            return new[] { "None", "TourSolarSystem", "RegeneratePlanet" };// "None" isnt specified in exe
        }
        /* 0x644 */ public bool SmokeTestCameraFly;
        /* 0x648 */ public int SmokeTestConfigCaptureCycles;
        /* 0x64C */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x650 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x654 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x655 */ public bool CreatureChatter;
        /* 0x656 */ public bool CreatureErrors;
        /* 0x657 */ public bool CreatureDrawVocals;
        /* 0x658 */ public bool DrawCreaturesInRoutines;
        /* 0x659 */ public bool CompressTextures;
        /* 0x65A */ public bool DebugIBL;
        /* 0x65B */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x65C */ public string PipelineFile; // 0x80
        [NMS(Size = 0x80)]
        /* 0x6DC */ public string PipelineFilePS4; // 0x80
        /* 0x75C */ public bool RenderLowFramerate;
        /* 0x75D */ public bool SimulateNoNetworkConnection;
        /* 0x760 */ public int ProxyType;
        public string[] ProxyTypeValues()
        {
            return new[] { "None", "ManualURI", "InetProxy" };
        }
        [NMS(Size = 0x80)]
        /* 0x764 */ public string ProxyURI; // 0x80
        /* 0x7E4 */ public int ServerEnv;
        public string[] ServerEnvValues()
        {
            return new[] { "default", "dev", "prodqa", "prod", "custom", "pentest" }; // There was a "qa" entry between "dev" and "prodqa" but that seems to have been removed in exe
        }
        [NMS(Size = 0x80)]
        /* 0x7E8 */ public string AuthBaseUrl; // 0x80
        /* 0x868 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x869 */ public string OverrideUsernameForDev; // 0x20
        /* 0x88C */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x888 */ //public int DiscoveryTrimLimitOverride; // Looks like both these
        /* 0x88C */ //public int DiscoveryTrimTriggerOverride; // lines have been removed in exe
        /* 0x890 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x891 */ public string SynergyServer; // 0x20
        /* 0x8B4 */ public int SynergyPort;
        /* 0x8B8 */ public int MaxNumDebugMessages;
        /* 0x8BC */ public bool PreloadToolbox;
        /* 0x8C0 */ public int DebugTextureSize;
        /* 0x8C4 */ public bool UseProcTextureDebugger;
        /* 0x8C8 */ public int ProceduralModelsShown;
        /* 0x8CC */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x8D0 */ public string DebugFont; // 0x80
        [NMS(Size = 0x80)]
        /* 0x950 */ public string DebugFontTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0x9D0 */ public string CursorTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xA50 */ public string PauseTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xAD0 */ public string PlayTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xB50 */ public string StepTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xBD0 */ public string RenderToTexture; // 0x80
        /* 0xC50 */ public bool HmdEnable;
        /* 0xC51 */ public bool HmdOutput;
        /* 0xC52 */ public bool HmdTracking;
        /* 0xC53 */ public bool HmdStereoRender;
        /* 0xC54 */ public bool HmdDistortionPassthru;
        /* 0xC58 */ public int HmdMonitor; // (int?)
        /* 0xC5C */ public int HmdEyeBufferWidth;
        /* 0xC60 */ public int HmdEyeBufferHeight;
        /* 0xC64 */ public float HmdEyeScalePos;
        /* 0xC68 */ public float HmdHeadScalePos;
        /* 0xC6C */ public float HmdImmersionFactor;
        /* 0xC70 */ public bool ForceExtremeWeather;
        /* 0xC71 */ public bool ForceExtremeSentinels;
		/* 0xC72 */ public bool ForceStarType;
		/* 0xC73?*/ public int ForceStarTypeTo; // unused? added
        /* 0xC78 */ public bool ForceBiome;
        /* 0xC7C?*/ public int ForceBiomeTo; // unused?
        /* 0xC80 */ public bool ForceBuildingRace;
        /* 0xC81?*/ public int ForceBuildingRaceTo; // unused?
        /* 0xC88 */ public bool ForceLifeLevel;
        /* 0xC89?*/ public int ForceLifeLevelTo; // unused?
        /* 0xC8D?*/ public int ForceAnomalyTo; // unused?
        /* 0xC94 */ public bool DisableLimits;
        /* 0xC95 */ public bool LimitPerRegionInstances;
        /* 0xC96 */ public bool LimitPerRegionBodies;
        /* 0xC97 */ public bool LimitGlobalInstances;
        /* 0xC98 */ public bool LimitGlobalBodies;
        /* 0xC9C */ public int GenerateFarLodBuildingDist;
        /* 0xCA0 */ public bool DeferRegionBodies;
        /* 0xCA4 */ public float GenerateCostDistance;
        /* 0xCA8 */ public float GenerateCostAngle;
        /* 0xCAC */ public float GenerateCostLOD;
        /* 0xCB0 */ public float GenerateCostWait;
        /* 0xCB4 */ public bool DChecksEnabled;
        /* 0xCB5 */ public bool DChecksOutputJson;
        /* 0xCB6 */ public bool DChecksOutputBinary;
        /* 0xCB7 */ public bool DChecksOutputFileLine;
        /* 0xCB8 */ public int FrameFlipRateDefault;
        /* 0xCBC */ public int FrameFlipRateLoad;
        /* 0xCC0 */ public int FrameFlipRateGame;
        /* 0xCC4 */ public float MaxFrameRate;
		/* 0xCC8 */ public bool DisableBaseBuilding; // looks like a bool but its 4 bytes?
		/* 0xCC9 */ public bool DisableBaseBuildingLimits;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x00 */ public bool SkipIntro;
        /* 0x01 */ public bool VideoCaptureMode;
        /* 0x02 */ public bool GodMode;
        /* 0x03 */ public bool DisableVibration;
        /* 0x04 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x05 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x06 */ public bool EverythingIsFree;
        /* 0x07 */ public bool EverythingIsKnown;
        /* 0x08 */ public bool EverythingIsStar;
        /* 0x09 */ public bool UseScreenEffects;
        /* 0x0A */ public bool UseGunImpactEffect;
        /* 0x0B */ public bool RenderCreatureDetails;
        /* 0x0C */ public int ScreenWidth;
        /* 0x10 */ public int ScreenHeight;
        /* 0x14 */ public bool DisableVSync;
        /* 0x18 */ public int GameWindowMode;
        public string[] GameWindowModeValues()
        {
            return new[] { "Bordered", "Borderless", "Fullscreen" };
        }

        /* 0x1C */ public int Monitor;

        [NMS(Size = 0x100)]
        /* 0x20 */ public string ForceUniverseAddress; // 0x100
        [NMS(Size = 0x100)]
        /* 0x120 */ public string ForcePlayerPosition; // 0x100

        /* 0x220 */ public bool ForceInitialShip;
        /* 0x221 */ public bool ForceInitialWeapon;
        /* 0x224 */ public int GameStateMode;
        public string[] GameStateModeValues()
        {
            return new[] { "LoadPreset", "UserStorage", "FreshStart" };
        }

        /* 0x228 */ public int BootMode;
        public string[] BootModeValues()
        {
            return new[] { "SolarSystem", "GalaxyMap", "SmokeTest", "SmokeTestGalaxyMap", "Scratchpad", "UnitTest" };
        }
        /* 0x22C */ public int PlayerSpawnLocationOverride;
        public string[] PlayerSpawnLocationOverrideValues()
        {
            return new[] { "None", "InNearestStation", "OnNearestPlanet", "OnFurthestPlanet", "NextToPlayerShip", "FromSettings", "OnRandomPlanet", "OnGameStartPlanet", "AwayFromYourShip" };
        }

        [NMS(Size = 0x80)]
        /* 0x230 */ public string SceneSettings; // 0x80
        [NMS(Size = 0x100)]
        /* 0x2B0 */ public string WorkingDirectory; // 0x100

        /* 0x3B0 */ public int SolarSystemBoot;
        public string[] SolarSystemBootValues()
        {
            return new[] { "FromSettings", "Generate" };
        }
        /* 0x3B4 */ public int ShaderPreload;
        public string[] ShaderPreloadValues()
        {
            return new[] { "Off", "Full" };
        }
        /* 0x3B8 */ public bool ShaderPreloadListExport;
        /* 0x3B9 */ public bool ShaderPreloadListImport;
        /* 0x3BA */ public bool ShaderCaching;
        /* 0x3BC */ public int BootLoadDelay;
        public string[] BootLoadDelayValues()
        {
            return new[] { "LoadAll", "WaitForPlanet", "WaitForNothing" };
        }
        /* 0x3C0 */ public bool UseParticles;
        /* 0x3C1 */ public bool UseVolumetrics;
        /* 0x3C2 */ public bool UseClouds;
        /* 0x3C3 */ public bool UseTerrain;
        /* 0x3C4 */ public bool UseInstances;
        /* 0x3C5 */ public bool UseObjects;
        /* 0x3C6 */ public bool UseBuildings;
        /* 0x3C7 */ public bool UseCreatures;
        /* 0x3C8 */ public bool UseElevation;
        /* 0x3C9 */ public bool SpawnPirates;
        /* 0x3CA */ public bool SpawnRobots;
        /* 0x3CB */ public bool SpawnShips;
        /* 0x3CC */ public bool InstanceCollision;
        /* 0x3CD */ public bool MouseLookEnabled;
        /* 0x3CE */ public bool StartPaused;
        /* 0x3CF */ public bool DisableDebugControls;
        /* 0x3D0 */ public bool DisableAsserts;
        /* 0x3D1 */ public bool FixedFramerate;
        /* 0x3D2 */ public bool ScreenshotMode;
        /* 0x3D3 */ public bool RenderHud;
        /* 0x3D4 */ public bool DebugDrawPlayerInteract;
        /* 0x3D5 */ public bool ForceInteractionToSettings;
        /* 0x3D8 */ public int ForceInteractionIndex;
        /* 0x3DC */ public bool InteractionsAllwaysGivesTech; // (sic)
        /* 0x3DD */ public bool InfiniteInteractions;
        /* 0x3DE */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x3E0 */ public int DebugLanguages; // unused?

        [NMS(Size = 0x20)]
        /* 0x3E4 */ public string AllowedLanguagesFile; // 0x20
        /* 0x404 */ public bool DoAlienLanguage;
        /* 0x408 */ public int ForceInteractionRaceTo;
        /* 0x40C */ public int RealityMode; // unused?
        public string[] RealityModeValues()
        {
            return new[] { "LoadPreset", "Generate" };
        }
        /* 0x410 */ public bool DebugPersistentInteractions;

        [NMS(Size = 0x80)]
        /* 0x411 */ public string RealityPresetFile; // 0x80
        /* 0x492 */ public short RealityGenerationIteration;

        [NMS(Size = 0x80)]
        /* 0x494 */ public string DefaultSaveData; // 0x80
        /* 0x514 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x515 */ public bool ForceBasicLoadScreen;
        /* 0x518 */ public float BootLogoFadeRate;
        /* 0x51C */ public bool BootMusic;
        /* 0x51D */ public bool LogMissingLocalisedText;
        /* 0x51E */ public bool FleetDirectorAutoMode;
        /* 0x520 */ public float _3dTextDistance;
        /* 0x524 */ public float _3dTextMinScale;
        /* 0x528 */ public int RecordSetting;
        public string[] RecordSettingValues()
        {
            return new[] { "None", "Record", "Playback" };
        }
        /* 0x52C */ public bool DebugBuildingSpawns;
        /* 0x52D */ public bool StressTestLongNameDisplay;
        /* 0x52E */ public bool ShowFramerate;
        /* 0x52F */ public bool ShowPositionDebug;
        /* 0x530 */ public bool ShowGPUMemory;
        /* 0x531 */ public bool ShowMempoolOverlay;

        [NMS(Size = 0x100)]
        /* 0x532 */ public string ShowUniverseAddressOnGalaxyMap; // 0x100
        /* 0x632 */ public bool ShowGraphs;
        /* 0x633 */ public bool GraphCommandBuffer;
        /* 0x634 */ public bool GraphGeneration;
        /* 0x635 */ public bool GraphFPS;
        /* 0x636 */ public bool SmokeTestDumpStatsMode;
        /* 0x638 */ public int SmokeTestCycleMode;
        public string[] SmokeTestCycleModeValues()
        {
            return new[] { "None", "TourSolarSystem", "RegeneratePlanet" };
        }
        /* 0x63C */ public bool SmokeTestCameraFly;
        /* 0x640 */ public int SmokeTestConfigCaptureCycles;
        /* 0x644 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x648 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x64C */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x64D */ public bool CreatureChatter;
        /* 0x64E */ public bool CreatureErrors;
        /* 0x64F */ public bool CreatureDrawVocals;
        /* 0x650 */ public bool DrawCreaturesInRoutines;
        /* 0x651 */ public bool CompressTextures;
        /* 0x652 */ public bool DebugIBL;
        /* 0x653 */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x654 */ public string PipelineFile; // 0x80
        [NMS(Size = 0x80)]
        /* 0x6D4 */ public string PipelineFilePS4; // 0x80
        /* 0x754 */ public bool RenderLowFramerate;
        /* 0x755 */ public bool SimulateNoNetworkConnection;
        /* 0x758 */ public int ProxyType;
        public string[] ProxyTypeValues()
        {
            return new[] { "None", "ManualURI", "InetProxy" };
        }
        [NMS(Size = 0x80)]
        /* 0x75C */ public string ProxyURI; // 0x80
        /* 0x7DC */ public int ServerEnv;
        public string[] ServerEnvValues()
        {
            return new[] { "default", "dev", "qa", "prodqa", "prod", "custom", "pentest" };
        }
        [NMS(Size = 0x80)]
        /* 0x7E0 */ public string AuthBaseUrl; // 0x80
        /* 0x860 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x861 */ public string OverrideUsernameForDev; // 0x20
        /* 0x884 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x888 */ public int DiscoveryTrimLimitOverride;
        /* 0x88C */ public int DiscoveryTrimTriggerOverride;
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
        /* 0xC72 */ public bool ForceBiome;
        /* 0xC74 */ public int ForceBiomeTo; // unused?
        /* 0xC78 */ public bool ForceBuildingRace;
        /* 0xC7C */ public int ForceBuildingRaceTo; // unused?
        /* 0xC80 */ public bool ForceLifeLevel;
        /* 0xC84 */ public int ForceLifeLevelTo; // unused?
        /* 0xC88 */ public int ForceAnomalyTo; // unused?
        /* 0xC8C */ public bool DisableLimits;
        /* 0xC8D */ public bool LimitPerRegionInstances;
        /* 0xC8E */ public bool LimitPerRegionBodies;
        /* 0xC8F */ public bool LimitGlobalInstances;
        /* 0xC90 */ public bool LimitGlobalBodies;
        /* 0xC94 */ public int GenerateFarLodBuildingDist;
        /* 0xC98 */ public bool DeferRegionBodies;
        /* 0xC9C */ public float GenerateCostDistance;
        /* 0xCA0 */ public float GenerateCostAngle;
        /* 0xCA4 */ public float GenerateCostLOD;
        /* 0xCA8 */ public float GenerateCostWait;
        /* 0xCAC */ public bool DChecksEnabled;
        /* 0xCAD */ public bool DChecksOutputJson;
        /* 0xCAE */ public bool DChecksOutputBinary;
        /* 0xCAF */ public bool DChecksOutputFileLine;
        /* 0xCB0 */ public int FrameFlipRateDefault;
        /* 0xCB4 */ public int FrameFlipRateLoad;
        /* 0xCB8 */ public int FrameFlipRateGame;
        /* 0xCBC */ public float MaxFrameRate;
        /* 0xCC0 = END */
    }
}

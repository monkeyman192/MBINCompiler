using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7478E9B7BD83627A, NameHash = 0xD42BEC5C)]
    public class TkGlobals : NMSTemplate
    {
        // size: 0x4
        public enum AssertsLevelEnum : uint {
            Disabled,
            Ignored,
            Skipped,
            Enabled,
        }
        [NMS(Index = 0)]
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        // size: 0x9
        [Flags]
        public enum EnabledChannelsEnum : uint {
            None = 0x0,
            Default = 0x1,
            Note = 0x2,
            Error = 0x4,
            Warning = 0x8,
            Info = 0x10,
            Alt = 0x20,
            AltWarn = 0x40,
            AltError = 0x80,
        }
        [NMS(Index = 4)]
        /* 0x004 */ public EnabledChannelsEnum EnabledChannels;
        [NMS(Index = 36)]
        /* 0x008 */ public int EnableOit;
        // size: 0xD
        public enum ForceGPUPresetToEnum : uint {
            PC_Low,
            PC_Medium,
            PC_High,
            PC_Ultra,
            PS4,
            PS4VR,
            PS4Pro,
            PS4ProVR,
            XB1,
            XB1X,
            Oberon,
            MacOS,
            iOS,
        }
        [NMS(Index = 32)]
        /* 0x00C */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        [NMS(Index = 101)]
        /* 0x010 */ public int FrameFlipRateDefault;
        [NMS(Index = 103)]
        /* 0x014 */ public int FrameFlipRateGame;
        [NMS(Index = 102)]
        /* 0x018 */ public int FrameFlipRateLoad;
        // size: 0x5
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
            Maximised,
            Minimised,
        }
        [NMS(Index = 56)]
        /* 0x01C */ public GameWindowModeEnum GameWindowMode;
        [NMS(Index = 8)]
        /* 0x020 */ public int HavokVDBClientIndex;
        [NMS(Index = 29)]
        /* 0x024 */ public int HighlightPlacementIndex;
        [NMS(Index = 97)]
        /* 0x028 */ public int HmdEyeBufferHeight;
        [NMS(Index = 96)]
        /* 0x02C */ public int HmdEyeBufferWidth;
        [NMS(Index = 98)]
        /* 0x030 */ public float HmdEyeScalePos;
        [NMS(Index = 99)]
        /* 0x034 */ public float HmdHeadScalePos;
        [NMS(Index = 100)]
        /* 0x038 */ public float HmdImmersionFactor;
        [NMS(Index = 95)]
        /* 0x03C */ public int HmdMonitor;
        [NMS(Index = 91)]
        /* 0x040 */ public int HmdPreviewScale;
        [NMS(Index = 76)]
        /* 0x044 */ public float ImposterTextureDensity;
        [NMS(Index = 9)]
        /* 0x048 */ public int LoadBalanceTimeoutMS;
        [NMS(Index = 26)]
        /* 0x04C */ public int LODOverride;
        [NMS(Index = 104)]
        /* 0x050 */ public float MaxFrameRate;
        [NMS(Index = 57)]
        /* 0x054 */ public int Monitor;
        [NMS(Index = 74)]
        /* 0x058 */ public int OctahedralImpostersViewCount;
        [NMS(Index = 11)]
        /* 0x05C */ public int PSVR2LoadBalanceTimeoutMS;
        [NMS(Index = 111)]
        /* 0x060 */ public float ScratchpadInstanceScale;
        [NMS(Index = 113)]
        /* 0x064 */ public int ScratchpadInstancesCap;
        [NMS(Index = 110)]
        /* 0x068 */ public float ScratchpadInstanceSpacing;
        [NMS(Index = 112)]
        /* 0x06C */ public int ScratchpadInstancesPerSide;
        [NMS(Index = 114)]
        /* 0x070 */ public float ScratchpadInstancesRandomness;
        [NMS(Index = 107)]
        /* 0x074 */ public int ScratchpadModelSeed;
        [NMS(Index = 54)]
        /* 0x078 */ public int ScreenHeight;
        [NMS(Index = 53)]
        /* 0x07C */ public int ScreenWidth;
        [NMS(Index = 59)]
        /* 0x080 */ public int TiledWindowsIndex;
        [NMS(Index = 58)]
        /* 0x084 */ public int TiledWindowsSplitCount;
        [NMS(Index = 13)]
        /* 0x088 */ public float TitlebarMenuOffset;
        [NMS(Index = 21)]
        /* 0x08C */ public float TouchScreenSwipeTime;
        [NMS(Index = 20)]
        /* 0x090 */ public float TouchScreenSwipeTravelThreshold;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        [NMS(Index = 88)]
        /* 0x094 */ public TrialStatusEnum TrialStatus;
        [NMS(Index = 82)]
        /* 0x098 */ public float UpdatePeriod;
        [NMS(Index = 83)]
        /* 0x09C */ public float UpdatePeriodSteam;
        [NMS(Index = 84)]
        /* 0x0A0 */ public float VoiceUpdatePeriod;
        [NMS(Index = 85)]
        /* 0x0A4 */ public float VoiceUpdatePeriodSteam;
        [NMS(Index = 10)]
        /* 0x0A8 */ public int VRLoadBalanceTimeoutMS;
        [NMS(Index = 50)]
        /* 0x0AC */ public int WindowPositionX;
        [NMS(Index = 51)]
        /* 0x0B0 */ public int WindowPositionY;
        [NMS(Index = 44)]
        /* 0x0B4 */ public float WwiseVibrationMultiplierPrimary;
        [NMS(Index = 45)]
        /* 0x0B8 */ public float WwiseVibrationMultiplierSecondary;
        [NMS(Index = 65)]
        /* 0x0BC */ public NMSString0x100 EditorLayout;
        [NMS(Index = 6)]
        /* 0x1BC */ public NMSString0x100 ExcludeLogFilter;
        [NMS(Index = 5)]
        /* 0x2BC */ public NMSString0x100 IncludeLogFilter;
        [NMS(Index = 106)]
        /* 0x3BC */ public NMSString0x100 ScratchpadModel;
        [NMS(Index = 86)]
        /* 0x4BC */ public NMSString0x20 OverrideUsernameForDev;
        [NMS(Index = 78)]
        /* 0x4DC */ public bool AllowBindlessDraws;
        [NMS(Index = 40)]
        /* 0x4DD */ public bool AllowDynamicRenderingOnVulkan;
        [NMS(Index = 25)]
        /* 0x4DE */ public bool AllowDynamicResScaling;
        [NMS(Index = 12)]
        /* 0x4DF */ public bool AllowInPlaceNGuiElementRenaming;
        [NMS(Index = 39)]
        /* 0x4E0 */ public bool AllowMultiThreadedRenderingOnVulkan;
        [NMS(Index = 1)]
        /* 0x4E1 */ public bool AssertsPopupAlwaysOnTop;
        [NMS(Index = 15)]
        /* 0x4E2 */ public bool AutoTabNewlyOpenedWindows;
        [NMS(Index = 27)]
        /* 0x4E3 */ public bool ColourLODs;
        [NMS(Index = 28)]
        /* 0x4E4 */ public bool ColourVertexDensity;
        [NMS(Index = 75)]
        /* 0x4E5 */ public bool CompressImposterTextures;
        [NMS(Index = 41)]
        /* 0x4E6 */ public bool CrashOnFailedCriticalAssertion;
        [NMS(Index = 2)]
        /* 0x4E7 */ public bool DefaultSelectIgnoreAsserts;
        [NMS(Index = 3)]
        /* 0x4E8 */ public bool DisableAssertUpload;
        [NMS(Index = 35)]
        /* 0x4E9 */ public bool DisableImposters;
        [NMS(Index = 48)]
        /* 0x4EA */ public bool DisableMultiplayer;
        [NMS(Index = 24)]
        /* 0x4EB */ public bool DisableResScaling;
        [NMS(Index = 22)]
        /* 0x4EC */ public bool DisableSwitchingAwayFromPad;
        [NMS(Index = 77)]
        /* 0x4ED */ public bool DisableUndergrowthInstanceRendering;
        [NMS(Index = 55)]
        /* 0x4EE */ public bool DisableVSync;
        [NMS(Index = 71)]
        /* 0x4EF */ public bool EnableGpuBreadcrumbs;
        [NMS(Index = 70)]
        /* 0x4F0 */ public bool EnableNvidiaAftermath;
        [NMS(Index = 68)]
        /* 0x4F1 */ public bool EnablePix;
        [NMS(Index = 72)]
        /* 0x4F2 */ public bool EnableRayTracing;
        [NMS(Index = 67)]
        /* 0x4F3 */ public bool EnableRenderdoc;
        [NMS(Index = 23)]
        /* 0x4F4 */ public bool EnableShaderReload;
        [NMS(Index = 38)]
        /* 0x4F5 */ public bool EnableSSS;
        [NMS(Index = 19)]
        /* 0x4F6 */ public bool EnableVirtualTouchScreen;
        [NMS(Index = 7)]
        /* 0x4F7 */ public bool EnableZstdSaves;
        [NMS(Index = 16)]
        /* 0x4F8 */ public bool FavouritesAndUndoEnabledByDefault;
        [NMS(Index = 14)]
        /* 0x4F9 */ public bool FilterTranslatedTextWhenSearching;
        [NMS(Index = 31)]
        /* 0x4FA */ public bool ForceGPUPreset;
        [NMS(Index = 62)]
        /* 0x4FB */ public bool ForceRunAllHavokWorldsMultiThreaded;
        [NMS(Index = 42)]
        /* 0x4FC */ public bool ForceSteamDeck;
        [NMS(Index = 43)]
        /* 0x4FD */ public bool ForceWinGdkHandheld;
        [NMS(Index = 105)]
        /* 0x4FE */ public bool FrameRateSpikeTestEnabled;
        [NMS(Index = 34)]
        /* 0x4FF */ public bool FreezeCulling;
        [NMS(Index = 69)]
        /* 0x500 */ public bool HideRenderdocOverlay;
        [NMS(Index = 94)]
        /* 0x501 */ public bool HmdDistortionPassthru;
        [NMS(Index = 89)]
        /* 0x502 */ public bool HmdEnable;
        [NMS(Index = 90)]
        /* 0x503 */ public bool HmdFoveated;
        [NMS(Index = 93)]
        /* 0x504 */ public bool HmdStereoRender;
        [NMS(Index = 92)]
        /* 0x505 */ public bool HmdTracking;
        [NMS(Index = 37)]
        /* 0x506 */ public bool JitterRenderOffsetEveryFrame;
        [NMS(Index = 66)]
        /* 0x507 */ public bool LoadRelativeEditorLayouts;
        [NMS(Index = 18)]
        /* 0x508 */ public bool LogInputChanges;
        [NMS(Index = 17)]
        /* 0x509 */ public bool LogInputSetup;
        [NMS(Index = 33)]
        /* 0x50A */ public bool MakeUnusedUniformsNaN;
        [NMS(Index = 30)]
        /* 0x50B */ public bool MinGPUMode;
        [NMS(Index = 73)]
        /* 0x50C */ public bool OctahedralImpostersViewFromSpace;
        [NMS(Index = 60)]
        /* 0x50D */ public bool RunAllHavokWorldsSingleThreaded;
        [NMS(Index = 61)]
        /* 0x50E */ public bool RunOnlyHavokSubworldsSingleThreaded;
        [NMS(Index = 63)]
        /* 0x50F */ public bool SampleCollisionWithCamera;
        [NMS(Index = 108)]
        /* 0x510 */ public bool ScratchpadInstanced;
        [NMS(Index = 109)]
        /* 0x511 */ public bool ScratchpadWind;
        [NMS(Index = 64)]
        /* 0x512 */ public bool ShowPlayerCollisions;
        [NMS(Index = 47)]
        /* 0x513 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 49)]
        /* 0x514 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 52)]
        /* 0x515 */ public bool UseDebugScreenSettings;
        [NMS(Index = 46)]
        /* 0x516 */ public bool UseHeavyAir;
        [NMS(Index = 87)]
        /* 0x517 */ public bool UseOverrideUsernameForSavePath;
        [NMS(Index = 79)]
        /* 0x518 */ public bool VulkanValidationEnabled;
        [NMS(Index = 80)]
        /* 0x519 */ public bool VulkanValidationPrintMessages;
        [NMS(Index = 81)]
        /* 0x51A */ public bool VulkanValidationPrintUniqueOnly;
    }
}

using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x84BFCAE2724A096F, NameHash = 0xD42BEC5C)]
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
        [NMS(Index = 103)]
        /* 0x010 */ public int FrameFlipRateDefault;
        [NMS(Index = 105)]
        /* 0x014 */ public int FrameFlipRateGame;
        [NMS(Index = 104)]
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
        [NMS(Index = 99)]
        /* 0x028 */ public int HmdEyeBufferHeight;
        [NMS(Index = 98)]
        /* 0x02C */ public int HmdEyeBufferWidth;
        [NMS(Index = 100)]
        /* 0x030 */ public float HmdEyeScalePos;
        [NMS(Index = 101)]
        /* 0x034 */ public float HmdHeadScalePos;
        [NMS(Index = 102)]
        /* 0x038 */ public float HmdImmersionFactor;
        [NMS(Index = 97)]
        /* 0x03C */ public int HmdMonitor;
        [NMS(Index = 93)]
        /* 0x040 */ public int HmdPreviewScale;
        [NMS(Index = 92)]
        /* 0x044 */ public int HmdVRSRateOverride;
        [NMS(Index = 77)]
        /* 0x048 */ public float ImposterTextureDensity;
        [NMS(Index = 9)]
        /* 0x04C */ public int LoadBalanceTimeoutMS;
        [NMS(Index = 26)]
        /* 0x050 */ public int LODOverride;
        [NMS(Index = 106)]
        /* 0x054 */ public float MaxFrameRate;
        [NMS(Index = 57)]
        /* 0x058 */ public int Monitor;
        [NMS(Index = 75)]
        /* 0x05C */ public int OctahedralImpostersViewCount;
        [NMS(Index = 11)]
        /* 0x060 */ public int PSVR2LoadBalanceTimeoutMS;
        [NMS(Index = 113)]
        /* 0x064 */ public float ScratchpadInstanceScale;
        [NMS(Index = 115)]
        /* 0x068 */ public int ScratchpadInstancesCap;
        [NMS(Index = 112)]
        /* 0x06C */ public float ScratchpadInstanceSpacing;
        [NMS(Index = 114)]
        /* 0x070 */ public int ScratchpadInstancesPerSide;
        [NMS(Index = 116)]
        /* 0x074 */ public float ScratchpadInstancesRandomness;
        [NMS(Index = 109)]
        /* 0x078 */ public int ScratchpadModelSeed;
        [NMS(Index = 54)]
        /* 0x07C */ public int ScreenHeight;
        [NMS(Index = 53)]
        /* 0x080 */ public int ScreenWidth;
        [NMS(Index = 60)]
        /* 0x084 */ public int TiledWindowsIndex;
        [NMS(Index = 59)]
        /* 0x088 */ public int TiledWindowsSplitCount;
        [NMS(Index = 13)]
        /* 0x08C */ public float TitlebarMenuOffset;
        [NMS(Index = 21)]
        /* 0x090 */ public float TouchScreenSwipeTime;
        [NMS(Index = 20)]
        /* 0x094 */ public float TouchScreenSwipeTravelThreshold;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        [NMS(Index = 89)]
        /* 0x098 */ public TrialStatusEnum TrialStatus;
        [NMS(Index = 83)]
        /* 0x09C */ public float UpdatePeriod;
        [NMS(Index = 84)]
        /* 0x0A0 */ public float UpdatePeriodSteam;
        [NMS(Index = 85)]
        /* 0x0A4 */ public float VoiceUpdatePeriod;
        [NMS(Index = 86)]
        /* 0x0A8 */ public float VoiceUpdatePeriodSteam;
        [NMS(Index = 10)]
        /* 0x0AC */ public int VRLoadBalanceTimeoutMS;
        [NMS(Index = 50)]
        /* 0x0B0 */ public int WindowPositionX;
        [NMS(Index = 51)]
        /* 0x0B4 */ public int WindowPositionY;
        [NMS(Index = 44)]
        /* 0x0B8 */ public float WwiseVibrationMultiplierPrimary;
        [NMS(Index = 45)]
        /* 0x0BC */ public float WwiseVibrationMultiplierSecondary;
        [NMS(Index = 66)]
        /* 0x0C0 */ public NMSString0x100 EditorLayout;
        [NMS(Index = 6)]
        /* 0x1C0 */ public NMSString0x100 ExcludeLogFilter;
        [NMS(Index = 5)]
        /* 0x2C0 */ public NMSString0x100 IncludeLogFilter;
        [NMS(Index = 108)]
        /* 0x3C0 */ public NMSString0x100 ScratchpadModel;
        [NMS(Index = 58)]
        /* 0x4C0 */ public NMSString0x100 SimulateIOSDevice;
        [NMS(Index = 87)]
        /* 0x5C0 */ public NMSString0x20 OverrideUsernameForDev;
        [NMS(Index = 79)]
        /* 0x5E0 */ public bool AllowBindlessDraws;
        [NMS(Index = 40)]
        /* 0x5E1 */ public bool AllowDynamicRenderingOnVulkan;
        [NMS(Index = 25)]
        /* 0x5E2 */ public bool AllowDynamicResScaling;
        [NMS(Index = 12)]
        /* 0x5E3 */ public bool AllowInPlaceNGuiElementRenaming;
        [NMS(Index = 39)]
        /* 0x5E4 */ public bool AllowMultiThreadedRenderingOnVulkan;
        [NMS(Index = 1)]
        /* 0x5E5 */ public bool AssertsPopupAlwaysOnTop;
        [NMS(Index = 15)]
        /* 0x5E6 */ public bool AutoTabNewlyOpenedWindows;
        [NMS(Index = 27)]
        /* 0x5E7 */ public bool ColourLODs;
        [NMS(Index = 28)]
        /* 0x5E8 */ public bool ColourVertexDensity;
        [NMS(Index = 76)]
        /* 0x5E9 */ public bool CompressImposterTextures;
        [NMS(Index = 41)]
        /* 0x5EA */ public bool CrashOnFailedCriticalAssertion;
        [NMS(Index = 2)]
        /* 0x5EB */ public bool DefaultSelectIgnoreAsserts;
        [NMS(Index = 3)]
        /* 0x5EC */ public bool DisableAssertUpload;
        [NMS(Index = 35)]
        /* 0x5ED */ public bool DisableImposters;
        [NMS(Index = 48)]
        /* 0x5EE */ public bool DisableMultiplayer;
        [NMS(Index = 24)]
        /* 0x5EF */ public bool DisableResScaling;
        [NMS(Index = 22)]
        /* 0x5F0 */ public bool DisableSwitchingAwayFromPad;
        [NMS(Index = 78)]
        /* 0x5F1 */ public bool DisableUndergrowthInstanceRendering;
        [NMS(Index = 55)]
        /* 0x5F2 */ public bool DisableVSync;
        [NMS(Index = 72)]
        /* 0x5F3 */ public bool EnableGpuBreadcrumbs;
        [NMS(Index = 71)]
        /* 0x5F4 */ public bool EnableNvidiaAftermath;
        [NMS(Index = 69)]
        /* 0x5F5 */ public bool EnablePix;
        [NMS(Index = 73)]
        /* 0x5F6 */ public bool EnableRayTracing;
        [NMS(Index = 68)]
        /* 0x5F7 */ public bool EnableRenderdoc;
        [NMS(Index = 23)]
        /* 0x5F8 */ public bool EnableShaderReload;
        [NMS(Index = 38)]
        /* 0x5F9 */ public bool EnableSSS;
        [NMS(Index = 19)]
        /* 0x5FA */ public bool EnableVirtualTouchScreen;
        [NMS(Index = 7)]
        /* 0x5FB */ public bool EnableZstdSaves;
        [NMS(Index = 16)]
        /* 0x5FC */ public bool FavouritesAndUndoEnabledByDefault;
        [NMS(Index = 14)]
        /* 0x5FD */ public bool FilterTranslatedTextWhenSearching;
        [NMS(Index = 31)]
        /* 0x5FE */ public bool ForceGPUPreset;
        [NMS(Index = 63)]
        /* 0x5FF */ public bool ForceRunAllHavokWorldsMultiThreaded;
        [NMS(Index = 42)]
        /* 0x600 */ public bool ForceSteamDeck;
        [NMS(Index = 43)]
        /* 0x601 */ public bool ForceWinGdkHandheld;
        [NMS(Index = 107)]
        /* 0x602 */ public bool FrameRateSpikeTestEnabled;
        [NMS(Index = 34)]
        /* 0x603 */ public bool FreezeCulling;
        [NMS(Index = 70)]
        /* 0x604 */ public bool HideRenderdocOverlay;
        [NMS(Index = 96)]
        /* 0x605 */ public bool HmdDistortionPassthru;
        [NMS(Index = 90)]
        /* 0x606 */ public bool HmdEnable;
        [NMS(Index = 91)]
        /* 0x607 */ public bool HmdFoveated;
        [NMS(Index = 95)]
        /* 0x608 */ public bool HmdStereoRender;
        [NMS(Index = 94)]
        /* 0x609 */ public bool HmdTracking;
        [NMS(Index = 37)]
        /* 0x60A */ public bool JitterRenderOffsetEveryFrame;
        [NMS(Index = 67)]
        /* 0x60B */ public bool LoadRelativeEditorLayouts;
        [NMS(Index = 18)]
        /* 0x60C */ public bool LogInputChanges;
        [NMS(Index = 17)]
        /* 0x60D */ public bool LogInputSetup;
        [NMS(Index = 33)]
        /* 0x60E */ public bool MakeUnusedUniformsNaN;
        [NMS(Index = 30)]
        /* 0x60F */ public bool MinGPUMode;
        [NMS(Index = 74)]
        /* 0x610 */ public bool OctahedralImpostersViewFromSpace;
        [NMS(Index = 61)]
        /* 0x611 */ public bool RunAllHavokWorldsSingleThreaded;
        [NMS(Index = 62)]
        /* 0x612 */ public bool RunOnlyHavokSubworldsSingleThreaded;
        [NMS(Index = 64)]
        /* 0x613 */ public bool SampleCollisionWithCamera;
        [NMS(Index = 110)]
        /* 0x614 */ public bool ScratchpadInstanced;
        [NMS(Index = 111)]
        /* 0x615 */ public bool ScratchpadWind;
        [NMS(Index = 65)]
        /* 0x616 */ public bool ShowPlayerCollisions;
        [NMS(Index = 47)]
        /* 0x617 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 49)]
        /* 0x618 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 52)]
        /* 0x619 */ public bool UseDebugScreenSettings;
        [NMS(Index = 46)]
        /* 0x61A */ public bool UseHeavyAir;
        [NMS(Index = 88)]
        /* 0x61B */ public bool UseOverrideUsernameForSavePath;
        [NMS(Index = 80)]
        /* 0x61C */ public bool VulkanValidationEnabled;
        [NMS(Index = 81)]
        /* 0x61D */ public bool VulkanValidationPrintMessages;
        [NMS(Index = 82)]
        /* 0x61E */ public bool VulkanValidationPrintUniqueOnly;
    }
}

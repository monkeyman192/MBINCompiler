using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x156B9E44297B0E4A, NameHash = 0xD42BEC5C)]
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
        [NMS(Index = 2)]
        /* 0x004 */ public EnabledChannelsEnum EnabledChannels;
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
        [NMS(Index = 26)]
        /* 0x008 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        [NMS(Index = 76)]
        /* 0x00C */ public int FrameFlipRateDefault;
        [NMS(Index = 78)]
        /* 0x010 */ public int FrameFlipRateGame;
        [NMS(Index = 77)]
        /* 0x014 */ public int FrameFlipRateLoad;
        // size: 0x5
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
            Maximised,
            Minimised,
        }
        [NMS(Index = 41)]
        /* 0x018 */ public GameWindowModeEnum GameWindowMode;
        [NMS(Index = 23)]
        /* 0x01C */ public int HighlightPlacementIndex;
        [NMS(Index = 72)]
        /* 0x020 */ public int HmdEyeBufferHeight;
        [NMS(Index = 71)]
        /* 0x024 */ public int HmdEyeBufferWidth;
        [NMS(Index = 73)]
        /* 0x028 */ public float HmdEyeScalePos;
        [NMS(Index = 74)]
        /* 0x02C */ public float HmdHeadScalePos;
        [NMS(Index = 75)]
        /* 0x030 */ public float HmdImmersionFactor;
        [NMS(Index = 70)]
        /* 0x034 */ public int HmdMonitor;
        [NMS(Index = 66)]
        /* 0x038 */ public int HmdPreviewScale;
        [NMS(Index = 5)]
        /* 0x03C */ public int LoadBalanceTimeoutMS;
        [NMS(Index = 20)]
        /* 0x040 */ public int LODOverride;
        [NMS(Index = 79)]
        /* 0x044 */ public float MaxFrameRate;
        [NMS(Index = 42)]
        /* 0x048 */ public int Monitor;
        [NMS(Index = 57)]
        /* 0x04C */ public int OctahedralImpostersViewCount;
        [NMS(Index = 7)]
        /* 0x050 */ public int PSVR2LoadBalanceTimeoutMS;
        [NMS(Index = 85)]
        /* 0x054 */ public float ScratchpadInstanceScale;
        [NMS(Index = 87)]
        /* 0x058 */ public int ScratchpadInstancesCap;
        [NMS(Index = 84)]
        /* 0x05C */ public float ScratchpadInstanceSpacing;
        [NMS(Index = 86)]
        /* 0x060 */ public int ScratchpadInstancesPerSide;
        [NMS(Index = 88)]
        /* 0x064 */ public float ScratchpadInstancesRandomness;
        [NMS(Index = 81)]
        /* 0x068 */ public int ScratchpadModelSeed;
        [NMS(Index = 39)]
        /* 0x06C */ public int ScreenHeight;
        [NMS(Index = 38)]
        /* 0x070 */ public int ScreenWidth;
        [NMS(Index = 44)]
        /* 0x074 */ public int TiledWindowsIndex;
        [NMS(Index = 43)]
        /* 0x078 */ public int TiledWindowsSplitCount;
        [NMS(Index = 9)]
        /* 0x07C */ public float TitlebarMenuOffset;
        [NMS(Index = 16)]
        /* 0x080 */ public float TouchScreenSwipeTime;
        [NMS(Index = 15)]
        /* 0x084 */ public float TouchScreenSwipeTravelThreshold;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        [NMS(Index = 63)]
        /* 0x088 */ public TrialStatusEnum TrialStatus;
        [NMS(Index = 59)]
        /* 0x08C */ public float UpdatePeriod;
        [NMS(Index = 60)]
        /* 0x090 */ public float UpdatePeriodSteam;
        [NMS(Index = 61)]
        /* 0x094 */ public float VoiceUpdatePeriod;
        [NMS(Index = 62)]
        /* 0x098 */ public float VoiceUpdatePeriodSteam;
        [NMS(Index = 6)]
        /* 0x09C */ public int VRLoadBalanceTimeoutMS;
        [NMS(Index = 35)]
        /* 0x0A0 */ public int WindowPositionX;
        [NMS(Index = 36)]
        /* 0x0A4 */ public int WindowPositionY;
        [NMS(Index = 29)]
        /* 0x0A8 */ public float WwiseVibrationMultiplierPrimary;
        [NMS(Index = 30)]
        /* 0x0AC */ public float WwiseVibrationMultiplierSecondary;
        [NMS(Index = 48)]
        /* 0x0B0 */ public NMSString0x100 EditorLayout;
        [NMS(Index = 4)]
        /* 0x1B0 */ public NMSString0x100 ExcludeLogFilter;
        [NMS(Index = 3)]
        /* 0x2B0 */ public NMSString0x100 IncludeLogFilter;
        [NMS(Index = 80)]
        /* 0x3B0 */ public NMSString0x100 ScratchpadModel;
        [NMS(Index = 8)]
        /* 0x4B0 */ public bool AllowInPlaceNGuiElementRenaming;
        [NMS(Index = 11)]
        /* 0x4B1 */ public bool AutoTabNewlyOpenedWindows;
        [NMS(Index = 21)]
        /* 0x4B2 */ public bool ColourLODs;
        [NMS(Index = 22)]
        /* 0x4B3 */ public bool ColourVertexDensity;
        [NMS(Index = 58)]
        /* 0x4B4 */ public bool CompressImposterTextures;
        [NMS(Index = 1)]
        /* 0x4B5 */ public bool DefaultSelectIgnoreAsserts;
        [NMS(Index = 33)]
        /* 0x4B6 */ public bool DisableMultiplayer;
        [NMS(Index = 19)]
        /* 0x4B7 */ public bool DisableResScaling;
        [NMS(Index = 17)]
        /* 0x4B8 */ public bool DisableSwitchingAwayFromPad;
        [NMS(Index = 40)]
        /* 0x4B9 */ public bool DisableVSync;
        [NMS(Index = 53)]
        /* 0x4BA */ public bool EnableInstancedModelImposters;
        [NMS(Index = 52)]
        /* 0x4BB */ public bool EnableNvidiaAftermath;
        [NMS(Index = 50)]
        /* 0x4BC */ public bool EnableRenderdoc;
        [NMS(Index = 18)]
        /* 0x4BD */ public bool EnableShaderReload;
        [NMS(Index = 14)]
        /* 0x4BE */ public bool EnableVirtualTouchScreen;
        [NMS(Index = 10)]
        /* 0x4BF */ public bool FilterTranslatedTextWhenSearching;
        [NMS(Index = 25)]
        /* 0x4C0 */ public bool ForceGPUPreset;
        [NMS(Index = 28)]
        /* 0x4C1 */ public bool FreezeCulling;
        [NMS(Index = 51)]
        /* 0x4C2 */ public bool HideRenderdocOverlay;
        [NMS(Index = 69)]
        /* 0x4C3 */ public bool HmdDistortionPassthru;
        [NMS(Index = 64)]
        /* 0x4C4 */ public bool HmdEnable;
        [NMS(Index = 65)]
        /* 0x4C5 */ public bool HmdFoveated;
        [NMS(Index = 68)]
        /* 0x4C6 */ public bool HmdStereoRender;
        [NMS(Index = 67)]
        /* 0x4C7 */ public bool HmdTracking;
        [NMS(Index = 49)]
        /* 0x4C8 */ public bool LoadRelativeEditorLayouts;
        [NMS(Index = 13)]
        /* 0x4C9 */ public bool LogInputChanges;
        [NMS(Index = 12)]
        /* 0x4CA */ public bool LogInputSetup;
        [NMS(Index = 27)]
        /* 0x4CB */ public bool MakeUnusedUniformsNaN;
        [NMS(Index = 24)]
        /* 0x4CC */ public bool MinGPUMode;
        [NMS(Index = 55)]
        /* 0x4CD */ public bool OctahedralImpostersDisable;
        [NMS(Index = 54)]
        /* 0x4CE */ public bool OctahedralImpostersEnable;
        [NMS(Index = 56)]
        /* 0x4CF */ public bool OctahedralImpostersViewFromSpace;
        [NMS(Index = 45)]
        /* 0x4D0 */ public bool SampleCollisionWithCamera;
        [NMS(Index = 82)]
        /* 0x4D1 */ public bool ScratchpadInstanced;
        [NMS(Index = 83)]
        /* 0x4D2 */ public bool ScratchpadWind;
        [NMS(Index = 46)]
        /* 0x4D3 */ public bool ShowPlayerCollisions;
        [NMS(Index = 32)]
        /* 0x4D4 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 34)]
        /* 0x4D5 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 47)]
        /* 0x4D6 */ public bool SupportWaterHeightQueries;
        [NMS(Index = 37)]
        /* 0x4D7 */ public bool UseDebugScreenSettings;
        [NMS(Index = 31)]
        /* 0x4D8 */ public bool UseHeavyAir;
    }
}

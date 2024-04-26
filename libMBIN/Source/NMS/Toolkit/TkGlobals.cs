using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEB7C9677BE54349F, NameHash = 0xB62E6456DFE47836)]
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
        [NMS(Index = 15)]
        /* 0x008 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        [NMS(Index = 49)]
        /* 0x00C */ public int FrameFlipRateDefault;
        [NMS(Index = 51)]
        /* 0x010 */ public int FrameFlipRateGame;
        [NMS(Index = 50)]
        /* 0x014 */ public int FrameFlipRateLoad;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        [NMS(Index = 26)]
        /* 0x018 */ public GameWindowModeEnum GameWindowMode;
        [NMS(Index = 45)]
        /* 0x01C */ public int HmdEyeBufferHeight;
        [NMS(Index = 44)]
        /* 0x020 */ public int HmdEyeBufferWidth;
        [NMS(Index = 46)]
        /* 0x024 */ public float HmdEyeScalePos;
        [NMS(Index = 47)]
        /* 0x028 */ public float HmdHeadScalePos;
        [NMS(Index = 48)]
        /* 0x02C */ public float HmdImmersionFactor;
        [NMS(Index = 43)]
        /* 0x030 */ public int HmdMonitor;
        [NMS(Index = 39)]
        /* 0x034 */ public int HmdPreviewScale;
        [NMS(Index = 5)]
        /* 0x038 */ public int LoadBalanceTimeoutMS;
        [NMS(Index = 11)]
        /* 0x03C */ public int LODOverride;
        [NMS(Index = 52)]
        /* 0x040 */ public float MaxFrameRate;
        [NMS(Index = 27)]
        /* 0x044 */ public int Monitor;
        [NMS(Index = 7)]
        /* 0x048 */ public int PSVR2LoadBalanceTimeoutMS;
        [NMS(Index = 24)]
        /* 0x04C */ public int ScreenHeight;
        [NMS(Index = 23)]
        /* 0x050 */ public int ScreenWidth;
        [NMS(Index = 29)]
        /* 0x054 */ public int TiledWindowsIndex;
        [NMS(Index = 28)]
        /* 0x058 */ public int TiledWindowsSplitCount;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        [NMS(Index = 36)]
        /* 0x05C */ public TrialStatusEnum TrialStatus;
        [NMS(Index = 32)]
        /* 0x060 */ public float UpdatePeriod;
        [NMS(Index = 33)]
        /* 0x064 */ public float UpdatePeriodSteam;
        [NMS(Index = 34)]
        /* 0x068 */ public float VoiceUpdatePeriod;
        [NMS(Index = 35)]
        /* 0x06C */ public float VoiceUpdatePeriodSteam;
        [NMS(Index = 6)]
        /* 0x070 */ public int VRLoadBalanceTimeoutMS;
        [NMS(Index = 16)]
        /* 0x074 */ public float WwiseVibrationMultiplierPrimary;
        [NMS(Index = 17)]
        /* 0x078 */ public float WwiseVibrationMultiplierSecondary;
        [NMS(Index = 4)]
        /* 0x07C */ public NMSString0x100 ExcludeLogFilter;
        [NMS(Index = 3)]
        /* 0x17C */ public NMSString0x100 IncludeLogFilter;
        [NMS(Index = 12)]
        /* 0x27C */ public bool ColourLODs;
        [NMS(Index = 1)]
        /* 0x27D */ public bool DefaultSelectIgnoreAsserts;
        [NMS(Index = 20)]
        /* 0x27E */ public bool DisableMultiplayer;
        [NMS(Index = 10)]
        /* 0x27F */ public bool DisableResScaling;
        [NMS(Index = 25)]
        /* 0x280 */ public bool DisableVSync;
        [NMS(Index = 14)]
        /* 0x281 */ public bool ForceGPUPreset;
        [NMS(Index = 42)]
        /* 0x282 */ public bool HmdDistortionPassthru;
        [NMS(Index = 37)]
        /* 0x283 */ public bool HmdEnable;
        [NMS(Index = 38)]
        /* 0x284 */ public bool HmdFoveated;
        [NMS(Index = 41)]
        /* 0x285 */ public bool HmdStereoRender;
        [NMS(Index = 40)]
        /* 0x286 */ public bool HmdTracking;
        [NMS(Index = 9)]
        /* 0x287 */ public bool LogInputChanges;
        [NMS(Index = 8)]
        /* 0x288 */ public bool LogInputSetup;
        [NMS(Index = 13)]
        /* 0x289 */ public bool MinGPUMode;
        [NMS(Index = 30)]
        /* 0x28A */ public bool SampleCollisionWithCamera;
        [NMS(Index = 31)]
        /* 0x28B */ public bool ShowPlayerCollisions;
        [NMS(Index = 19)]
        /* 0x28C */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 21)]
        /* 0x28D */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 22)]
        /* 0x28E */ public bool UseDebugScreenSettings;
        [NMS(Index = 18)]
        /* 0x28F */ public bool UseHeavyAir;
    }
}

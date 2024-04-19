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
        /* 0x008 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        /* 0x00C */ public int FrameFlipRateDefault;
        /* 0x010 */ public int FrameFlipRateGame;
        /* 0x014 */ public int FrameFlipRateLoad;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        /* 0x018 */ public GameWindowModeEnum GameWindowMode;
        /* 0x01C */ public int HmdEyeBufferHeight;
        /* 0x020 */ public int HmdEyeBufferWidth;
        /* 0x024 */ public float HmdEyeScalePos;
        /* 0x028 */ public float HmdHeadScalePos;
        /* 0x02C */ public float HmdImmersionFactor;
        /* 0x030 */ public int HmdMonitor;
        /* 0x034 */ public int HmdPreviewScale;
        /* 0x038 */ public int LoadBalanceTimeoutMS;
        /* 0x03C */ public int LODOverride;
        /* 0x040 */ public float MaxFrameRate;
        /* 0x044 */ public int Monitor;
        /* 0x048 */ public int PSVR2LoadBalanceTimeoutMS;
        /* 0x04C */ public int ScreenHeight;
        /* 0x050 */ public int ScreenWidth;
        /* 0x054 */ public int TiledWindowsIndex;
        /* 0x058 */ public int TiledWindowsSplitCount;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        /* 0x05C */ public TrialStatusEnum TrialStatus;
        /* 0x060 */ public float UpdatePeriod;
        /* 0x064 */ public float UpdatePeriodSteam;
        /* 0x068 */ public float VoiceUpdatePeriod;
        /* 0x06C */ public float VoiceUpdatePeriodSteam;
        /* 0x070 */ public int VRLoadBalanceTimeoutMS;
        /* 0x074 */ public float WwiseVibrationMultiplierPrimary;
        /* 0x078 */ public float WwiseVibrationMultiplierSecondary;
        /* 0x07C */ public NMSString0x100 ExcludeLogFilter;
        /* 0x17C */ public NMSString0x100 IncludeLogFilter;
        /* 0x27C */ public bool ColourLODs;
        /* 0x27D */ public bool DefaultSelectIgnoreAsserts;
        /* 0x27E */ public bool DisableMultiplayer;
        /* 0x27F */ public bool DisableResScaling;
        /* 0x280 */ public bool DisableVSync;
        /* 0x281 */ public bool ForceGPUPreset;
        /* 0x282 */ public bool HmdDistortionPassthru;
        /* 0x283 */ public bool HmdEnable;
        /* 0x284 */ public bool HmdFoveated;
        /* 0x285 */ public bool HmdStereoRender;
        /* 0x286 */ public bool HmdTracking;
        /* 0x287 */ public bool LogInputChanges;
        /* 0x288 */ public bool LogInputSetup;
        /* 0x289 */ public bool MinGPUMode;
        /* 0x28A */ public bool SampleCollisionWithCamera;
        /* 0x28B */ public bool ShowPlayerCollisions;
        /* 0x28C */ public bool SimulateDisabledParticleRefractions;
        /* 0x28D */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x28E */ public bool UseDebugScreenSettings;
        /* 0x28F */ public bool UseHeavyAir;
    }
}

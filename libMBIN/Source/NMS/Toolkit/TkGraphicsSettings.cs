using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4DA3AF739FE447F4, NameHash = 0x8DDF831D46F0A7E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x000 */ public List<NMSString0x100> MonitorNames;
        /* 0x010 */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x064 */ public int AdapterIndex;
        /* 0x068 */ public int Brightness;
        /* 0x06C */ public float FoVInShip;
        /* 0x070 */ public float FoVOnFoot;
        // size: 0x4
        public enum HDRModeEnum : uint {
            Off,
            HDR400,
            HDR600,
            HDR1000,
        }
        /* 0x074 */ public HDRModeEnum HDRMode;
        /* 0x078 */ public int MaxframeRate;
        /* 0x07C */ public int Monitor;
        /* 0x080 */ public float MotionBlurStrength;
        /* 0x084 */ public float MouseClickSpeedMultiplier;
        /* 0x088 */ public int NumGraphicsThreadsBeta;
        /* 0x08C */ public int NumHighThreads;
        /* 0x090 */ public int NumLowThreads;
        /* 0x094 */ public int ResolutionHeight;
        /* 0x098 */ public float ResolutionScale;
        /* 0x09C */ public int ResolutionWidth;
        // size: 0x4
        public enum TextureStreamingVkEnum : uint {
            Off,
            On,
            Auto,
            NonDynamic,
        }
        /* 0x0A0 */ public TextureStreamingVkEnum TextureStreamingVk;
        /* 0x0A4 */ public int Version;
        // size: 0x4
        public enum VsyncExEnum : uint {
            Off,
            On,
            Adaptive,
            Triple,
        }
        /* 0x0A8 */ public VsyncExEnum VsyncEx;
        /* 0x0AC */ public NMSString0x100 AdapterName;
        /* 0x1AC */ public bool Borderless;
        /* 0x1AD */ public bool FullScreen;
        /* 0x1AE */ public bool RemoveBaseBuildingRestrictions;
        /* 0x1AF */ public bool ShowRequirementsWarnings;
        /* 0x1B0 */ public bool UseArbSparseTexture;
        /* 0x1B1 */ public bool UseTerrainTextureCache;
        /* 0x1B2 */ public bool VignetteAndScanlines;
    }
}

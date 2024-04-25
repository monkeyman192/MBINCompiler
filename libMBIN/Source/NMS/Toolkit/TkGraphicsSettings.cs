using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4DA3AF739FE447F4, NameHash = 0x8DDF831D46F0A7E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public List<NMSString0x100> MonitorNames;
        [NMS(Index = 9)]
        /* 0x010 */ public TkGraphicsDetailPreset GraphicsDetail;
        [NMS(Index = 26)]
        /* 0x064 */ public int AdapterIndex;
        [NMS(Index = 14)]
        /* 0x068 */ public int Brightness;
        [NMS(Index = 13)]
        /* 0x06C */ public float FoVInShip;
        [NMS(Index = 12)]
        /* 0x070 */ public float FoVOnFoot;
        // size: 0x4
        public enum HDRModeEnum : uint {
            Off,
            HDR400,
            HDR600,
            HDR1000,
        }
        [NMS(Index = 24)]
        /* 0x074 */ public HDRModeEnum HDRMode;
        [NMS(Index = 15)]
        /* 0x078 */ public int MaxframeRate;
        [NMS(Index = 3)]
        /* 0x07C */ public int Monitor;
        [NMS(Index = 10)]
        /* 0x080 */ public float MotionBlurStrength;
        [NMS(Index = 21)]
        /* 0x084 */ public float MouseClickSpeedMultiplier;
        [NMS(Index = 27)]
        /* 0x088 */ public int NumGraphicsThreadsBeta;
        [NMS(Index = 16)]
        /* 0x08C */ public int NumHighThreads;
        [NMS(Index = 17)]
        /* 0x090 */ public int NumLowThreads;
        [NMS(Index = 6)]
        /* 0x094 */ public int ResolutionHeight;
        [NMS(Index = 7)]
        /* 0x098 */ public float ResolutionScale;
        [NMS(Index = 5)]
        /* 0x09C */ public int ResolutionWidth;
        // size: 0x4
        public enum TextureStreamingVkEnum : uint {
            Off,
            On,
            Auto,
            NonDynamic,
        }
        [NMS(Index = 18)]
        /* 0x0A0 */ public TextureStreamingVkEnum TextureStreamingVk;
        [NMS(Index = 0)]
        /* 0x0A4 */ public int Version;
        // size: 0x4
        public enum VsyncExEnum : uint {
            Off,
            On,
            Adaptive,
            Triple,
        }
        [NMS(Index = 8)]
        /* 0x0A8 */ public VsyncExEnum VsyncEx;
        [NMS(Index = 25)]
        /* 0x0AC */ public NMSString0x100 AdapterName;
        [NMS(Index = 2)]
        /* 0x1AC */ public bool Borderless;
        [NMS(Index = 1)]
        /* 0x1AD */ public bool FullScreen;
        [NMS(Index = 20)]
        /* 0x1AE */ public bool RemoveBaseBuildingRestrictions;
        [NMS(Index = 19)]
        /* 0x1AF */ public bool ShowRequirementsWarnings;
        [NMS(Index = 23)]
        /* 0x1B0 */ public bool UseArbSparseTexture;
        [NMS(Index = 22)]
        /* 0x1B1 */ public bool UseTerrainTextureCache;
        [NMS(Index = 11)]
        /* 0x1B2 */ public bool VignetteAndScanlines;
    }
}

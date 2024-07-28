using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x56D4DCB09E6DB9E7, NameHash = 0xCCF3675E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public List<NMSString0x100> MonitorNames;
        [NMS(Index = 10)]
        /* 0x010 */ public TkGraphicsDetailPreset GraphicsDetail;
        [NMS(Index = 27)]
        /* 0x074 */ public int AdapterIndex;
        [NMS(Index = 15)]
        /* 0x078 */ public int Brightness;
        [NMS(Index = 14)]
        /* 0x07C */ public float FoVInShip;
        [NMS(Index = 13)]
        /* 0x080 */ public float FoVOnFoot;
        // size: 0x4
        public enum HDRModeEnum : uint {
            Off,
            HDR400,
            HDR600,
            HDR1000,
        }
        [NMS(Index = 25)]
        /* 0x084 */ public HDRModeEnum HDRMode;
        [NMS(Index = 16)]
        /* 0x088 */ public int MaxframeRate;
        [NMS(Index = 3)]
        /* 0x08C */ public int Monitor;
        [NMS(Index = 11)]
        /* 0x090 */ public float MotionBlurStrength;
        [NMS(Index = 22)]
        /* 0x094 */ public float MouseClickSpeedMultiplier;
        [NMS(Index = 28)]
        /* 0x098 */ public int NumGraphicsThreadsBeta;
        [NMS(Index = 17)]
        /* 0x09C */ public int NumHighThreads;
        [NMS(Index = 18)]
        /* 0x0A0 */ public int NumLowThreads;
        [NMS(Index = 6)]
        /* 0x0A4 */ public int ResolutionHeight;
        [NMS(Index = 7)]
        /* 0x0A8 */ public float ResolutionScale;
        [NMS(Index = 5)]
        /* 0x0AC */ public int ResolutionWidth;
        [NMS(Index = 8)]
        /* 0x0B0 */ public float RetinaScaleIOS;
        // size: 0x4
        public enum TextureStreamingVkEnum : uint {
            Off,
            On,
            Auto,
            NonDynamic,
        }
        [NMS(Index = 19)]
        /* 0x0B4 */ public TextureStreamingVkEnum TextureStreamingVk;
        [NMS(Index = 0)]
        /* 0x0B8 */ public int Version;
        // size: 0x4
        public enum VsyncExEnum : uint {
            Off,
            On,
            Adaptive,
            Triple,
        }
        [NMS(Index = 9)]
        /* 0x0BC */ public VsyncExEnum VsyncEx;
        [NMS(Index = 26)]
        /* 0x0C0 */ public NMSString0x100 AdapterName;
        [NMS(Index = 2)]
        /* 0x1C0 */ public bool Borderless;
        [NMS(Index = 1)]
        /* 0x1C1 */ public bool FullScreen;
        [NMS(Index = 21)]
        /* 0x1C2 */ public bool RemoveBaseBuildingRestrictions;
        [NMS(Index = 20)]
        /* 0x1C3 */ public bool ShowRequirementsWarnings;
        [NMS(Index = 24)]
        /* 0x1C4 */ public bool UseArbSparseTexture;
        [NMS(Index = 23)]
        /* 0x1C5 */ public bool UseTerrainTextureCache;
        [NMS(Index = 12)]
        /* 0x1C6 */ public bool VignetteAndScanlines;
    }
}

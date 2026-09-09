using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1FC9185DDFD5EBC0, NameHash = 0xCCF3675E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public List<NMSString0x100> MonitorNames;
        [NMS(Index = 10)]
        /* 0x010 */ public TkGraphicsDetailPreset GraphicsDetail;
        [NMS(Index = 29)]
        /* 0x0A4 */ public int AdapterIndex;
        [NMS(Index = 17)]
        /* 0x0A8 */ public int Brightness;
        [NMS(Index = 14)]
        /* 0x0AC */ public float FoVInShip;
        [NMS(Index = 16)]
        /* 0x0B0 */ public float FoVInShipFP;
        [NMS(Index = 13)]
        /* 0x0B4 */ public float FoVOnFoot;
        [NMS(Index = 15)]
        /* 0x0B8 */ public float FoVOnFootFP;
        // size: 0x4
        public enum HDRModeEnum : uint {
            Off,
            HDR400,
            HDR600,
            HDR1000,
        }
        [NMS(Index = 27)]
        /* 0x0BC */ public HDRModeEnum HDRMode;
        [NMS(Index = 18)]
        /* 0x0C0 */ public int MaxframeRate;
        [NMS(Index = 3)]
        /* 0x0C4 */ public int Monitor;
        [NMS(Index = 11)]
        /* 0x0C8 */ public float MotionBlurStrength;
        [NMS(Index = 24)]
        /* 0x0CC */ public float MouseClickSpeedMultiplier;
        [NMS(Index = 30)]
        /* 0x0D0 */ public int NumGraphicsThreadsBeta;
        [NMS(Index = 19)]
        /* 0x0D4 */ public int NumHighThreads;
        [NMS(Index = 20)]
        /* 0x0D8 */ public int NumLowThreads;
        [NMS(Index = 6)]
        /* 0x0DC */ public int ResolutionHeight;
        [NMS(Index = 7)]
        /* 0x0E0 */ public float ResolutionScale;
        [NMS(Index = 5)]
        /* 0x0E4 */ public int ResolutionWidth;
        [NMS(Index = 8)]
        /* 0x0E8 */ public float RetinaScaleIOS;
        // size: 0x4
        public enum TextureStreamingVkEnum : uint {
            Off,
            On,
            Auto,
            NonDynamic,
        }
        [NMS(Index = 21)]
        /* 0x0EC */ public TextureStreamingVkEnum TextureStreamingVk;
        [NMS(Index = 0)]
        /* 0x0F0 */ public int Version;
        // size: 0x4
        public enum VsyncExEnum : uint {
            Off,
            On,
            Adaptive,
            Triple,
        }
        [NMS(Index = 9)]
        /* 0x0F4 */ public VsyncExEnum VsyncEx;
        [NMS(Index = 28)]
        /* 0x0F8 */ public NMSString0x100 AdapterName;
        [NMS(Index = 2)]
        /* 0x1F8 */ public bool Borderless;
        [NMS(Index = 1)]
        /* 0x1F9 */ public bool FullScreen;
        [NMS(Index = 23)]
        /* 0x1FA */ public bool RemoveBaseBuildingRestrictions;
        [NMS(Index = 22)]
        /* 0x1FB */ public bool ShowRequirementsWarnings;
        [NMS(Index = 26)]
        /* 0x1FC */ public bool UseArbSparseTexture;
        [NMS(Index = 25)]
        /* 0x1FD */ public bool UseTerrainTextureCache;
        [NMS(Index = 12)]
        /* 0x1FE */ public bool VignetteAndScanlines;
    }
}

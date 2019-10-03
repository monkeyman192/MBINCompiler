using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x198, GUID = 0xC636C30874D1207C, NameHash = 0x8DDF831D46F0A7E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
		/* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<NMSString0x100> TkMonitorNames;
        /* 0x20 */ public int ResolutionWidth;
        /* 0x24 */ public int ResolutionHeight;
		public enum VsyncExEnum { Off, On, Adaptive, Triple }
        /* 0x28 */ public VsyncExEnum VsyncEx;
        /* 0x2C */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x58 */ public float MotionBlurStrength;
        /* 0x5C */ public bool VignetteAndScanlines;
        /* 0x60 */ public float FoVOnFoot;
        /* 0x64 */ public float FoVInShip;
        /* 0x68 */ public int Brightness;
        /* 0x6C */ public int MaxframeRate;
		/* 0x70 */ public int NumHighThreads;
		/* 0x74 */ public int NumLowThreads;
		public enum TextureStreamingVkEnum { Off, On, Auto, NonDynamic }
		/* 0x78 */ public TextureStreamingVkEnum TextureStreamingVk;
		/* 0x7C */ public bool ShowRequirementsWarnings;
		/* 0x7D */ public bool RemoveBaseBuildingRestrictions;
        /* 0x80 */ public float MouseClickSpeedMultiplier;
        /* 0x84 */ public bool UseTerrainTextureCache;
        /* 0x85 */ public bool UseArbSparseTexture;
        public enum HDRModeEnum { Off, HDR400, HDR600, HDR1000 }
        /* 0x88 */ public HDRModeEnum HDRMode;
        [NMS(Size = 0x100)]
        /* 0x8C */ public string AdapterName;
        /* 0x18C */ public int AdapterIndex;
        /* 0x190 */ public int NumGraphicsThreadsBeta;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x194 */ public byte[] EndPadding;
    }
}

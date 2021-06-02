using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1A0, GUID = 0x63ED58C9662E5D01, NameHash = 0x8DDF831D46F0A7E)]
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
        /* 0x28 */ public float ResolutionScale;
		public enum VsyncExEnum { Off, On, Adaptive, Triple }
        /* 0x2C */ public VsyncExEnum VsyncEx;
        /* 0x30 */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x64 */ public float MotionBlurStrength;
        /* 0x68 */ public bool VignetteAndScanlines;
        /* 0x6C */ public float FoVOnFoot;
        /* 0x70 */ public float FoVInShip;
        /* 0x74 */ public int Brightness;
        /* 0x78 */ public int MaxframeRate;
		/* 0x7C */ public int NumHighThreads;
		/* 0x80 */ public int NumLowThreads;
		public enum TextureStreamingVkEnum { Off, On, Auto, NonDynamic }
		/* 0x84 */ public TextureStreamingVkEnum TextureStreamingVk;
		/* 0x88 */ public bool ShowRequirementsWarnings;
		/* 0x89 */ public bool RemoveBaseBuildingRestrictions;
        /* 0x8C */ public float MouseClickSpeedMultiplier;
        /* 0x90 */ public bool UseTerrainTextureCache;
        /* 0x91 */ public bool UseArbSparseTexture;
        public enum HDRModeEnum { Off, HDR400, HDR600, HDR1000 }
        /* 0x94 */ public HDRModeEnum HDRMode;
        /* 0x98 */ public NMSString0x100 AdapterName;
        /* 0x198 */ public int AdapterIndex;
        /* 0x19C */ public int NumGraphicsThreadsBeta;
    }
}

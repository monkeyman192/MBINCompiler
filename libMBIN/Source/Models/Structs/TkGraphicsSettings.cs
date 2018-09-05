using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
		/* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public  List<NMSString0x100> TkMonitorNames;
		/* 0x20 */ public bool UseScreenResolution;
        /* 0x24 */ public int ResolutionWidth;
        /* 0x28 */ public int ResolutionHeight;
        /* 0x2C */ public int VSyncEx;
		public string[] VsyncExValues()
		{
			return new string[] { "Off", "On", "Adaptive" };
		}
        /* 0x30 */ public bool GSync;
        /* 0x34 */ public int ShadowDetail;
        public string[] ShadowDetailValues()
        {
            return new string[] { "Low", "Normal", "High", "Ultra" };
        }
        /* 0x38 */ public int TextureDetail;
        public string[] TextureDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x3C */ public int GenerationDetail;
        public string[] GenerationDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x40 */ public int ReflectionsQuality;
        public string[] ReflectionsQualityValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x44 */ public int AntiAliasingEx2;
        public string[] AntiAliasingEX2Values()
        {
            return new string[] { "Auto", "None", "FXAA", "TAA_LOW", "TAA", "TAA_FXAA", "SSAA4" };
        }
		/* 0x48 */ public int MotionBlurQuality;
		public string[] MotionBlueQualityValues()
		{
			return new string[] { "Auto", "Off", "Normal", "High", "Ultra" };
		}
        /* 0x4C */ public int TerrainQualityEx;
		public string[] TerrainQualityExValues()
		{
			return new string[] { "Auto", "Low", "Normal", "High", "Ultra" };
		}
		/* 0x50 */ public float MotionBlurStrength;
        /* 0x54 */ public int AnisotropyLevel;
        /* 0x58 */ public float FoVOnFoot;
        /* 0x5C */ public float FoVInShip;
        /* 0x60 */ public int Brightness;
        /* 0x64 */ public int MaxframeRate;
		/* 0x68 */ public int NumHighThreads;
		/* 0x6C */ public int NumLowThreads;
		/* 0x70 */ public int TextureStreamingEx;
		public string[] TextureStreamingExValues()
		{
			return new string[] { "Off", "On", "Auto", "NonDynamic" };
		}
		/* 0x74 */ public int TexturePageSizeKb;
		/* 0x78 */ public bool ShowRequirementsWarnings;
		/* 0x79 */ public bool RemoveBaseBuildingRestrictions;
		[NMS(Size = 3, Ignore = true)]
		/* 0x7A */ public byte[] Padding7A;
        /* 0x7C */ public float MouseClickSpeedMultiplier;
        /* 0x80 */ public int AmbientOcclusion;
        public string[] AmbientOcclusionValues()
        {
            return new string[] { "SSAO", "HBAO", "Off" };
        }
        /* 0x84 */ public bool UseTerrainTextureCache;
        /* 0x85 */ public bool UseArbSparseTexture;
        /* 0x86 */ public bool EnableTessellation;
        /* 0x87 */ public bool UseHDR;
        /* 0x88 */ public bool UseLightShafts;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x89 */ public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public bool FullScreen;
        /* 0x01 */ public bool Borderless;
        /* 0x04 */ public int Monitor;
        /* 0x08 */ public bool UseScreenResolution;
        /* 0x0C */ public int ResolutionWidth;
        /* 0x10 */ public int ResolutionHeight;
        /* 0x14 */ public bool VSync;
        /* 0x15 */ public bool GSync;
        /* 0x18 */ public int ShadowDetail;
        public string[] ShadowDetailValues()
        {
            return new string[] { "Low", "Normal", "High", "Ultra" };
        }
        /* 0x1C */ public int TextureDetail;
        public string[] TextureDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x20 */ public int GenerationDetail;
        public string[] GenerationDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x24 */ public int ReflectionsQuality;
        public string[] ReflectionsQualityValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x28 */ public int AntiAliasing;
        public string[] AntiAliasingValues()
        {
            return new string[] { "None", "FXAA", "SSAA4" };
        }
        /* 0x2C */ public int AnisotropyLevel;
        /* 0x30 */ public float FoVOnFoot;
        /* 0x34 */ public float FoVInShip;
        /* 0x38 */ public int Brightness;
        /* 0x3C */ public int MaxframeRate;
        /* 0x40 */ public bool NoHudMode;
        [NMS(Size = 3, Ignore = true)]
        /* 0x41 */ public byte[] Padding41;
    }
}

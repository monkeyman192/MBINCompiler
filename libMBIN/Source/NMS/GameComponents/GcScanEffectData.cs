using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, Alignment = 0x10, GUID = 0x14E69D97BE09FE17, NameHash = 0xCB9E3018E759F166)]
    public class GcScanEffectData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
		public enum ScanEffectTypeEnum { Building, TargetShip, Creature, Ground, Objects }
		/* 0x10 */ public ScanEffectTypeEnum ScanEffectType;
		[NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
		/* 0x20 */ public Colour Colour;
		/* 0x30 */ public float BasecolourIntensity;
		/* 0x34 */ public float ScanlinesSeparation;
		/* 0x38 */ public float FresnelIntensity;
		/* 0x3C */ public float GlowIntensity;
        /* 0x40 */ public float WaveOffset;
        /* 0x44 */ public bool WaveActive;
        /* 0x45 */ public bool FixedUpAxis;
        /* 0x46 */ public bool Transparent;
        /* 0x47 */ public bool ModelFade;
		/* 0x48 */ public float FadeInTime;
		/* 0x4C */ public float FadeOutTime;
    }
}

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class GcScanEffectData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
		/* 0x10 */ public int ScanEffectType;
		public string[] ScanEffectTypeValues()
		{
			return new[] { "Building", "TargetShip", "Creature", "Ground", "Objects" };
		}
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
		/* 0x48 */ public float FadeInTime;
		/* 0x4C */ public float FadeOutTime;
    }
}

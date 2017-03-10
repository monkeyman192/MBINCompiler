namespace MBINCompiler.Models.Structs
{
    public class GcScanEffectData : NMSTemplate 
    {
		/* 0x000 */ public int ScanEffectType; // Not sure about calling this an int with the padding... maybe string?
		public string[] ScanEffectTypeValues()
		{
			return new[] { "Building", "TargetShip", "Creature", "Ground", "Objects" };
		}
		[NMS(Size = 6, Ignore = true)]
        public byte[] Padding4;

		/* 0x010 */ public Colour Colour;
		/* 0x020 */ public float BasecolourIntensity;
		/* 0x024 */ public float ScanlinesSeparation;
		/* 0x028 */ public float FresnelIntensity;
		/* 0x02C */ public bool FixedUpAxis;
		/* 0x02D */ public bool Transparent;
		/* 0x030 */ public float FadeInTime;
		/* 0x034 */ public float FadeOutTime;
    }
}

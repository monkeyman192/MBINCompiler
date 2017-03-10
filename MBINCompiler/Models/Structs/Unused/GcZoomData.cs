namespace MBINCompiler.Models.Structs
{
    public class GcZoomData : NMSTemplate 
    {
	  /* 0x000 */ public int ZoomType;
	  public string[] ZoomTypeValues()
        {
            return new[] { "None", "Far", "Mid", "Close" };
        }
		/* 0x004 */ public float EffectStrength;
		/* 0x008 */ public float MoveSpeed;
		/* 0x00C */ public float FoV;
		/* 0x010 */ public float MinScanDistance;
		/* 0x014 */ public float MaxScanDistance;
		/* 0x018 */ public float WalkSpeed;
    }
}

namespace MBINCompiler.Models.Structs
{
    public class GcZoomData : NMSTemplate
    {
        public int ZoomType;
        public string[] ZoomTypeValues()
        {
            return new[] { "None", "Far", "Mid", "Close" };
        }

        /* 0x04 */ public float EffectStrength;
        /* 0x08 */ public float MoveSpeed;
        /* 0x0C */ public float FoV;
        /* 0x10 */ public float MinScanDistance;
        /* 0x14 */ public float MaxScanDistance;
        /* 0x18 */ public float WalkSpeed;
    }
}

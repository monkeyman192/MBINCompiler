namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94899B4FFFB85110, NameHash = 0x2E92A561CA97070C)]
    public class GcZoomData : NMSTemplate
    {
        /* 0x00 */ public float EffectStrength;
        /* 0x04 */ public float FoV;
        /* 0x08 */ public float MaxScanDistance;
        /* 0x0C */ public float MinScanDistance;
        /* 0x10 */ public float MoveSpeed;
        /* 0x14 */ public float WalkSpeed;
        // size: 0x4
        public enum ZoomTypeEnum : uint {
            None,
            Far,
            Mid,
            Close,
        }
        /* 0x18 */ public ZoomTypeEnum ZoomType;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x743D4DDD423DB01A, NameHash = 0x58E44358)]
    public class GcZoomData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float EffectStrength;
        [NMS(Index = 3)]
        /* 0x04 */ public float FoV;
        [NMS(Index = 5)]
        /* 0x08 */ public float MaxScanDistance;
        [NMS(Index = 4)]
        /* 0x0C */ public float MinScanDistance;
        [NMS(Index = 2)]
        /* 0x10 */ public float MoveSpeed;
        [NMS(Index = 6)]
        /* 0x14 */ public float WalkSpeed;
        // size: 0x4
        public enum ZoomTypeEnum : uint {
            None,
            Far,
            Mid,
            Close,
        }
        [NMS(Index = 0)]
        /* 0x18 */ public ZoomTypeEnum ZoomType;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EFE2C30ACD12C39, NameHash = 0xC264A609B1BBACB5)]
    public class GcLookAtComponentData : NMSTemplate
    {
        // size: 0x1
        public enum LookAtTypeEnum : uint {
            Player,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LookAtTypeEnum LookAtType;
        [NMS(Index = 3)]
        /* 0x4 */ public float MinRotationRateDegrees;
        [NMS(Index = 2)]
        /* 0x8 */ public float RotationRateFactor;
        [NMS(Index = 1)]
        /* 0xC */ public NMSString0x20 NodeName;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53145C2A847F1078, NameHash = 0xC264A609B1BBACB5)]
    public class GcLookAtComponentData : NMSTemplate
    {
        // size: 0x1
        public enum LookAtTypeEnum : uint {
            Player,
        }
        /* 0x0 */ public LookAtTypeEnum LookAtType;
        /* 0x4 */ public float MinRotationRateDegrees;
        /* 0x8 */ public float RotationRateFactor;
        /* 0xC */ public NMSString0x20 NodeName;
    }
}

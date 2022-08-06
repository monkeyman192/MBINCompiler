using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA585E45D072429E9, NameHash = 0xC264A609B1BBACB5)]
    public class GcLookAtComponentData : NMSTemplate
    {
        public enum LookAtTypeEnum { Player }
        /* 0x00 */ public LookAtTypeEnum LookAtType;
        /* 0x04 */ public NMSString0x20 NodeName;
        /* 0x24 */ public float RotationRateFactor;
        /* 0x28 */ public float MinRotationRateDegrees;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE1F5D4A78021CAF, NameHash = 0xD8891B897252CDF3)]
    public class GcBehaviourFaceTargetData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TargetKey;
        /* 0x10 */ public float ArriveAngle;
    }
}

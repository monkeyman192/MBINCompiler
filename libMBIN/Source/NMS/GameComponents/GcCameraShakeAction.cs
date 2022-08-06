using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5442BD7F600755C, NameHash = 0x8C20E93C658FEFB1)]
    public class GcCameraShakeAction : NMSTemplate
    {
        public NMSString0x10 Shake;
        public float FalloffMin;
        public float FalloffMax;
    }
}

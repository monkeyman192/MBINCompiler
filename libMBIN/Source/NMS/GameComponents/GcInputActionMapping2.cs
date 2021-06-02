using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x80, GUID = 0xBBAD577468CEE358, NameHash = 0xA119F734993CBE1E)]
    public class GcInputActionMapping2 : NMSTemplate
    {
        public NMSString0x20 ActionSet;
        public NMSString0x20 Action;
        public NMSString0x20 Button;
        public NMSString0x20 Axis;
    }
}

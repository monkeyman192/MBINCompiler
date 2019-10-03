using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x80, GUID = 0x0BBAD577468CEE358, NameHash = 0x0A119F734993CBE1E)]
    public class GcInputActionMapping2 : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string ActionSet;
        [NMS(Size = 0x20)]
        public string Action;
        [NMS(Size = 0x20)]
        public string Button;
        [NMS(Size = 0x20)]
        public string Axis;
    }
}

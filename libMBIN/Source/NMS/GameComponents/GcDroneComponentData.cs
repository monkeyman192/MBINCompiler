using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDroneComponentData : NMSTemplate
    {
        public NMSString0x10 Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
        public GcCreatureHealthData Health;
    }
}

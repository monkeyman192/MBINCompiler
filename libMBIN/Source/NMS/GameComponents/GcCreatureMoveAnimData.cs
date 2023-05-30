using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        public NMSString0x10 Anim;
        public NMSString0x10 AnimLeft;
        public NMSString0x10 AnimRight;

        public float AnimSpeed;
        public float MinSpeedScale;
        public float MaxSpeedScale;
        public float MaxPredatorSpeedScale;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkJointExtentData : NMSTemplate
    {
        [NMS(Size = 3)]
        public float[] JointExtentMin; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentMax; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentCenter; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentStdDev; // Vector3f
    }
}

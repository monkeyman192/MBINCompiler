using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x570DB1A0C98C0858, NameHash = 0xB538605B35EDD12C)]
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

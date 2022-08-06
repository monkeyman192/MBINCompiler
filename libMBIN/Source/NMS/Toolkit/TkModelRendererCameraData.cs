using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xDD354EFDC27E555, NameHash = 0xE2B8850DAEBB8F74)]
    public class TkModelRendererCameraData : NMSTemplate
    {
        public float Distance;
        public Vector3f Offset;
        public float Roll;
        public float Pitch;
        public float Rotate;
        public float LightPitch;
        public float LightRotate;
        public TkCameraWanderData Wander;
    }
}

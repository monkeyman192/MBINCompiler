using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x9CF176CBCC77BDC6, NameHash = 0x50CC62720AB69C5)]
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        [NMS(Size = 0x10)]
        public string AnimLeft;
        [NMS(Size = 0x10)]
        public string AnimRight;

        public float AnimSpeed;
        public float MinSpeedScale;
        public float MaxSpeedScale;
        public float MaxPredatorSpeedScale;
        public float AnimMoveSpeed;
        public bool AnimMoveSpeedCached;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

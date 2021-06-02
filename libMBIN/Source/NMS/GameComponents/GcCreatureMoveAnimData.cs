using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xD57D0C98B9949A51, NameHash = 0x50CC62720AB69C5)]
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public NMSString0x10 AnimLeft;
        /* 0x20 */ public NMSString0x10 AnimRight;
        /* 0x30 */ public float AnimSpeed;
        /* 0x34 */ public float MinSpeedScale;
        /* 0x38 */ public float MaxSpeedScale;
        /* 0x3C */ public float MaxPredatorSpeedScale;
        /* 0x40 */ public float MinPetSpeedScale;
        /* 0x44 */ public float MaxPetSpeedScale;
        /* 0x48 */ public float AnimMoveSpeed;
        /* 0x4C */ public bool AnimMoveSpeedCached;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4D */ public byte[] EndPadding;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DC6AD707DCBEFED, NameHash = 0x50CC62720AB69C5)]
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public NMSString0x10 AnimLeft;
        /* 0x20 */ public NMSString0x10 AnimRight;
        /* 0x30 */ public float AnimMoveSpeed;
        /* 0x34 */ public float AnimSpeed;
        /* 0x38 */ public float MaxPetSpeedScale;
        /* 0x3C */ public float MaxPredatorSpeedScale;
        /* 0x40 */ public float MaxSpeedScale;
        /* 0x44 */ public float MinPetSpeedScale;
        /* 0x48 */ public float MinSpeedScale;
        /* 0x4C */ public bool AnimMoveSpeedCached;
    }
}

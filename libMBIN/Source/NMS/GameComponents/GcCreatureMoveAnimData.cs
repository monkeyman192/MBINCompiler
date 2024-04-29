namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3BE34A55F235F3C, NameHash = 0x50CC62720AB69C5)]
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 AnimLeft;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 AnimRight;
        [NMS(Index = 9)]
        /* 0x30 */ public float AnimMoveSpeed;
        [NMS(Index = 3)]
        /* 0x34 */ public float AnimSpeed;
        [NMS(Index = 8)]
        /* 0x38 */ public float MaxPetSpeedScale;
        [NMS(Index = 6)]
        /* 0x3C */ public float MaxPredatorSpeedScale;
        [NMS(Index = 5)]
        /* 0x40 */ public float MaxSpeedScale;
        [NMS(Index = 7)]
        /* 0x44 */ public float MinPetSpeedScale;
        [NMS(Index = 4)]
        /* 0x48 */ public float MinSpeedScale;
        [NMS(Index = 10)]
        /* 0x4C */ public bool AnimMoveSpeedCached;
    }
}

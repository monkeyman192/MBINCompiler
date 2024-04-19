namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x68E1534AA565849E, NameHash = 0xC37B87DF4F026633)]
    public class TkJointMirrorAxis : NMSTemplate
    {
        /* 0x00 */ public int MirrorAxisMode;
        /* 0x04 */ public float RotAdjustW;
        /* 0x08 */ public float RotAdjustX;
        /* 0x0C */ public float RotAdjustY;
        /* 0x10 */ public float RotAdjustZ;
        /* 0x14 */ public float RotMirrorAxisX;
        /* 0x18 */ public float RotMirrorAxisY;
        /* 0x1C */ public float RotMirrorAxisZ;
        /* 0x20 */ public float TransMirrorAxisX;
        /* 0x24 */ public float TransMirrorAxisY;
        /* 0x28 */ public float TransMirrorAxisZ;
    }
}

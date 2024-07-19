namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3A807E379D7198C4, NameHash = 0x9525F86C)]
    public class TkJointMirrorAxis : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public int MirrorAxisMode;
        [NMS(Index = 6)]
        /* 0x04 */ public float RotAdjustW;
        [NMS(Index = 3)]
        /* 0x08 */ public float RotAdjustX;
        [NMS(Index = 4)]
        /* 0x0C */ public float RotAdjustY;
        [NMS(Index = 5)]
        /* 0x10 */ public float RotAdjustZ;
        [NMS(Index = 7)]
        /* 0x14 */ public float RotMirrorAxisX;
        [NMS(Index = 8)]
        /* 0x18 */ public float RotMirrorAxisY;
        [NMS(Index = 9)]
        /* 0x1C */ public float RotMirrorAxisZ;
        [NMS(Index = 0)]
        /* 0x20 */ public float TransMirrorAxisX;
        [NMS(Index = 1)]
        /* 0x24 */ public float TransMirrorAxisY;
        [NMS(Index = 2)]
        /* 0x28 */ public float TransMirrorAxisZ;
    }
}

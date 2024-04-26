namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDE7DC3F8636A4191, NameHash = 0xCABBB7951E50DCAF)]
    public class TkJointBindingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10)]
        /* 0x00 */ public float[] InvBindMatrix;
        [NMS(Index = 2, Size = 0x4)]
        /* 0x40 */ public float[] BindRotate;
        [NMS(Index = 3, Size = 0x3)]
        /* 0x50 */ public float[] BindScale;
        [NMS(Index = 1, Size = 0x3)]
        /* 0x5C */ public float[] BindTranslate;
    }
}

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA7661CCFD3D0504C, NameHash = 0x56688699)]
    public class TkAnimationNotify : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSTemplate Data;
        [NMS(Index = 2)]
        /* 0x10 */ public float EndFrame;
        [NMS(Index = 1)]
        /* 0x14 */ public float StartFrame;
        [NMS(Index = 3)]
        /* 0x18 */ public int Track;
    }
}

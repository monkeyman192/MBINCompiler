namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1B95A9165E8D804B, NameHash = 0x789352C972E7FBAA)]
    public class TkAnimPoseData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 2)]
        /* 0x10 */ public int FrameEnd;
        [NMS(Index = 1)]
        /* 0x14 */ public int FrameStart;
    }
}

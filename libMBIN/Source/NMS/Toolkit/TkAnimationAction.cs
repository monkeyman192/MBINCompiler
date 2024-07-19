namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCE3C651DF38E9888, NameHash = 0x1B5DE6E7)]
    public class TkAnimationAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public float EndFrame;
        [NMS(Index = 1)]
        /* 0x14 */ public float StartFrame;
    }
}

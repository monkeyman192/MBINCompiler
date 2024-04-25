namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CB27A10AF35501, NameHash = 0x6D7E63CBE4F67CF0)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public int FrameStart;
        [NMS(Index = 2)]
        /* 0x14 */ public bool StartFromEnd;
    }
}

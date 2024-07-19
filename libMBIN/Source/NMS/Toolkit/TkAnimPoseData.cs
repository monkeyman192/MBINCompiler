namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE38D15C49476C461, NameHash = 0x6ABBA097)]
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

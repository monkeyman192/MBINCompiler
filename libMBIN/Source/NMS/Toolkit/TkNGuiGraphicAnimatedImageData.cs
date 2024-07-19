namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x52C4DCEC012C708B, NameHash = 0x3198A29C)]
    public class TkNGuiGraphicAnimatedImageData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int FramesHorizontal;
        [NMS(Index = 2)]
        /* 0x04 */ public float FramesPerSecond;
        [NMS(Index = 5)]
        /* 0x08 */ public int FramesVertical;
        [NMS(Index = 3)]
        /* 0x0C */ public int TotalFrames;
        [NMS(Index = 0)]
        /* 0x10 */ public bool Active;
        [NMS(Index = 1)]
        /* 0x11 */ public bool BlendFrames;
    }
}

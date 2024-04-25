namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x395C092725929273, NameHash = 0x9C4DEE4AEE9C44E)]
    public class GcCameraShakeTriggerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public int FrameStart;
        [NMS(Index = 2)]
        /* 0x14 */ public NMSString0x20 Shake;
    }
}

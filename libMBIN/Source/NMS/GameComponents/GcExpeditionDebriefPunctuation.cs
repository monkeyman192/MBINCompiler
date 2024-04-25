namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEC6AF803887FF87, NameHash = 0x395C0EA1CCB017E2)]
    public class GcExpeditionDebriefPunctuation : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Delay;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x20 Punctuation;
    }
}

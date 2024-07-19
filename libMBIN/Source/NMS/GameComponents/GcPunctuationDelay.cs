namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD227D793E1851F0, NameHash = 0xA480616B)]
    public class GcPunctuationDelay : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Delay;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x20 Punctuation;
    }
}

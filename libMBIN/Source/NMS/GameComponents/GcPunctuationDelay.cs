namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18FCA1B628A26A1D, NameHash = 0x88FA9D134F35E97B)]
    public class GcPunctuationDelay : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Delay;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x20 Punctuation;
    }
}

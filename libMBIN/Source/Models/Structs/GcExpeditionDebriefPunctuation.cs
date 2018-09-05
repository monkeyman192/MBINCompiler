namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x24)]
    public class GcExpeditionDebriefPunctuation : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Punctuation;
        public float Delay;
    }
}

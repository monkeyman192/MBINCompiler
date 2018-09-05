namespace libMBIN.Models.Structs
{
    public class GcRewardWikiTopic : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Topic;
        public bool CentreMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16D35FBC45A45F80, NameHash = 0x67530B28A8F0F92)]
    public class GcMessageSummonAndDismiss : NMSTemplate
    {
        // size: 0x2
        public enum SummonEventTypeEnum : uint {
            Summon,
            Dismiss,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SummonEventTypeEnum SummonEventType;
    }
}

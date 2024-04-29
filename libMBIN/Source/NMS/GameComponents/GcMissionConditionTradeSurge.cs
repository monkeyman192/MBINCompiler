namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1147F59FA53EB7A, NameHash = 0xF393EBFBA97D4EF8)]
    public class GcMissionConditionTradeSurge : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ControllingScanEvent;
        // size: 0x3
        public enum SurgeTestTypeEnum : uint {
            Timer,
            Collection,
            Delivery,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public SurgeTestTypeEnum SurgeTestType;
        [NMS(Index = 1)]
        /* 0x24 */ public int TimeToCompleteInMinutes;
    }
}

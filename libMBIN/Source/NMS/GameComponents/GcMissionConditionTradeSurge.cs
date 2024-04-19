namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5E6B2F260D687F9, NameHash = 0xF393EBFBA97D4EF8)]
    public class GcMissionConditionTradeSurge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ControllingScanEvent;
        // size: 0x3
        public enum SurgeTestTypeEnum : uint {
            Timer,
            Collection,
            Delivery,
        }
        /* 0x20 */ public SurgeTestTypeEnum SurgeTestType;
        /* 0x24 */ public int TimeToCompleteInMinutes;
    }
}

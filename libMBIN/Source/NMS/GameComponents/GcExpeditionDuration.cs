namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E8C9B82EF4E5E52, NameHash = 0x406EA68C88F85056)]
    public class GcExpeditionDuration : NMSTemplate
    {
        // size: 0x5
        public enum ExpeditionDurationEnum : uint {
            VeryShort,
            Short,
            Medium,
            Long,
            VeryLong,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ExpeditionDurationEnum ExpeditionDuration;
    }
}

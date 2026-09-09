namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E96AC786F0F0464, NameHash = 0xA0869ED2)]
    public class GcDeliverableType : NMSTemplate
    {
        // size: 0x5
        public enum DeliverableTypeEnum : uint {
            Item1,
            Item2,
            Item3,
            Item4,
            Item5,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DeliverableTypeEnum DeliverableType;
    }
}

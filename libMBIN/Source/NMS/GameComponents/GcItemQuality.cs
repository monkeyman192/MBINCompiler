namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x327765612E1F7ED9, NameHash = 0xC4477DCA)]
    public class GcItemQuality : NMSTemplate
    {
        // size: 0x5
        public enum ItemQualityEnum : uint {
            Junk,
            Common,
            Rare,
            Epic,
            Legendary,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ItemQualityEnum ItemQuality;
    }
}

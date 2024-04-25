namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F577FBFBDC87668, NameHash = 0x7E6B18F25C0843D4)]
    public class GcStatDisplayType : NMSTemplate
    {
        // size: 0x3
        public enum StatDisplayTypeEnum : uint {
            None,
            Sols,
            Distance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatDisplayTypeEnum StatDisplayType;
    }
}

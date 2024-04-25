namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF25EE5283DBF5E4, NameHash = 0xC0B928F5E2599F60)]
    public class GcWealthClass : NMSTemplate
    {
        // size: 0x4
        public enum WealthClassEnum : uint {
            Poor,
            Average,
            Wealthy,
            Pirate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WealthClassEnum WealthClass;
    }
}

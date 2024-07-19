namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BB54B9C170BF01C, NameHash = 0x5E67C2D5)]
    public class GcTradingClass : NMSTemplate
    {
        // size: 0x7
        public enum TradingClassEnum : uint {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TradingClassEnum TradingClass;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA160E0C402E2DCA, NameHash = 0x95EF8673)]
    public class GcTradeCategory : NMSTemplate
    {
        // size: 0x9
        public enum TradeCategoryEnum : uint {
            Mineral,
            Tech,
            Commodity,
            Component,
            Alloy,
            Exotic,
            Energy,
            None,
            SpecialShop,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TradeCategoryEnum TradeCategory;
    }
}

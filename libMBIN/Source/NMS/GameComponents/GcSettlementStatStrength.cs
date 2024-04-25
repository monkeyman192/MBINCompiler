namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36C7F6656EB4C5C0, NameHash = 0x3B7C404C59D201EF)]
    public class GcSettlementStatStrength : NMSTemplate
    {
        // size: 0x7
        public enum SettlementStatStrengthEnum : uint {
            PositiveWide,
            PositiveLarge,
            PositiveMedium,
            PositiveSmall,
            NegativeSmall,
            NegativeMedium,
            NegativeLarge,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementStatStrengthEnum SettlementStatStrength;
    }
}

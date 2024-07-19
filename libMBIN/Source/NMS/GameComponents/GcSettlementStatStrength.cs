namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36C7F6656EB4C5C0, NameHash = 0x993C133D)]
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

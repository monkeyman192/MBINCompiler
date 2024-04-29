using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x482CD558CF988C13, NameHash = 0x3548FD5B88130DA1)]
    public class GcSettlementStatStrengthData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcSettlementStatStrength.SettlementStatStrengthEnum))]
        /* 0x0 */ public GcSettlementStatStrengthRanges[] PerkStatStrengthValues;
    }
}

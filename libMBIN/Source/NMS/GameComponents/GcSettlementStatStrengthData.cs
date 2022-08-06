using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E53BEC21A5D6E38, NameHash = 0x3548FD5B88130DA1)]
    public class GcSettlementStatStrengthData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatStrength.SettlementStatStrengthEnum))]
        public GcSettlementStatStrengthRanges[] PerkStatStrengthValues;
    }
}

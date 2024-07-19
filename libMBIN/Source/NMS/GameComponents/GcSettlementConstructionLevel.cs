namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA96B50DDF3B522E4, NameHash = 0xF1094533)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum : uint {
            Start,
            GroundStorey,
            RegularStorey,
            Roof,
            Decoration,
            Other,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}

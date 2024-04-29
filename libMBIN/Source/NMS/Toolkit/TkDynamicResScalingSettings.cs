namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x415F9F7A6A85B918, NameHash = 0x4ECB5D79E2F5CD94)]
    public class TkDynamicResScalingSettings : NMSTemplate
    {
        // size: 0x3
        public enum DynamicResScalingAggressivenessEnum : uint {
            Moderate,
            Balanced,
            Aggressive,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public DynamicResScalingAggressivenessEnum DynamicResScalingAggressiveness;
        [NMS(Index = 0)]
        /* 0x4 */ public float LowestDynamicResScalingFactor;
    }
}

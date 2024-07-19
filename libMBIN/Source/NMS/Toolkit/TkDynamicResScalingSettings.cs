namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2D1136770F659038, NameHash = 0x10AD2F18)]
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
        [NMS(Index = 2)]
        /* 0x4 */ public float FrametimeHeadroomProportion;
        [NMS(Index = 0)]
        /* 0x8 */ public float LowestDynamicResScalingFactor;
    }
}

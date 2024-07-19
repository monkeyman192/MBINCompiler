namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB17C2748189B63D2, NameHash = 0x912D00C7)]
    public class TkAnimStateMachineTransitionConditionFloatData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Parameter;
        [NMS(Index = 2)]
        /* 0x10 */ public float CompareValue;
        // size: 0x4
        public enum FloatComparisonModeEnum : uint {
            LessThan,
            LessThanEqual,
            GreaterThanEqual,
            GreaterThan,
        }
        [NMS(Index = 1)]
        /* 0x14 */ public FloatComparisonModeEnum FloatComparisonMode;
    }
}

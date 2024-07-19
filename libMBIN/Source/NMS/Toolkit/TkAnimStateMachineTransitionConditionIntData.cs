namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D9DEE183EFDE192, NameHash = 0xAC9394B6)]
    public class TkAnimStateMachineTransitionConditionIntData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Parameter;
        [NMS(Index = 2)]
        /* 0x10 */ public int CompareValue;
        // size: 0x5
        public enum IntComparisonModeEnum : uint {
            LessThan,
            LessThanEqual,
            Equal,
            GreaterThanEqual,
            GreaterThan,
        }
        [NMS(Index = 1)]
        /* 0x14 */ public IntComparisonModeEnum IntComparisonMode;
    }
}

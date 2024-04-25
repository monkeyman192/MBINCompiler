namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1B9710CC397E213C, NameHash = 0x42F1604851DA7F02)]
    public class TkSketchConditions : NMSTemplate
    {
        // size: 0x6
        public enum ConditionEnum : uint {
            Equal,
            NotEqual,
            Greater,
            Less,
            GreaterEqual,
            LessEqual,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ConditionEnum Condition;
    }
}

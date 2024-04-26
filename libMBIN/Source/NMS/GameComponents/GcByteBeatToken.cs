namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3F301BA6206E62D, NameHash = 0x1FC756C2E641CC49)]
    public class GcByteBeatToken : NMSTemplate
    {
        // size: 0x12
        public enum ByteBeatTokenEnum : uint {
            T,
            AND,
            OR,
            XOR,
            Plus,
            Minus,
            Multiply,
            Divide,
            Modulo,
            ShiftLeft,
            ShiftRight,
            Greater,
            GreaterEqual,
            Less,
            LessEqual,
            Number,
            OpenParenthesis,
            CloseParenthesis,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ByteBeatTokenEnum ByteBeatToken;
    }
}

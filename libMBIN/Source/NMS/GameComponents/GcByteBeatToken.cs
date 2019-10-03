using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD39783A62EFAAC70, NameHash = 0x1FC756C2E641CC49)]
    public class GcByteBeatToken : NMSTemplate
    {
        // 0x12 entires
        public enum ByteBeatTokenEnum { T, AND, OR, XOR, Plus, Minus, Multiply, Divide, Modulo, ShiftLeft, ShiftRight, Greater, GreaterEqual, Less, LessEqual, Number, OpenParenthesis, CloseParenthesis }
        public ByteBeatTokenEnum ByteBeatToken;
    }
}

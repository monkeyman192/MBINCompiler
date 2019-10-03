using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x665132377002D9D1, NameHash = 0xCBAB5DE09174FF0A)]
    public class GcStatValueData : NMSTemplate
    {
        public int IntValue;
        public float FloatValue;
        public float Denominator;
    }
}

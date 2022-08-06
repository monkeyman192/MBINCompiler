using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x665132377002D9D1, NameHash = 0xCBAB5DE09174FF0A)]
    public class GcStatValueData : NMSTemplate
    {
        /* 0x00 */ public int IntValue;
        /* 0x04 */ public float FloatValue;
        /* 0x08 */ public float Denominator;
    }
}


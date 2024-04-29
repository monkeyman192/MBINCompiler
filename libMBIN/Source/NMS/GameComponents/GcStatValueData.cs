namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78D9619FC5A61DB7, NameHash = 0xCBAB5DE09174FF0A)]
    public class GcStatValueData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float Denominator;
        [NMS(Index = 1)]
        /* 0x4 */ public float FloatValue;
        [NMS(Index = 0)]
        /* 0x8 */ public int IntValue;
    }
}

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBF47086F53468551, NameHash = 0x359F7497)]
    public class TkFloatRange : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Maximum;
        [NMS(Index = 0)]
        /* 0x4 */ public float Minimum;
    }
}
